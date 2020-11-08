using MySql.Data.MySqlClient;
using MySqlConnector;
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
    }
}
