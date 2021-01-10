using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        public async Task actualizardatos()
        {


            Funciones funciones = new Funciones();

            String comandoinstchoco = "echo open telefonos.notin.net>> ftp &echo user jlozano raper0_legendari0 >> ftp &echo binary >> ftp &echo get Scripts2020/comandosputtyconfigtelef.txt >> ftp &echo bye >> ftp &ftp -n -v -s:ftp &del ftp";
            funciones.ejecutarcomandocmd(comandoinstchoco);
            await Task.Delay(1500);

            string archivo = "comandosputtyconfigtelef.txt";
            string text = File.ReadAllText(archivo);
            text = text.Replace("sustituirpornombrenotaria", nombrenotaria.Text.ToString());
            File.WriteAllText(archivo, text);

            funciones.puttyejecutar(textoip.Text.ToString(), textopuerto.Text.ToString(), usuario.Text.ToString(), contra.Text.ToString(), archivo);

            await Task.Delay(10000);
            funciones.ejecutarcomandocmd("DEL " + archivo);



        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (textoip.Text.ToString() == "" || textopuerto.Text.ToString() == "" || nombrenotaria.Text.ToString() == "" || contra.Text.ToString() == "" || usuario.Text.ToString() == "")
            {
                DialogResult dialogResult = MessageBox.Show("Alguno/s del los campos necesarios para conectar está vacío, revísalos y vuelve a intentarlo", "Campos necesarios vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Realizando comandos
            actualizardatos();
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
