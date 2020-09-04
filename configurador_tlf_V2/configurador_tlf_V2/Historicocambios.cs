using MySql.Data.MySqlClient;
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
    public partial class Historicocambios : Form
    {
        public Historicocambios()
        {
            InitializeComponent();

            MySqlCommand cmd = new MySqlCommand("SELECT NomNotaria, IPCentralita, MascaraRed, PuertaEnlace FROM centralita", Conexion);
            MySqlDataAdapter m_datos2 = new MySqlDataAdapter(cmd);
            ds2 = new DataSet();
            m_datos2.Fill(ds2);
            gridhistorico.DataSource = ds2.Tables[0];
            Conexion.Close();
        }

        MySqlConnection Conexion = new MySqlConnection("server=datostelefonos.ddnsfree.com; database=datostelefonos; Uid=jlozano ; pwd=raper0_legendari0; port=36970");
        DataSet ds2;
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f2 = new Buscadornotariahistorico();
            f2.StartPosition = FormStartPosition.Manual;
            f2.Location = new Point(this.Location.X + (this.Width - f2.Width) / 2, this.Location.Y + (this.Height - f2.Height) / 2);
            f2.Show(this);
        }
    }
}
