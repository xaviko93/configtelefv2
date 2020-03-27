using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace configurador_tlf_V2
{
    public partial class BuscarNotaria : Form
    {

        public String notariaabuscar2;
       
        public BuscarNotaria()
        {
            InitializeComponent();
        }

        MySqlConnection Conexion = new MySqlConnection("server=remotemysql.com; database=wWWHH1xcMX; Uid=wWWHH1xcMX; pwd=MmxyP2R8ey");

        private void btnBuscarNotaria_Click(object sender, EventArgs e)
        {
            notariaabuscar2 = buscadortextonotaria.Text.ToString();
            this.listabusquedanotarias.Items.Clear();

            MySqlCommand cmd = new MySqlCommand("SELECT Id ,NomNotaria, IPCentralita, MascaraRed, PuertaEnlace FROM centralita WHERE NomNotaria LIKE '%" + notariaabuscar2 + "%'", Conexion);
            MySqlDataReader dr;
            ListViewItem notarias = new ListViewItem();
            cmd.Connection.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                notarias = new ListViewItem(dr["Id"].ToString());
                notarias.SubItems.Add(dr["NomNotaria"].ToString());
                notarias.SubItems.Add(dr["IPCentralita"].ToString());
                notarias.SubItems.Add(dr["MascaraRed"].ToString());
                notarias.SubItems.Add(dr["PuertaEnlace"].ToString());
                listabusquedanotarias.Items.Add(notarias);
            }
            cmd.Connection.Close();

        }
    }
}
