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
    public partial class Agregartlfichanotaria : Form
    {
        public Agregartlfichanotaria()
        {
            InitializeComponent();

            listamodelo.Items.Add("YEALINK T27G");
            listamodelo.Items.Add("YEALINK T26P");
            listamodelo.Items.Add("YEALINK W52P");
            listamodelo.SelectedIndex = 0;
        }

        private void btnGuardarcambios_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Estás seguro de que quieres añadir este teléfono en la base datos?", "Añadir teléfono en la base de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string MyConnection2 = "server=datostelefonos.ddnsfree.com; database=datostelefonos; Uid=jlozano ; pwd=raper0_legendari0; port=36970";
                    MySql.Data.MySqlClient.MySqlConnection MyConn2 = new MySql.Data.MySqlClient.MySqlConnection(MyConnection2);
                    MySql.Data.MySqlClient.MySqlCommand MyCommand2 = new MySql.Data.MySqlClient.MySqlCommand("INSERT INTO telefonos(NomNotaria, Extension, Iptelefono, Alias, Modelo, Nserie, UltActualiz) VALUES(" +  ", '$extension1', '$ip1', '$alias1', '$modelo1', '$fechaactualizacion')", MyConn2);
                    MySql.Data.MySqlClient.MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Teléfono añadido correctamente", "Éxito");
                    while (MyReader2.Read()) { }
                    MyConn2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
