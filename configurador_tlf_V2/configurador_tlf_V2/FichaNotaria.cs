using MySql.Data.MySqlClient;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace configurador_tlf_V2
{
    public partial class FichaNotaria : Form
    {

        String nombrenotariaanterior;
        String ippublicaanterior;
        String puertoanterior;
        String ipcentralitaanterior;
        String mascaraanterior;
        String puertaanterior;
        String valorceldanterior;
        public FichaNotaria()
        {
            InitializeComponent();
        }

        //ABRE EL BUSCADOR DE NOTARIAS
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Buscadornotariaficha();
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(this.Location.X + (this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);
            frm.Show(this);
        }

        MySql.Data.MySqlClient.MySqlConnection Conexion = new MySql.Data.MySqlClient.MySqlConnection("server=datostelefonos.ddnsfree.com; database=datostelefonos; Uid=jlozano ; pwd=raper0_legendari0; port=36970");
        DataSet ds2;

        //CARGA LAS EXTENSIONES Y LOS DATOS DE LA NOTARIA CUANDO LA SELECCIONAS
        public void cargarextensiones()
        {
            guardardatosiniciales();
            Conexion.Open();

            try
            {
                gridextensiones.Columns.Clear();
            }
            catch { }
            Form1.VariablesGlobales.nombrenotariaseleccionadapublica = nombrenotaria.Text.ToString();
            MySql.Data.MySqlClient.MySqlCommand mostrar2 = new MySql.Data.MySqlClient.MySqlCommand("SELECT ID, Extension, Iptelefono, Alias, Nserie, Modelo, UltActualiz FROM telefonos WHERE NomNotaria ='" + nombrenotaria.Text.ToString() + "' ORDER BY Extension", Conexion);
            MySql.Data.MySqlClient.MySqlDataAdapter m_datos2 = new MySql.Data.MySqlClient.MySqlDataAdapter(mostrar2);
            ds2 = new DataSet();
            m_datos2.Fill(ds2);

            gridextensiones.DataSource = ds2.Tables[0];
            Conexion.Close();
        }

        //GUARDA LOS DATOS CARGADOS EN STRINGS PARA COMPARARLOS POSTERIORMENTE
        public void guardardatosiniciales()
        {
            nombrenotariaanterior = nombrenotaria.Text;
            ippublicaanterior = ippublicatexto.Text;
            puertoanterior = puertotexto.Text;
            ipcentralitaanterior = ipcentralitainput.Text;
            mascaraanterior = mascararedinput.Text;
            puertaanterior = puertadeenlaceinput.Text;
        }

        //COMPARA LOS CAMBIOS REALIZADS EN LOS DATOS ANTERIORMENTE CARGADOS Y PREGUNTA SI DESEAS ESTAS SEGURO DE REALIZAR LOS CAMBIOS

        private void btnGuardarcambios_Click(object sender, EventArgs e)
        {
            compararcambios();
        }
        public void compararcambios()
        {
            String consultasql = "";
            String mensajecambios = "";
            int nombrediferente = 0;
            int ippublicadiferente = 0;
            int puertodiferente = 0;
            int ipcentralitadiferente = 0;
            int mascaradiferente = 0;
            int puertadiferente = 0;

            if (nombrenotariaanterior != nombrenotaria.Text)
            {
                nombrediferente = 1;
                mensajecambios = mensajecambios + "Nombre notaría = " + nombrenotaria.Text + "\n";
                consultasql = consultasql + "UPDATE centralita SET NomNotaria = '" + nombrenotaria.Text + "' WHERE NomNotaria = '" + nombrenotariaanterior + "'; UPDATE telefonos SET NomNotaria = '" + nombrenotaria.Text + "' WHERE NomNotaria = '" + nombrenotariaanterior + "'; UPDATE histcambios SET Notaria = '" + nombrenotaria.Text + "' WHERE Notaria = '" + nombrenotariaanterior + "'; ";
            }

            if (ippublicaanterior != ippublicatexto.Text)
            {
                ippublicadiferente = 1;
                mensajecambios = mensajecambios + "Ip Pública = " + ippublicatexto.Text + "\n";
            }

            if (puertoanterior != puertotexto.Text)
            {
                puertodiferente = 1;
                mensajecambios = mensajecambios + "Puerto = " + puertotexto.Text + "\n";
            }

            if (ipcentralitaanterior != ipcentralitainput.Text)
            {
                ipcentralitadiferente = 1;
                mensajecambios = mensajecambios + "Ip Centralita = " + ipcentralitainput.Text + "\n";
                consultasql = consultasql + "UPDATE centralita SET IPCentralita = '" + ipcentralitainput.Text + "' WHERE NomNotaria = '" + nombrenotaria.Text + "'; ";
            }

            if (mascaraanterior != mascararedinput.Text)
            {
                mascaradiferente = 1;
                mensajecambios = mensajecambios + "Máscara de red = " + mascararedinput.Text + "\n";
                consultasql = consultasql + "UPDATE centralita SET MascaraRed = '" + mascararedinput.Text + "' WHERE NomNotaria = '" + nombrenotaria.Text + "'; ";
            }

            if (puertaanterior != puertadeenlaceinput.Text)
            {
                puertadiferente = 1;
                mensajecambios = mensajecambios + "Puerta de enlace = " + puertadeenlaceinput.Text + "\n";
                consultasql = consultasql + "UPDATE centralita SET PuertaEnlace = '" + puertadeenlaceinput.Text + "' WHERE NomNotaria = '" + nombrenotaria.Text + "'; ";
            }

            if (mensajecambios != "")
            {

                DialogResult dialogResult = MessageBox.Show("¿Quieres actualizar los campos editados en la base datos? Los campos editados son:\n\n" + mensajecambios, "Realizar cambios en la base de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        string MyConnection2 = "server=datostelefonos.ddnsfree.com; database=datostelefonos; Uid=jlozano ; pwd=raper0_legendari0; port=36970";
                        MySql.Data.MySqlClient.MySqlConnection MyConn2 = new MySql.Data.MySqlClient.MySqlConnection(MyConnection2);
                        MySql.Data.MySqlClient.MySqlCommand MyCommand2 = new MySql.Data.MySqlClient.MySqlCommand(consultasql, MyConn2);
                        MySql.Data.MySqlClient.MySqlDataReader MyReader2;
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();
                        MessageBox.Show("Campos actualizados", "Éxito");
                        while (MyReader2.Read()) { }
                        MyConn2.Close();
                        guardardatosiniciales();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        //ABRE EL FORMULARIO ANTERIOR SI ESTE SE CIERRA
        private void FichaNotaria_FormClosing(object sender, FormClosingEventArgs e)
        {
            Herramientas pantallaprincipal2 = Owner as Herramientas;
            pantallaprincipal2.Show();
        }

        //COMPRUEBA SI ESTÁ PUTTY INSTALADO Y LO ABRE CON LA IP PUBLICA DE LA FICHA
        private void Putty_Click(object sender, EventArgs e)
        {
            puttyejecutar();
        }

        private async Task puttyejecutar()
        {
            if (File.Exists("C:\\Program Files\\PuTTY\\putty.exe"))
            {
                String comando = "C:\\\"Program Files\"\\PuTTY\\putty.exe -ssh " + usuarioputty.Text.ToString() + "@" + ippublicatexto.Text.ToString() + " " + puertotexto.Text.ToString() + " -pw " + contraputty.Text.ToString();
                ejecutarcomandocmd(comando);
            }
            else
            {
                String comandoinstchoco = "echo open telefonos.notin.net>> ftp &echo user jlozano raper0_legendari0 >> ftp &echo binary >> ftp &echo get PROGRAMAS/putty.msi >> ftp &echo bye >> ftp &ftp -n -v -s:ftp &del ftp";
                ejecutarcomandocmd(comandoinstchoco);
                await Task.Delay(6000);
                ejecutarcomandocmd("start putty.msi /passive");
                await Task.Delay(5000);
                ejecutarcomandocmd("DEL /F /A putty.msi");
                String comando = "C:\\\"Program Files\"\\PuTTY\\putty.exe -ssh " + usuarioputty.Text.ToString() + "@" + ippublicatexto.Text.ToString() + " " + puertotexto.Text.ToString() + " -pw " + contraputty.Text.ToString();
                ejecutarcomandocmd(comando);
            }
        }

        //FUNCION PARA EJECUTAR COMANDOS CMD
        public void ejecutarcomandocmd(String comandoimportado)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = false;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine(comandoimportado);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
            Console.Read();
        }

        //COMPRUEBA SI WINSCP ESTÁ INSTALADO Y LO ABRE CON ESA CONFIGURACION
        private void winscp_Click(object sender, EventArgs e)
        {
            winscpejecutar();
        }



        private async Task winscpejecutar()
        {
            if (File.Exists("C:\\Program Files (x86)\\WinSCP\\WinSCP.exe"))
            {
                String comando = "C:\\\"Program Files\"\\PuTTY\\putty.exe -ssh " + usuarioputty.Text.ToString() + "@" + ippublicatexto.Text.ToString() + " " + puertotexto.Text.ToString() + " -pw " + contraputty.Text.ToString();
                ejecutarcomandocmd(comando);
            }
            else
            {
                String comandoinstchoco = "echo open telefonos.notin.net>> ftp &echo user jlozano raper0_legendari0 >> ftp &echo binary >> ftp &echo get PROGRAMAS/winscp.exe >> ftp &echo bye >> ftp &ftp -n -v -s:ftp &del ftp";
                ejecutarcomandocmd(comandoinstchoco);
                await Task.Delay(6000);
                ejecutarcomandocmd("start winscp.exe /allusers /silent");
                await Task.Delay(5000);
                ejecutarcomandocmd("DEL /F /A winscp.exe");
                String comando = "C:\\\"Program Files\"\\PuTTY\\putty.exe -ssh " + usuarioputty.Text.ToString() + "@" + ippublicatexto.Text.ToString() + " " + puertotexto.Text.ToString() + " -pw " + contraputty.Text.ToString();
                ejecutarcomandocmd(comando);
            }
        }

        //COMPRUEBA SI SE HA SELECCIONADO LA NOTARIA EN OTRA PARTE DE LA APLICACION PARA CARGARLA AL ABRIR EL FORMULARIO SI NO SE HA SELECCIONADO ANTES OTRA EN ESTE FORM
        private void FichaNotaria_VisibleChanged(object sender, EventArgs e)
        {
            if (Form1.VariablesGlobales.nombrenotariaseleccionadapublica != null && nombrenotaria.Text == "Ninguna")
            {
                nombrenotaria.Text = Form1.VariablesGlobales.nombrenotariaseleccionadapublica.ToString();
                cargarextensiones();
            }
        }



        private void btnnuevoext_Click(object sender, EventArgs e)
        {
            //CALCULA LA EXTENSIÓN DISPONIBLE PARA SUGERIRLA
            int extensionocupada;
            String extensionausar = "";
            String ipausar = "";
            int contador = 0;
            int numerototalext = gridextensiones.Rows.Count;
            if (nombrenotariaanterior == null)
            {
                DialogResult dialogResult = MessageBox.Show("Ninguna Notaría seleccionada. Selecciona una antes de añadir un teléfono.", "Selecciona Notaría", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numerototalext > 1)
            {
                try
                {
                    String extensionstringprimero = gridextensiones.Rows[0].Cells[1].Value.ToString();
                    int extensionprimera = Int32.Parse(extensionstringprimero);

                    for (int i = 1; i <= numerototalext; i++)
                    {
                        contador = i - 1;
                        String extensionstring = gridextensiones.Rows[contador].Cells[1].Value.ToString();
                        extensionocupada = Int32.Parse(extensionstring);

                        if (extensionprimera == extensionocupada)
                        {
                            extensionprimera++;
                        }
                        else
                        {
                            extensionausar = extensionprimera.ToString();
                            break;
                        }
                        if (i == numerototalext - 1)
                        {
                            extensionausar = extensionprimera.ToString();
                            break;
                        }
                    }

                    //CALCULA LA IP DISPONIBLE PARA SUGERIRLA
                    String ipsiguientexto = gridextensiones.Rows[contador - 1].Cells[2].Value.ToString();
                    string[] ultimocachoipsiguiente = ipsiguientexto.Split('.');
                    int ipsiguiente = Int32.Parse(ultimocachoipsiguiente[3]);
                    String ipsiguientefilatexto = gridextensiones.Rows[contador].Cells[2].Value.ToString();
                    string[] ultimocachoipsiguientefila = ipsiguientefilatexto.Split('.');
                    int ipsiguientefila = Int32.Parse(ultimocachoipsiguientefila[3]);
                    ipsiguiente++;

                    if (ipsiguiente != ipsiguientefila)
                    {
                        ipausar = ultimocachoipsiguiente[0] + "." + ultimocachoipsiguiente[1] + "." + ultimocachoipsiguiente[2] + "." + ipsiguiente.ToString();
                    }
                    else
                    {
                        String ipprimeraocupada = gridextensiones.Rows[0].Cells[2].Value.ToString();
                        string[] ultimocachoip = ipprimeraocupada.Split('.');
                        int ultimocachonumero = Int32.Parse(ultimocachoip[3]);

                        for (int i = 1; i <= numerototalext; i++)
                        {
                            contador = i - 1;
                            String ipstring = gridextensiones.Rows[contador].Cells[2].Value.ToString();
                            string[] ultimocachoipocupada = ipstring.Split('.');
                            int ipocupada = Int32.Parse(ultimocachoipocupada[3]);

                            if (ultimocachonumero == ipocupada)
                            {
                                ultimocachonumero++;
                            }
                            else
                            {
                                ipausar = ultimocachoip[0] + "." + ultimocachoip[1] + "." + ultimocachoip[2] + "." + ultimocachonumero.ToString();
                                break;
                            }
                            if (i == numerototalext - 1)
                            {
                                ipausar = ultimocachoip[0] + "." + ultimocachoip[1] + "." + ultimocachoip[2] + "." + ultimocachonumero.ToString();
                                break;
                            }
                        }
                    }

                }
                catch (System.ArgumentOutOfRangeException) { }
            }

            //CREA EL FORMULARIO F2 RELLENANDO SUS DATOS
            Agregartlfichanotaria f2 = new Agregartlfichanotaria();
            f2.textoextension.Text = extensionausar.ToString();
            f2.textoalias.Text = extensionausar.ToString();
            f2.textoip.Text = ipausar.ToString();
            f2.textonotaria.Text = nombrenotariaanterior.ToString();
            f2.StartPosition = FormStartPosition.Manual;
            f2.Location = new Point(this.Location.X + (this.Width - f2.Width) / 2, this.Location.Y + (this.Height - f2.Height) / 2);
            f2.Show(this);
        }

        //ELIMINA EL TELEFONO SELECCIONADO EN EL DATAGRID DE LA BASE DE DATOS
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("¿Seguro que quieres eliminar el teléfono con extensión " + gridextensiones.CurrentRow.Cells[1].Value + " de la base de datos?", "Eliminar teléfono", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string MyConnection2 = "server=datostelefonos.ddnsfree.com; database=datostelefonos; Uid=jlozano ; pwd=raper0_legendari0; port=36970";
                MySql.Data.MySqlClient.MySqlConnection MyConn2 = new MySql.Data.MySqlClient.MySqlConnection(MyConnection2);
                MySql.Data.MySqlClient.MySqlCommand MyCommand2 = new MySql.Data.MySqlClient.MySqlCommand("DELETE FROM telefonos WHERE NomNotaria = '" + nombrenotariaanterior.ToString() + "' AND Extension = '" + gridextensiones.CurrentRow.Cells[1].Value + "'", MyConn2);
                MySql.Data.MySqlClient.MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Teléfono eliminado correctamente", "Éxito");
                while (MyReader2.Read()) { }
                MyConn2.Close();
                cargarextensiones();

            }
        }

        //DETECTA QUE EL VALOR DE UNA CELDA HA CAMBIADO Y PREGUNTA SI QUIERES HACER ESE CAMBIO EN LA SQL

        private void gridextensiones_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            String mensaje = "";
            String consultamysql = "";
            int numcolumnaeditada = gridextensiones.CurrentCell.ColumnIndex;
            String nombrecolumna = gridextensiones.Columns[numcolumnaeditada].HeaderText;
            String valornuevo = gridextensiones.CurrentCell.Value.ToString();
            switch (nombrecolumna)
            {
                case "Extension":
                    mensaje = valorceldanterior + " de la base de datos?:" + Environment.NewLine + Environment.NewLine + "Antigua extensión = " + valorceldanterior + Environment.NewLine + "Nueva extensión = " + valornuevo;
                    consultamysql = "UPDATE telefonos SET Extension = '" + valornuevo + "' WHERE ID = '" + gridextensiones.CurrentRow.Cells[0].Value + "'";
                    break;

                case "Iptelefono":
                    mensaje = gridextensiones.CurrentRow.Cells[1].Value + " de la base de datos?:" + Environment.NewLine + Environment.NewLine + "Antigua IP = " + valorceldanterior + Environment.NewLine + "Nueva IP = " + valornuevo;
                    consultamysql = "UPDATE telefonos SET Iptelefono = '" + valornuevo + "' WHERE ID = '" + gridextensiones.CurrentRow.Cells[0].Value + "'";
                    break;

                case "Alias":
                    mensaje = gridextensiones.CurrentRow.Cells[1].Value + " de la base de datos?:" + Environment.NewLine + Environment.NewLine + "Antiguo Alias = " + valorceldanterior + Environment.NewLine + "Nuevo Alias = " + valornuevo;
                    consultamysql = "UPDATE telefonos SET Alias = '" + valornuevo + "' WHERE ID = '" + gridextensiones.CurrentRow.Cells[0].Value + "'";
                    break;
                case "Modelo":
                    mensaje = gridextensiones.CurrentRow.Cells[1].Value + " de la base de datos?:" + Environment.NewLine + Environment.NewLine + "Antiguo Modelo = " + valorceldanterior + Environment.NewLine + "Nuevo Modelo = " + valornuevo;
                    consultamysql = "UPDATE telefonos SET Modelo = '" + valornuevo + "' WHERE ID = '" + gridextensiones.CurrentRow.Cells[0].Value + "'";
                    break;
                case "Nserie":
                    mensaje = gridextensiones.CurrentRow.Cells[1].Value + " de la base de datos?:" + Environment.NewLine + Environment.NewLine + "Antiguo número de serie = " + valorceldanterior + Environment.NewLine + "Nuevo número de serie = " + valornuevo;
                    consultamysql = "UPDATE telefonos SET Nserie = '" + valornuevo + "' WHERE ID = '" + gridextensiones.CurrentRow.Cells[0].Value + "'";
                    break;
                case "UltActualiz":
                    mensaje = gridextensiones.CurrentRow.Cells[1].Value + " de la base de datos?:" + Environment.NewLine + Environment.NewLine + "Antigua última actualización = " + valorceldanterior + Environment.NewLine + "Nueva última actualización = " + valornuevo;
                    consultamysql = "UPDATE telefonos SET UltActualiz = '" + valornuevo + "' WHERE ID = '" + gridextensiones.CurrentRow.Cells[0].Value + "'";
                    break;
            }


            DialogResult result = MessageBox.Show("¿Seguro que quieres editar la siguiente información del teléfono con extensión " + mensaje, "Editar datos teléfono", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                valorceldanterior = valornuevo;

                try
                {
                    string MyConnection2 = "server=datostelefonos.ddnsfree.com; database=datostelefonos; Uid=jlozano ; pwd=raper0_legendari0; port=36970";
                    MySql.Data.MySqlClient.MySqlConnection MyConn2 = new MySql.Data.MySqlClient.MySqlConnection(MyConnection2);
                    MySql.Data.MySqlClient.MySqlCommand MyCommand2 = new MySql.Data.MySqlClient.MySqlCommand(consultamysql, MyConn2);
                    MySql.Data.MySqlClient.MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Campos actualizados", "Éxito");
                    while (MyReader2.Read()) { }
                    MyConn2.Close();
                    guardardatosiniciales();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        //CADA VEZ QUE SE SELECCIONA UNA CELDA DEL GRID CAPTURA EL VALOR Y LO GUARDA EN UNA VARIABLE
        private void gridextensiones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valorceldanterior = gridextensiones.CurrentCell.Value.ToString();
            }
            catch (NullReferenceException p)
            {
            }
        }
    }
}
