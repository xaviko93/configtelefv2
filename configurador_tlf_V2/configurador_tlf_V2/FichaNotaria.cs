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
            Conexion.Open();

            try
            {
                gridextensiones.Columns.Clear();
            }
            catch { }


            MySql.Data.MySqlClient.MySqlCommand mostrar2 = new MySql.Data.MySqlClient.MySqlCommand("SELECT Extension, Iptelefono, Alias, Nserie, Modelo, NomNotaria, UltActualiz FROM telefonos WHERE NomNotaria ='" + nombrenotaria.Text.ToString() + "' ORDER BY Extension", Conexion);
            MySql.Data.MySqlClient.MySqlDataAdapter m_datos2 = new MySql.Data.MySqlClient.MySqlDataAdapter(mostrar2);
            ds2 = new DataSet();
            m_datos2.Fill(ds2);

            gridextensiones.DataSource = ds2.Tables[0];
            Conexion.Close();
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
    }
}
