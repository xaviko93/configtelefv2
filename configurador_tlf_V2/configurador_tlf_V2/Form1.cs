using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace configurador_tlf_V2
{

    public partial class Form1 : Form
    {

        public String notariaabuscar;
        public String idbuscarext;
        public int extensionocupada;
        public int contadorintentos;
        public String nombrenotariaext;
        public String ipcentralitaext;
        public String mascaraext;
        public String puertaenlaceext;
        public int contadorext;
        public int ultimocachonumeroaconfig;

        public Form1()
        {
            InitializeComponent();

            listamodelo.Items.Add("YEALINK T27G");
            listamodelo.Items.Add("YEALINK T23G");
            listamodelo.SelectedIndex = 0;
        }

        MySqlConnection Conexion = new MySqlConnection("server=remotemysql.com; database=wWWHH1xcMX; Uid=wWWHH1xcMX; pwd=MmxyP2R8ey");
        DataSet ds;
        DataSet ds2;

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new BuscarNotaria();
            frm.Show();

        }




        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                NTLF.Enabled = true;
                NTLFinput.Enabled = true;
                textoipaconfigurar.Enabled = false;
                ipaonfigurarinput.Enabled = false;
                textoipcentralita.Enabled = false;
                ipcentralitainput.Enabled = false;
                textoextension.Enabled = false;
                extensioninput.Enabled = false;
                textopuertadeenlace.Enabled = false;
                puertadeenlaceinput.Enabled = false;
                textomascarared.Enabled = false;
                mascararedinput.Enabled = false;
                aliasinput.Enabled = false;
                textoalias.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                NTLF.Enabled = false;
                NTLFinput.Enabled = false;
                textoipaconfigurar.Enabled = true;
                ipaonfigurarinput.Enabled = true;
                textoipcentralita.Enabled = true;
                ipcentralitainput.Enabled = true;
                textoextension.Enabled = true;
                extensioninput.Enabled = true;
                textopuertadeenlace.Enabled = true;
                puertadeenlaceinput.Enabled = true;
                textomascarared.Enabled = true;
                mascararedinput.Enabled = true;
                aliasinput.Enabled = true;
                textoalias.Enabled = true;
            }
        }

        private void gridextensiones_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gridextensiones.SelectedRows)
            {
                extensioninput.Text = "";
                ipaonfigurarinput.Text = "";
                aliasinput.Text = "";

                String extensionlinea = row.Cells[0].Value.ToString();
                extensioninput.Text = extensionlinea;

                String iptelefonolinea = row.Cells[1].Value.ToString();
                ipaonfigurarinput.Text = iptelefonolinea;

                String aliaslinea = row.Cells[2].Value.ToString();
                aliasinput.Text = aliaslinea;
            }
        }

        private void btnnuevoext_Click(object sender, EventArgs e)
        {
            int numerototalext = gridextensiones.SelectedRows.Count;
            String extensionprimerastring = gridextensiones.Rows[0].Cells[0].Value.ToString();
            extensionocupada = Int32.Parse(extensionprimerastring);
            int contadorext = Int32.Parse(extensionprimerastring);
            contadorintentos = 1;

            while (contadorext == extensionocupada)
            {
                String extensionocupadastring = gridextensiones.Rows[contadorintentos].Cells[0].Value.ToString();
                extensionocupada = Int32.Parse(extensionocupadastring);
                contadorext++;
                contadorintentos++;
            }

            int contadorintentosbien = contadorintentos - 2;
            String iplibreext = gridextensiones.Rows[contadorintentosbien].Cells[1].Value.ToString();
            string[] ultimocachoip = iplibreext.Split('.');
            int ultimocachonumero = Int32.Parse(ultimocachoip[3]);
            ultimocachonumero++;
            string ipaasignaraext = ultimocachoip[0] + "." + ultimocachoip[1] + "." + ultimocachoip[2] + "." + ultimocachonumero;


            nombrenotariaext = buscadornotaria.Text.ToString();
            DataTable dt = (DataTable)gridextensiones.DataSource;
            var row2 = dt.NewRow();
            row2["Extension"] = contadorext;
            row2["Iptelefono"] = ipaasignaraext;
            row2["Alias"] = contadorext;
            row2["NomNotaria"] = nombrenotariaext;
            //resto
            dt.Rows.Add(row2);
            gridextensiones.DataSource = dt;
            this.gridextensiones.Sort(this.gridextensiones.Columns["Extension"], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar esta extensión? Si la eliminas no será configurada su extensión en los teléfonos que configures", "Eliminar extensión", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                gridextensiones.Rows.RemoveAt(gridextensiones.CurrentRow.Index);
            }
            
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {

                gridtelefonosaconfigurar.Rows.Clear();

                String cantidadtlfaconfigurarstring = NTLFinput.Value.ToString();
                int cantidadtlfaconfigurar = Int32.Parse(cantidadtlfaconfigurarstring);

                int numerototalext = gridextensiones.SelectedRows.Count;
                try
                {
                    String extensionprimerastring = gridextensiones.Rows[0].Cells[0].Value.ToString();
                    extensionocupada = Int32.Parse(extensionprimerastring);
                    contadorext = Int32.Parse(extensionprimerastring);

                } catch (System.ArgumentOutOfRangeException) { }
                

                contadorintentos = 1;

                int contadorintentosbien = contadorext - 2;
                String iplibreext = gridextensiones.Rows[0].Cells[1].Value.ToString();
                string[] ultimocachoip = iplibreext.Split('.');
                int ultimocachonumero = Int32.Parse(ultimocachoip[3]);

                string ipaconfigurartexto = ipactualinput.Text.ToString();
                string[] ultimocachoipaconfnigurar = ipactualinput.Text.ToString().Split('.');
                ultimocachonumeroaconfig = Int32.Parse(ultimocachoipaconfnigurar[3]);

                for (int i = 1; i <= cantidadtlfaconfigurar; i++)
                {

                    while (contadorext == extensionocupada)
                    {
                        try
                        {
                            String extensionocupadastring = gridextensiones.Rows[contadorintentos].Cells[0].Value.ToString();
                            extensionocupada = Int32.Parse(extensionocupadastring);
                        }
                        catch (NullReferenceException){}

                        contadorext++;
                        contadorintentos++;
                        ultimocachonumero++;
                    }

                    string ipaasignaraext = ultimocachoip[0] + "." + ultimocachoip[1] + "." + ultimocachoip[2] + "." + ultimocachonumero;


                        nombrenotariaext = buscadornotaria.Text.ToString();
                        ipcentralitaext = ipcentralitanotaria.Text.ToString();
                        mascaraext = mascararednotaria.Text.ToString();
                        puertaenlaceext = puertaenlacenotaria.Text.ToString();
                    

                    if (nombrenotariaext == "" || ipaasignaraext == "" || ipcentralitaext == "" || mascaraext == "" || puertaenlaceext == "" || ipaconfigurartexto == "")
                    {
                        MessageBox.Show("Hay campos vacíos, revisa los datos introducidos para continuar", "Datos incompletos");
                        break;
                    }

                    String modelotlf = listamodelo.SelectedItem.ToString();
                    gridtelefonosaconfigurar.Rows.Add(contadorext, contadorext, ipaasignaraext, ipaconfigurartexto, modelotlf, nombrenotariaext, ipcentralitaext, mascaraext, puertaenlaceext);
                    contadorext++;
                    ultimocachonumero++;

                    if (checkmulticonfig.Checked == true)
                        ultimocachonumeroaconfig++;
                        ipaconfigurartexto = ultimocachoipaconfnigurar[0] + "." + ultimocachoipaconfnigurar[1] + "." + ultimocachoipaconfnigurar[2] + "." + ultimocachonumeroaconfig;
                    }
                }

            if (radioButton2.Checked == true)
            {
                nombrenotariaext = buscadornotaria.Text.ToString();



                String extensiontlf = extensioninput.Text.ToString();
                String aliastlf = aliasinput.Text.ToString();
                String iptlf = ipactualinput.Text.ToString();
                String ipaconfigurartlf = ipaonfigurarinput.Text.ToString();
                String modelotlf = listamodelo.SelectedItem.ToString();
                String ipcentralitatlf = ipcentralitainput.Text.ToString();
                String mascaratlf = mascararedinput.Text.ToString();
                String puertatlf = puertadeenlaceinput.Text.ToString();

                if (aliasinput.Text.ToString() == "")
                {
                    aliastlf = extensioninput.Text.ToString();
                }

                if (nombrenotariaext == "" || extensiontlf == "" || iptlf == "" || puertaenlaceext == "" || ipaconfigurartlf == "" || modelotlf == "" || ipcentralitatlf == "" || mascaratlf == "" || puertatlf == "")
                {
                    MessageBox.Show("Hay campos vacíos, revisa los datos introducidos introducidos en el cuadro de teléfonos", "Datos incompletos");
                }

                gridtelefonosaconfigurar.Rows.Add(extensiontlf, aliastlf, iptlf, ipaconfigurartlf, modelotlf, nombrenotariaext, ipcentralitatlf, mascaratlf, puertatlf);


            }
        }

        private void btneliminartlf_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar este teléfono?", "Eliminar teléfono", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                gridtelefonosaconfigurar.Rows.RemoveAt(gridtelefonosaconfigurar.CurrentRow.Index);
            }
        }
    }
}
