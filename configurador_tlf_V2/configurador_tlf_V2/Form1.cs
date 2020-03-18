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

        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection Conexion = new MySqlConnection("server=remotemysql.com; database=wWWHH1xcMX; Uid=wWWHH1xcMX; pwd=MmxyP2R8ey");
        DataSet ds;
        DataSet ds2;

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            notariaabuscar = buscadornotaria.Text.ToString();
            gridnotarias.DataSource = "<<>>";



            Conexion.Open();
            MySqlCommand mostrar = new MySqlCommand("SELECT Id ,NomNotaria, IPCentralita, MascaraRed, PuertaEnlace FROM centralita WHERE NomNotaria LIKE '%" + notariaabuscar + "%'", Conexion);

            MySqlDataAdapter m_datos = new MySqlDataAdapter(mostrar);
            ds = new DataSet();
            m_datos.Fill(ds);
            Conexion.Close();
            gridnotarias.DataSource = ds.Tables[0];

            gridnotarias.Columns["Id"].Visible = false;
            gridnotarias.Columns[1].HeaderText = "Nombre de la notaría";
            gridnotarias.Columns[2].HeaderText = "IP Centralita";
            gridnotarias.Columns[3].HeaderText = "Máscara de red";
            gridnotarias.Columns[4].HeaderText = "Puerta de enlace";
            gridnotarias.Columns[1].Width = 150;

        }


        private void gridnotarias_SelectionChanged(object sender, EventArgs e)
        {
            Conexion.Open();
            foreach (DataGridViewRow row in gridnotarias.SelectedRows)
            {
                idbuscarext = row.Cells[0].Value.ToString();

                ipcentralitainput.Text = "";
                mascararedinput.Text = "";
                puertadeenlaceinput.Text = "";
                extensioninput.Text = "";
                ipaonfigurarinput.Text = "";
                aliasinput.Text = "";

                String ipcentralitanotaria = row.Cells[2].Value.ToString();
                ipcentralitainput.Text = ipcentralitanotaria;

                String mascararednotaria = row.Cells[3].Value.ToString();
                mascararedinput.Text = mascararednotaria;

                String puertaenlacenotaria = row.Cells[4].Value.ToString();
                puertadeenlaceinput.Text = puertaenlacenotaria;

            }
            MySqlCommand mostrar2 = new MySqlCommand("SELECT Extension, Iptelefono, Alias, NomNotaria FROM telefonos WHERE IDNotaria ='" + idbuscarext + "' ORDER BY Extension", Conexion);
            MySqlDataAdapter m_datos2 = new MySqlDataAdapter(mostrar2);
            ds2 = new DataSet();
            m_datos2.Fill(ds2);


            gridextensiones.DataSource = ds2.Tables[0];
            Conexion.Close();

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

            foreach (DataGridViewRow row in gridnotarias.SelectedRows)
            {
                nombrenotariaext = row.Cells[1].Value.ToString();

            }

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
    }
}
