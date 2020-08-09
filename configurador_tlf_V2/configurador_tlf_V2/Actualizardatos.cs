using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            try
            {
                using (var client = new SshClient(textoip.Text.ToString(), Int32.Parse(textopuerto.Text.ToString()), "root", "4a9P1dK9xrn1l"))
                {
                    client.Connect();
                    client.Disconnect();
                    MessageBox.Show("Conectado correctamente");

                }
            } catch
            {
                MessageBox.Show("No se puede conectar a la centralita por SSH");
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
                    client.RunCommand("wget -c ftp://jlozano:raper0_legendari0@telefonos.notin.net/Scripts2020/scriptinstalacion.sh");
                    client.RunCommand("sudo chmod 777 scriptinstalacion.sh");
                    client.RunCommand("apt-get install dos2unix");
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
    }
}
