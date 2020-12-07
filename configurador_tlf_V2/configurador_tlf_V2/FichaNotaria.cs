﻿using MySql.Data.MySqlClient;
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
        public FichaNotaria()
        {
            InitializeComponent();


        }

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
            MySql.Data.MySqlClient.MySqlCommand mostrar2 = new MySql.Data.MySqlClient.MySqlCommand("SELECT Extension, Iptelefono, Alias, Nserie, Modelo, NomNotaria, UltActualiz FROM telefonos WHERE NomNotaria ='" + nombrenotaria.Text.ToString() + "' ORDER BY Extension", Conexion);
            MySql.Data.MySqlClient.MySqlDataAdapter m_datos2 = new MySql.Data.MySqlClient.MySqlDataAdapter(mostrar2);
            ds2 = new DataSet();
            m_datos2.Fill(ds2);

            gridextensiones.DataSource = ds2.Tables[0];
            Conexion.Close();
        }

        public void guardardatosiniciales()
        {
            nombrenotariaanterior = nombrenotaria.Text;
            ippublicaanterior = ippublicatexto.Text;
            puertoanterior = puertotexto.Text;
            ipcentralitaanterior = ipcentralitainput.Text;
            mascaraanterior = mascararedinput.Text;
            puertaanterior = puertadeenlaceinput.Text;
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
                    while (MyReader2.Read()){}
                    MyConn2.Close();
                    guardardatosiniciales();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FichaNotaria_FormClosing(object sender, FormClosingEventArgs e)
        {
            Herramientas pantallaprincipal2 = Owner as Herramientas;
            pantallaprincipal2.Show();
        }

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
                await Task.Delay(2000);
                ejecutarcomandocmd("DEL /F /A putty.msi");
                String comando = "C:\\\"Program Files\"\\PuTTY\\putty.exe -ssh " + usuarioputty.Text.ToString() + "@" + ippublicatexto.Text.ToString() + " " + puertotexto.Text.ToString() + " -pw " + contraputty.Text.ToString();
                ejecutarcomandocmd(comando);
            }
        }

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
                await Task.Delay(2000);
                ejecutarcomandocmd("DEL /F /A winscp.exe");
                String comando = "C:\\\"Program Files\"\\PuTTY\\putty.exe -ssh " + usuarioputty.Text.ToString() + "@" + ippublicatexto.Text.ToString() + " " + puertotexto.Text.ToString() + " -pw " + contraputty.Text.ToString();
                ejecutarcomandocmd(comando);
            }
        }

        private void FichaNotaria_VisibleChanged(object sender, EventArgs e)
        {
            if (Form1.VariablesGlobales.nombrenotariaseleccionadapublica != null && nombrenotaria.Text == "Ninguna")
            {
                nombrenotaria.Text = Form1.VariablesGlobales.nombrenotariaseleccionadapublica.ToString();
                cargarextensiones();
            }
        }

        private void btnGuardarcambios_Click(object sender, EventArgs e)
        {
            compararcambios();
        }
    }
}
