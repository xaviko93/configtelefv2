using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace configurador_tlf_V2
{
    public partial class Actualizardatos : Form
    {



        public Actualizardatos()
        {
            InitializeComponent();

            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textopuerto.Text = "6598";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Probando conexion
                int puerto = Int32.Parse(textopuerto.Text.ToString());
                string conip = "178.23.210.121";
                string conus = "root";
                string concontra = "4a9P1dK9xrn1l";



            using (var client = new SshClient(conip, puerto, conus, concontra))
                {

                //Start the connection
                int attempts = 0;
                do
                {
                    try
                    {
                        client.Connect();
                    }
                    catch
                    {
                        attempts++;
                    }
                } while (attempts < 5 && !client.IsConnected);
                var output = client.RunCommand("echo test");
                    client.Disconnect();
                    Console.WriteLine(output.ToString());
                    MessageBox.Show("Conectado correctamente");
                }
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //Realizando comandos
            try
            {

                using (var client = new SshClient(textoip.Text.ToString(), Int32.Parse(textopuerto.Text.ToString()), usuario.Text.ToString(), contra.Text.ToString()))
                {
                    client.Connect();
                    client.RunCommand("sudo rm scriptinstalacion.sh");
                    client.RunCommand("sudo rm -rf /datostelefonos");
                    client.RunCommand("sudo mkdir /datostelefonos");
                    client.RunCommand("wget -c wget --user=jlozano --password=raper0_legendari0 'ftp://telefonos.notin.net/Scripts2020/scriptinstalacion.sh'");
                    client.RunCommand("sudo chmod 777 scriptinstalacion.sh");
                    client.RunCommand("sudo apt-get install dos2unix -y");
                    client.RunCommand("dos2unix scriptinstalacion.sh");
                    client.RunCommand("./scriptinstalacion.sh '" + nombrenotaria.Text.ToString() + "'");
                    client.Disconnect();
                    MessageBox.Show("Datos actualizados correctamente");

                }
            }
            catch
            {
                MessageBox.Show("No se puede conectar a la centralita por SSH");
            }
        }

        private void Actualizardatos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void Actualizardatos_VisibleChanged(object sender, EventArgs e)
        {
            if (nombrenotaria.Text == "" && Form1.VariablesGlobales.nombrenotariaseleccionadapublica != null)
            {
                nombrenotaria.Text = Form1.VariablesGlobales.nombrenotariaseleccionadapublica;
            }
        }
    }
}
