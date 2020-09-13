using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading;
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
        public String extensionprimerastring;
        public bool IsReady = true;
        public String ipactualtelefono;
        public String resultadomysql;
        DataTable dt = new DataTable();
        public String aliasviejo;
        public String iptelefonovieja;
        public String modeloviejo;
        public String nserieviejo;

        public Form1()
        {
            InitializeComponent();

            listamodelo.Items.Add("YEALINK T27G");
            listamodelo.Items.Add("YEALINK T26P");
            listamodelo.Items.Add("YEALINK W52P");
            listamodelo.SelectedIndex = 0;

            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            cmb.HeaderText = "Modelo";
            cmb.Name = "Modelo";
            cmb.MaxDropDownItems = 4;
            cmb.Items.Add("YEALINK T27G");
            cmb.Items.Add("YEALINK T26P");
            cmb.Items.Add("YEALINK W52P");

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
            gridextensiones.Columns.Add("Nserie", "Nserie");
            gridextensiones.Columns.Add("Nombre Notaria", "Nombre Notaria");
            gridextensiones.Columns.Add("IP Centralita", "IP Centralita");
            gridextensiones.Columns.Add("Mascara de red", "Mascara de red");
            gridextensiones.Columns.Add("Puerta de enlace", "Puerta de enlace");

        }



        MySqlConnection Conexion = new MySqlConnection("server=datostelefonos.ddnsfree.com; database=datostelefonos; Uid=jlozano ; pwd=raper0_legendari0; port=36970");
        DataSet ds;
        DataSet ds2;

        private void button1_Click(object sender, EventArgs e)
        {
            
            checkNotariaManual.Checked = false;
            radioAutomatica.Checked = true;

            this.Hide();
            Form frm = new BuscarNotaria();
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(this.Location.X + (this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);
            frm.Show(this);

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
            gridextensiones.Columns.Remove("Nserie");
            gridextensiones.Columns.Remove("Nombre Notaria");
            gridextensiones.Columns.Remove("IP Centralita");
            gridextensiones.Columns.Remove("Mascara de red");
            gridextensiones.Columns.Remove("Puerta de enlace");
            }
            catch { }


            MySqlCommand mostrar2 = new MySqlCommand("SELECT Extension, Iptelefono, Alias, Nserie, Modelo, NomNotaria FROM telefonos WHERE NomNotaria ='" + buscadornotaria.Text.ToString() + "' ORDER BY Extension", Conexion);
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
                    String extensionocupadastring = gridextensiones.Rows[contadorintentos + 1].Cells[0].Value.ToString();
                    extensionocupada = Int32.Parse(extensionocupadastring);
                    contadorext++;
                    contadorintentos++;
                }

                int contadorintentosbien = contadorintentos - 2;
                String iplibreext = gridextensiones.Rows[contadorintentos].Cells[1].Value.ToString();
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
                    MessageBox.Show("Revisa el campo de texto IP Actual. (Es posible que la IP no esté introducida en el formato correcto)");
                    
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
                    gridtelefonosaconfigurar.Rows.Add(contadorext, contadorext, ipaasignaraext, "", ipaconfigurartexto, nombrenotariaext, ipcentralitaext, mascaraext, puertaenlaceext, modelotlf);
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

                gridtelefonosaconfigurar.Rows.Add(extensiontlf, aliastlf, ipaconfigurartlf, "", iptlf, nombrenotariaext, ipcentralitatlf, mascaratlf, puertatlf, modelotlf);

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

            try
            {
                Conexion.Close();
            } catch{ }

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
                   String iptelefonolinea = row.Cells[4].Value.ToString();
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
            int numerotelefonos = gridtelefonosaconfigurar.Rows.Count - 1;
            Conexion.Open();

            for (int i = 0; i < numerotelefonos; i++)
            {
                if (gridtelefonosaconfigurar.Rows[i].Cells[3].Value == null || gridtelefonosaconfigurar.Rows[i].Cells[3].Value == DBNull.Value || String.IsNullOrWhiteSpace(gridtelefonosaconfigurar.Rows[i].Cells[3].Value.ToString()))
                {
                    String aliastlf = gridtelefonosaconfigurar.Rows[i].Cells[1].Value.ToString();
                    DialogResult result;
                    result = MessageBox.Show("Hay números de serie que no se han introducido. Revísalos e introdúcelos ahora, si no lo haces ahora no se actualizarán en la base de datos. ¿Quieres omitir los números de serie y continuar?", "Números de serie sin introducir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == System.Windows.Forms.DialogResult.No)
                    {
                        Conexion.Close();
                        return;
                    }
                    break;
                }
            }
            Conexion.Close();

            int totalfilas = gridtelefonosaconfigurar.Rows.Count - 1;

            progressBartotal.Maximum = totalfilas;
            progressBartotal.Value = 0;
            numerototal.Text = totalfilas.ToString();

            for (int i = 0; i < totalfilas; i++)
            {
                int numerotelefonoactual = progressBartotal.Value + 1;
                numeroactual.Text = numerotelefonoactual.ToString();
                String stringextensiontelefono = gridtelefonosaconfigurar.Rows[i].Cells[0].Value.ToString();
                int extensiontelefono = Int32.Parse(stringextensiontelefono);

                String aliastelefono = gridtelefonosaconfigurar.Rows[i].Cells[1].Value.ToString();
                String iptelefonoaconfigurar = gridtelefonosaconfigurar.Rows[i].Cells[2].Value.ToString();
                String nserie = gridtelefonosaconfigurar.Rows[i].Cells[3].Value.ToString();
                ipactualtelefono = gridtelefonosaconfigurar.Rows[i].Cells[4].Value.ToString();
                String ipcentralitatelefono = gridtelefonosaconfigurar.Rows[i].Cells[6].Value.ToString();
                String mascaraderedtelefono = gridtelefonosaconfigurar.Rows[i].Cells[7].Value.ToString();
                String puertadeenlacetelefono = gridtelefonosaconfigurar.Rows[i].Cells[8].Value.ToString();
                String modelotelefonoaconfigurar = gridtelefonosaconfigurar.Rows[i].Cells[9].Value.ToString();
                aliasprogreso.Text = aliastelefono;

                consultahistoricocambios(extensiontelefono.ToString(), aliastelefono, iptelefonoaconfigurar, nserie, modelotelefonoaconfigurar);




                    String solomodelo = gridtelefonosaconfigurar.Rows[i].Cells[9].Value.ToString();
                    string[] ultimocachomodelo = solomodelo.Split(' ');
                    Conexion.Open();
                    MySqlCommand idtelefono = new MySqlCommand("SELECT ID FROM telefonos WHERE NomNotaria ='" + gridtelefonosaconfigurar.Rows[i].Cells[5].Value + "' AND Extension ='" + gridtelefonosaconfigurar.Rows[i].Cells[0].Value + "'", Conexion);
                    int lastId = Convert.ToInt32(idtelefono.ExecuteScalar());
                    if (object.Equals(lastId, 0))
                    {
                        MySqlCommand registronuevotlf2 = new MySqlCommand("INSERT INTO telefonos (NomNotaria, Extension, Iptelefono, Alias, Modelo, Nserie) VALUES ('" + gridtelefonosaconfigurar.Rows[i].Cells[5].Value + "', '" + gridtelefonosaconfigurar.Rows[i].Cells[0].Value + "', '" + gridtelefonosaconfigurar.Rows[i].Cells[2].Value + "', '" + gridtelefonosaconfigurar.Rows[i].Cells[1].Value + "', ' Yealink SIP-" + ultimocachomodelo[1] + "', '" + gridtelefonosaconfigurar.Rows[i].Cells[3].Value + "')", Conexion);
                        registronuevotlf2.Connection = Conexion;
                        registronuevotlf2.ExecuteNonQuery();
                    }
                    else
                    {
                        MySqlCommand registronuevotlf2 = new MySqlCommand("INSERT INTO telefonos (ID, NomNotaria, Extension, Iptelefono, Alias, Modelo, Nserie) VALUES ('" + lastId + "', '" + gridtelefonosaconfigurar.Rows[i].Cells[5].Value + "', '" + gridtelefonosaconfigurar.Rows[i].Cells[0].Value + "', '" + gridtelefonosaconfigurar.Rows[i].Cells[2].Value + "', '" + gridtelefonosaconfigurar.Rows[i].Cells[1].Value + "', ' Yealink SIP-" + ultimocachomodelo[1] + "', '" + gridtelefonosaconfigurar.Rows[i].Cells[3].Value + "') ON DUPLICATE KEY UPDATE NomNotaria = '" + gridtelefonosaconfigurar.Rows[i].Cells[5].Value + "', Extension = '" + gridtelefonosaconfigurar.Rows[i].Cells[0].Value + "', Iptelefono = '" + gridtelefonosaconfigurar.Rows[i].Cells[2].Value + "', Alias = '" + gridtelefonosaconfigurar.Rows[i].Cells[1].Value + "', Modelo = ' Yealink SIP-" + ultimocachomodelo[1] + "', Nserie = '" + gridtelefonosaconfigurar.Rows[i].Cells[3].Value + "'", Conexion);
                        registronuevotlf2.Connection = Conexion;
                        registronuevotlf2.ExecuteNonQuery();
                    }
                    Conexion.Close();
                



                switch (modelotelefonoaconfigurar)
                {
                    case "YEALINK T27G":
                        if (checkmulticonfig.Checked == false)
                        {
                            await mensajerecordatorio();
                        }
                        await configurart27gAsync(ipactualtelefono, extensiontelefono, aliastelefono, ipcentralitatelefono, iptelefonoaconfigurar, mascaraderedtelefono, puertadeenlacetelefono);
                        break;

                    case "YEALINK T26P":
                        if (checkmulticonfig.Checked == false)
                        {
                            await mensajerecordatorio();
                        }
                        await configurart26pAsync(ipactualtelefono, extensiontelefono, aliastelefono, ipcentralitatelefono, iptelefonoaconfigurar, mascaraderedtelefono, puertadeenlacetelefono);
                        break;

                    case "YEALINK W52P":
                        if (checkmulticonfig.Checked == false)
                        {
                            await mensajerecordatorio();
                        }
                        await configurarw52pAsync(ipactualtelefono, extensiontelefono, aliastelefono, ipcentralitatelefono, iptelefonoaconfigurar, mascaraderedtelefono, puertadeenlacetelefono);
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

        public async Task configurart26pAsync(String ipactualtelefono, int extensiontelefono, String aliastelefono, String ipcentralitatelefono, String iptelefonoaconfigurar, String mascaraderedtelefono, String puertadeenlacetelefono)
        {
            TELEFONOS.YEALINKT26P T26P = new TELEFONOS.YEALINKT26P();

            progressBartlf.Maximum = 4;
            progressBartlf.Value = 0;
            textoproceso.Text = "GENERAL";
            await T26P.configuraciongeneralAsync(ipactualtelefono, extensiontelefono, aliastelefono, ipcentralitatelefono, webBrowser1);
            progressBartlf.Value += 1;
            textoproceso.Text = "EXTENSIONES";
            await T26P.limpiaryconfigurarextensiones(ipactualtelefono, webBrowser1, gridextensiones, gridtelefonosaconfigurar, extensiontelefono);
            progressBartlf.Value += 1;
            await T26P.configurarextensionestlfaconfigurar(ipactualtelefono, webBrowser1, gridextensiones, gridtelefonosaconfigurar, extensiontelefono);
            progressBartlf.Value += 1;
            textoproceso.Text = "RED";
            await T26P.configurarred(ipactualtelefono, webBrowser1, iptelefonoaconfigurar, mascaraderedtelefono, puertadeenlacetelefono);
            progressBartlf.Value += 1;
            textoproceso.Text = "TERMINADO";



        }

        public async Task configurarw52pAsync(String ipactualtelefono, int extensiontelefono, String aliastelefono, String ipcentralitatelefono, String iptelefonoaconfigurar, String mascaraderedtelefono, String puertadeenlacetelefono)
        {
            TELEFONOS.YEALINKW52P W52P = new TELEFONOS.YEALINKW52P();

            progressBartlf.Maximum = 2;
            progressBartlf.Value = 0;
            textoproceso.Text = "GENERAL";
            await W52P.configuraciongeneralAsync(ipactualtelefono, extensiontelefono, aliastelefono, ipcentralitatelefono, webBrowser1, gridextensiones);
            progressBartlf.Value += 1;
            textoproceso.Text = "RED";
            await W52P.configurarred(ipactualtelefono, webBrowser1, iptelefonoaconfigurar, mascaraderedtelefono, puertadeenlacetelefono);
            progressBartlf.Value += 1;
            textoproceso.Text = "TERMINADO";

        }



            private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/1WUBY5rI54wvNLcoWWIgv9h5PRXuQsEzA/view?usp=sharing");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            String extensiontelefono = gridextensiones.CurrentRow.Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show("¿El teléfono que vas a configurar es en sustitución del teléfono con extensión: " + extensiontelefono + " ?", "Sustituir teléfono", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                
                String iptelefono = gridextensiones.CurrentRow.Cells[1].Value.ToString();
                String aliastelefono = gridextensiones.CurrentRow.Cells[2].Value.ToString();
                String ipactualtelefono = ipactualinput.Text.ToString();
                String nombrenotaria = gridextensiones.CurrentRow.Cells[5].Value.ToString();
                String ipcentralita = ipcentralitanotaria.Text.ToString();
                String mascaradered = mascararednotaria.Text.ToString();
                String puertaenlace = puertaenlacenotaria.Text.ToString();
                String modelotlf = listamodelo.SelectedItem.ToString().Trim(' ');
                String nserietexto = gridextensiones.CurrentRow.Cells[3].Value.ToString();

                gridextensiones.Rows.RemoveAt(gridextensiones.CurrentRow.Index);

                string[] row1 = new string[] {extensiontelefono, aliastelefono, iptelefono, nserietexto, ipactualtelefono, nombrenotaria, ipcentralita, mascaradered, puertaenlace, modelotlf };
                gridtelefonosaconfigurar.Rows.Add(row1);


            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f2 = new Herramientas();
            f2.StartPosition = FormStartPosition.Manual;
            f2.Location = new Point(this.Location.X + (this.Width - f2.Width) / 2, this.Location.Y + (this.Height - f2.Height) / 2);
            f2.Show(this);


        }

        private void gridtelefonosaconfigurar_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if(gridtelefonosaconfigurar.Rows.Count > 0)
            {
                btnconfigurar.Enabled = true;
            }
        }

        public void consultahistoricocambios(String extensiontelefono, String AliasInstalado, String IpInstalado, String NserieInstalado, String ModeloInstalado)
        {
            Conexion.Open();
            MySqlCommand extractordatosantiguos = new MySqlCommand("SELECT Alias, Iptelefono, Modelo, Nserie FROM telefonos WHERE NomNotaria ='" + buscadornotaria.Text.ToString() + "' AND Extension =" + extensiontelefono, Conexion);
            MySqlDataAdapter da = new MySqlDataAdapter(extractordatosantiguos);
            da.Fill(dt);
            int numerofilas = dt.Rows.Count;
            if (numerofilas == 0)
            {
                aliasviejo = "";
                iptelefonovieja = "";
                modeloviejo = "";
                nserieviejo = "";
            } else
            {
                aliasviejo = dt.Rows[0]["Alias"].ToString();
                iptelefonovieja = dt.Rows[0]["Iptelefono"].ToString();
                modeloviejo = dt.Rows[0]["Modelo"].ToString();
                nserieviejo = dt.Rows[0]["Nserie"].ToString();
            }
            dt.Clear();
            DateTime fechaactual = DateTime.Today;
            string[] fechaseparadadehora = fechaactual.ToString().Split(' ');
            String fecha = fechaseparadadehora[0];

            var horaactual = DateTime.Now.ToString("hh:mm:ss");

            MySqlCommand registronuevotlf = new MySqlCommand("INSERT INTO histcambios (Notaria, Fecha, Hora, Extension, AliasInstalado, IPInstalado, NserieInstalado, ModeloInstalado, AliasRetirado, IPRetirado, NserieRetirado, ModeloRetirado) VALUES ('" + buscadornotaria.Text.ToString() + "', '" + fecha + "', '" + horaactual + "', '" + extensiontelefono + "', '" + AliasInstalado + "', '" + IpInstalado + "', '" + NserieInstalado + "', ' Yealink SIP-" + ModeloInstalado + "', '" + aliasviejo + "', '" + iptelefonovieja + "', '" + nserieviejo + "', '" + modeloviejo + "')", Conexion);
            registronuevotlf.Connection = Conexion;
            registronuevotlf.ExecuteNonQuery();
            Conexion.Close();
        }

        private async Task btnputty_ClickAsync()
        {
            webBrowser1.Navigate("https://ssl.voztele.com/areadeclientes_nae/jsp/distri/oigaaUserManagement.jsp");

            await cargapagina();

            webBrowser1.Document.GetElementById("j_username").SetAttribute("value", "integrador@notin.net");
            webBrowser1.Document.GetElementById("j_password").SetAttribute("value", "voztelenotin");

            foreach (HtmlElement btn in webBrowser1.Document.GetElementsByTagName("td"))
            {
                if (btn.GetAttribute("className") == "submitBtn")
                {
                    btn.InvokeMember("Click");
                    break;
                }
            }

            await cargapagina();

            webBrowser1.Document.GetElementById("j_username").SetAttribute("value", "integrador@notin.net");
            webBrowser1.Document.GetElementById("j_password").SetAttribute("value", "voztelenotin");

            foreach (HtmlElement btn in webBrowser1.Document.GetElementsByTagName("td"))
            {
                if (btn.GetAttribute("className") == "submitBtn")
                {
                    btn.InvokeMember("Click");
                    break;
                }
            }

            await cargapagina();

            webBrowser1.Navigate("https://ssl.voztele.com/areadeclientes_nae/jsp/distri/oigaaUserManagement.jsp");

            await cargapagina();

            string downloadString = webBrowser1.DocumentText;
            int separatorIndex = downloadString.IndexOf(buscadornotaria.Text.ToString());
            if (separatorIndex >= 0)
            {
                string notariaencontrada = downloadString.Substring(separatorIndex + buscadornotaria.Text.ToString().Length);
                int separatorIndex2 = downloadString.IndexOf("ssl");
                string enlacecasiencontrado = notariaencontrada.Substring(separatorIndex2 + "ssl".Length);
                string[] enlacepulido = enlacecasiencontrado.Split('<');
                string[] enlacefinal = enlacepulido[5].Split('"');
                webBrowser1.Navigate(enlacefinal[1]);


                MessageBox.Show(enlacefinal[1]);
            } else
            {
                MessageBox.Show("Notaría no encontrada, revisa que el nombre sea igual que en la página de ssl.voztelecom.com");
            }
        }

        async Task cargapagina()
        {
            await Task.Delay(2000);
        }

        async Task cargagrande()
        {
            await Task.Delay(5000);
        }

        private void btnputty_Click(object sender, EventArgs e)
        {
            btnputty_ClickAsync();
        }
    }
}
