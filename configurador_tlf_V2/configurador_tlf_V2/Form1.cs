using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
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
        public int idnotariaseleccionada;
        public String extensionprimerastring;
        public bool IsReady = true;
        public String ipactualtelefono;

        public Form1()
        {
            InitializeComponent();

            listamodelo.Items.Add("YEALINK T27G");
            listamodelo.Items.Add("YEALINK T23G");
            listamodelo.SelectedIndex = 0;

            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            cmb.HeaderText = "Modelo";
            cmb.Name = "Modelo";
            cmb.MaxDropDownItems = 4;
            cmb.Items.Add("YEALINK T27G");
            cmb.Items.Add("YEALINK T23G");
            gridtelefonosaconfigurar.Columns.Add(cmb);

            webBrowser1.ScriptErrorsSuppressed = true;
            

            using (var key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(
            @"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION",
            true))
            {
                var app = System.IO.Path.GetFileName(Application.ExecutablePath);
                key.SetValue(app, 11001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }


            gridextensiones.Columns.Add("Extension", "Extension");
            gridextensiones.Columns.Add("IP Telefono", "IP Telefono");
            gridextensiones.Columns.Add("Alias", "Alias");
            gridextensiones.Columns.Add("Nombre Notaria", "Nombre Notaria");
            gridextensiones.Columns.Add("IP Centralita", "IP Centralita");
            gridextensiones.Columns.Add("Mascara de red", "Mascara de red");
            gridextensiones.Columns.Add("Puerta de enlace", "Puerta de enlace");

        }



        MySqlConnection Conexion = new MySqlConnection("server=remotemysql.com; database=wWWHH1xcMX; Uid=wWWHH1xcMX; pwd=MmxyP2R8ey");
        DataSet ds;
        DataSet ds2;

        private void button1_Click(object sender, EventArgs e)
        {
            
            checkNotariaManual.Checked = false;
            radioAutomatica.Checked = true;
            Form frm = new BuscarNotaria();
            AddOwnedForm(frm);
            frm.Show();

        }

        public void cargarextensiones()
        {
            Conexion.Open();

                ipcentralitainput.Text = "";
                mascararedinput.Text = "";
                puertadeenlaceinput.Text = "";
                extensioninput.Text = "";
                ipaonfigurarinput.Text = "";
                aliasinput.Text = "";

                ipcentralitainput.Text = ipcentralitanotaria.Text.ToString();

                mascararedinput.Text = mascararednotaria.Text.ToString();

                puertadeenlaceinput.Text = puertaenlacenotaria.Text.ToString();

            try
            {
                     
            gridextensiones.Columns.Remove("Extension");
            gridextensiones.Columns.Remove("IP Telefono");
            gridextensiones.Columns.Remove("Alias");
            gridextensiones.Columns.Remove("Nombre Notaria");
            gridextensiones.Columns.Remove("IP Centralita");
            gridextensiones.Columns.Remove("Mascara de red");
            gridextensiones.Columns.Remove("Puerta de enlace");
            }
            catch { }


            MySqlCommand mostrar2 = new MySqlCommand("SELECT Extension, Iptelefono, Alias, Modelo, NomNotaria FROM telefonos WHERE IDNotaria ='" + idnotariaseleccionada + "' ORDER BY Extension", Conexion);
            MySqlDataAdapter m_datos2 = new MySqlDataAdapter(mostrar2);
            ds2 = new DataSet();
            m_datos2.Fill(ds2);

            gridextensiones.DataSource = ds2.Tables[0];
            Conexion.Close();
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {


            
                if (radioAutomatica.Checked == true)
                {
                    if (checkNotariaManual.Checked == true)
                    {
                        MessageBox.Show("No puedes seleccionar la configuración automática de teléfonos con el modo notaría manual activado");
                        radioManual.Checked = true;
                    }
                else
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
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioManual.Checked == true)
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
            try
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
            } catch (System.NullReferenceException)
            {

            }

        }

        private void btnnuevoext_Click(object sender, EventArgs e)
        {
                
            if (checkNotariaManual.Checked == true)
            {


                gridextensiones.Rows.Add("", "", "", buscadornotaria.Text.ToString(), ipcentralitanotaria.Text.ToString(), mascararednotaria.Text.ToString(), puertaenlacenotaria.Text.ToString());

                ipcentralitainput.Text = ipcentralitanotaria.Text.ToString();
                mascararedinput.Text = mascararednotaria.Text.ToString();
                puertadeenlaceinput.Text = puertaenlacenotaria.Text.ToString();


            } else
            {
                int numerototalext = gridextensiones.SelectedRows.Count;
                try
                {
                    extensionprimerastring = gridextensiones.Rows[0].Cells[0].Value.ToString();
                    extensionocupada = Int32.Parse(extensionprimerastring);
                    int contadorext = Int32.Parse(extensionprimerastring);

                
         

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
                catch (System.ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Debes introducir una notaría para poder añadir extensiones. Si no quieres seleccionar ninguna Notaría de la lista marca el check Notaría manual", "Falta notaría");
                }
                catch (System.NullReferenceException)
                {
                    MessageBox.Show("Debes introducir una notaría para poder añadir extensiones. Si no quieres seleccionar ninguna Notaría de la lista marca el check Notaría manual", "Falta notaría");
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Debes introducir una notaría para poder añadir extensiones. Si no quieres seleccionar ninguna Notaría de la lista marca el check Notaría manual", "Falta notaría");
                }
            }



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
            if(radioAutomatica.Checked == true)
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
                String iplibreext = gridextensiones.Rows[0].Cells[1].Value.ToString().Trim(' ');
                string[] ultimocachoip = iplibreext.Split('.');
                int ultimocachonumero = Int32.Parse(ultimocachoip[3]);
                string ipaconfigurartexto = ipactualinput.Text.ToString();
                string[] ultimocachoipaconfnigurar = ipactualinput.Text.ToString().Split('.');
                try
                {
                    ultimocachonumeroaconfig = Int32.Parse(ultimocachoipaconfnigurar[3]);
                } catch (System.IndexOutOfRangeException)
                {
                    MessageBox.Show("Revisa el campo de texto IP Actual Es posible que la IP no esté introducida en el formato correcto");
                    
                }

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
                    ipcentralitaext = ipcentralitanotaria.Text.ToString().Trim(' ');
                    mascaraext = mascararednotaria.Text.ToString().Trim(' ');
                    puertaenlaceext = puertaenlacenotaria.Text.ToString().Trim(' ');

                    if (ipaconfigurartexto == "")
                    {
                        break;
                    }
                    

                    if (nombrenotariaext == "" || ipaasignaraext == "" || ipcentralitaext == "" || mascaraext == "" || puertaenlaceext == "")
                    {
                        MessageBox.Show("Hay campos vacíos, revisa los datos introducidos para continuar", "Datos incompletos");
                        break;
                    }

                    String modelotlf = listamodelo.SelectedItem.ToString().Trim(' ');
                    gridtelefonosaconfigurar.Rows.Add(contadorext, contadorext, ipaasignaraext, ipaconfigurartexto, nombrenotariaext, ipcentralitaext, mascaraext, puertaenlaceext, modelotlf);
                    contadorext++;
                    ultimocachonumero++;

                    if (checkmulticonfig.Checked == true)
                        ultimocachonumeroaconfig++;
                        ipaconfigurartexto = ultimocachoipaconfnigurar[0] + "." + ultimocachoipaconfnigurar[1] + "." + ultimocachoipaconfnigurar[2] + "." + ultimocachonumeroaconfig;
                    }

                btnconfigurar.Enabled = true;
                }

            if (radioManual.Checked == true)
            {
                nombrenotariaext = buscadornotaria.Text.ToString();



                int extensiontlf = Convert.ToInt32(extensioninput.Text);
                String aliastlf = aliasinput.Text.ToString();
                String iptlf = ipactualinput.Text.ToString().Trim(' ');
                String ipaconfigurartlf = ipaonfigurarinput.Text.ToString().Trim(' ');
                String modelotlf = listamodelo.SelectedItem.ToString();
                String ipcentralitatlf = ipcentralitainput.Text.ToString().Trim(' ');
                String mascaratlf = mascararedinput.Text.ToString().Trim(' ');
                String puertatlf = puertadeenlaceinput.Text.ToString().Trim(' ');

                if (aliasinput.Text.ToString() == "")
                {
                    aliastlf = extensioninput.Text.ToString();
                }

                if (nombrenotariaext == "" || extensiontlf.ToString() == "" || iptlf == "" || puertaenlaceext == "" || ipaconfigurartlf == "" || modelotlf == "" || ipcentralitatlf == "" || mascaratlf == "" || puertatlf == "")
                {
                    MessageBox.Show("Hay campos vacíos, revisa los datos introducidos introducidos en el cuadro de teléfonos", "Datos incompletos");
                }

                gridtelefonosaconfigurar.Rows.Add(extensiontlf, aliastlf, ipaconfigurartlf, iptlf, nombrenotariaext, ipcentralitatlf, mascaratlf, puertatlf, modelotlf);

                btnconfigurar.Enabled = true;
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

        private void checkNotariaManual_CheckedChanged(object sender, EventArgs e)
        {

            if (checkNotariaManual.Checked == true)
            {
                buscadornotaria.Text = "";
                buscadornotaria.Enabled = true;
                ipcentralitanotaria.Text = "";
                ipcentralitanotaria.Enabled = true;
                mascararednotaria.Text = "";
                mascararednotaria.Enabled = true;
                puertaenlacenotaria.Text = "";
                puertaenlacenotaria.Enabled = true;

                radioManual.Checked = true;

                do
                {
                    foreach (DataGridViewRow row in gridextensiones.Rows)
                    {
                        try
                        {
                            gridextensiones.Rows.Remove(row);
                        }
                        catch (Exception) { }
                    }
                } while (gridextensiones.Rows.Count > 1);
            }

            if (checkNotariaManual.Checked == false)
            {
                buscadornotaria.Enabled = false;
                ipcentralitanotaria.Enabled = false;
                mascararednotaria.Enabled = false;
                puertaenlacenotaria.Enabled = false;

                radioAutomatica.Checked = true;
            }



        }

        private void btnprobar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in gridtelefonosaconfigurar.SelectedRows)
                {
                   String iptelefonolinea = row.Cells[3].Value.ToString();
                    ipaonfigurarinput.Text = iptelefonolinea;

                    webBrowser1.Navigate("http://" + iptelefonolinea);
                }
            }
            catch (System.NullReferenceException)
            {
                webBrowser1.Navigate("http://" + ipactualinput.Text);
            }

            
        }

        public void btnconfigurar_Click(object sender, EventArgs e)
        {
            label11.Visible = true;
            label3.Visible = true;
            aliasprogreso.Visible = true;
            textoproceso.Visible = true;
            label7.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            progressBartlf.Visible = true;
            progressBartotal.Visible = true;
            numeroactual.Visible = true;
            numerototal.Visible = true;

            configuradordetelefonos();
        }

        public async Task configuradordetelefonos()
        {
            int totalfilas = gridtelefonosaconfigurar.Rows.Count - 1;

            progressBartotal.Maximum = totalfilas;
            progressBartotal.Value = 0;
            numerototal.Text = totalfilas.ToString();

            for (int i = 0; i < totalfilas; i++)
            {
                int numerotelefonoactual = progressBartotal.Value + 1;
                numeroactual.Text = numerotelefonoactual.ToString();
                int extensiontelefono = (int)gridtelefonosaconfigurar.Rows[i].Cells[0].Value;
                String aliastelefono = gridtelefonosaconfigurar.Rows[i].Cells[1].Value.ToString();
                String iptelefonoaconfigurar = gridtelefonosaconfigurar.Rows[i].Cells[2].Value.ToString();
                ipactualtelefono = gridtelefonosaconfigurar.Rows[i].Cells[3].Value.ToString();
                String ipcentralitatelefono = gridtelefonosaconfigurar.Rows[i].Cells[5].Value.ToString();
                String mascaraderedtelefono = gridtelefonosaconfigurar.Rows[i].Cells[6].Value.ToString();
                String puertadeenlacetelefono = gridtelefonosaconfigurar.Rows[i].Cells[7].Value.ToString();
                String modelotelefonoaconfigurar = gridtelefonosaconfigurar.Rows[i].Cells[8].Value.ToString();
                aliasprogreso.Text = aliastelefono;
                switch (modelotelefonoaconfigurar)
                {
                    case "YEALINK T27G":
                        if (checkmulticonfig.Checked == false)
                        {
                            await mensajerecordatorio();
                        }
                        await configurart27gAsync(ipactualtelefono, extensiontelefono, aliastelefono, ipcentralitatelefono, iptelefonoaconfigurar, mascaraderedtelefono, puertadeenlacetelefono);
                        break;

                    case "YEALINK T23G":
                        break;
                }
                progressBartotal.Value += 1;
            }
            MessageBox.Show("Configuración terminada");
        }

        public async Task mensajerecordatorio()
        {
            MessageBox.Show("Asegúrate de tener el teléfono configurado en Español y conectado con la IP: " + ipactualtelefono, "Comprobación");
        }

        public async Task configurart27gAsync(String ipactualtelefono, int extensiontelefono, String aliastelefono, String ipcentralitatelefono, String iptelefonoaconfigurar, String mascaraderedtelefono, String puertadeenlacetelefono)
        {
                TELEFONOS.YEALINKT27G T27G = new TELEFONOS.YEALINKT27G();
                
                progressBartlf.Maximum = 4;
                progressBartlf.Value = 0;
                textoproceso.Text = "GENERAL";
                await T27G.configuraciongeneralAsync(ipactualtelefono, extensiontelefono, aliastelefono, ipcentralitatelefono, webBrowser1);
                progressBartlf.Value += 1;
                textoproceso.Text = "EXTENSIONES";
                await T27G.limpiaryconfigurarextensiones(ipactualtelefono, webBrowser1, gridextensiones, gridtelefonosaconfigurar, extensiontelefono);
                progressBartlf.Value += 1;
                await T27G.configurarextensionestlfaconfigurar(ipactualtelefono, webBrowser1, gridextensiones, gridtelefonosaconfigurar, extensiontelefono);
                progressBartlf.Value += 1;
                textoproceso.Text = "RED";
                await T27G.configurarred(ipactualtelefono, webBrowser1, iptelefonoaconfigurar, mascaraderedtelefono, puertadeenlacetelefono);
                progressBartlf.Value += 1;
                textoproceso.Text = "TERMINADO";
        }
    }
}
