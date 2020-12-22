using System;
using System.Windows.Forms;

namespace configurador_tlf_V2
{
    public partial class Agregartlfichanotaria : Form
    {
        public Agregartlfichanotaria()
        {
            InitializeComponent();

            listamodelo.Items.Add("Yealink SIP-T27G");
            listamodelo.Items.Add("Yealink SIP-T26P");
            listamodelo.Items.Add("Yealink SIP-W52P");
            listamodelo.SelectedIndex = 0;
        }

        private void btnGuardarcambios_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Estás seguro de que quieres añadir este teléfono en la base datos?", "Añadir teléfono en la base de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string fechaact = DateTime.Now.ToString("dd/MM/yy");

                    string MyConnection2 = "server=datostelefonos.ddnsfree.com; database=datostelefonos; Uid=jlozano ; pwd=raper0_legendari0; port=36970";
                    MySql.Data.MySqlClient.MySqlConnection MyConn2 = new MySql.Data.MySqlClient.MySqlConnection(MyConnection2);
                    MySql.Data.MySqlClient.MySqlCommand MyCommand2 = new MySql.Data.MySqlClient.MySqlCommand("INSERT INTO telefonos(NomNotaria, Extension, Iptelefono, Alias, Modelo, Nserie, UltActualiz) VALUES('" + textonotaria.Text.ToString() + "', '" + textoextension.Text.ToString() + "', '" + textoip.Text.ToString() + "', '" + textoalias.Text.ToString() + "', ' "+ listamodelo.SelectedItem.ToString() + "', '" + textonserie.Text.ToString() + "', '" + fechaact.ToString() + "')", MyConn2);
                    MySql.Data.MySqlClient.MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Teléfono añadido correctamente", "Éxito");
                    while (MyReader2.Read()) { }
                    MyConn2.Close();
                    FichaNotaria pantallaprincipal2 = Owner as FichaNotaria;
                    pantallaprincipal2.cargarextensiones();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
