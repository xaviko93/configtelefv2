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
    public partial class Buscadornotariahistorico : Form
    {
        public Buscadornotariahistorico()
        {
            InitializeComponent();

            MySqlCommand cmd = new MySqlCommand("SELECT NomNotaria, IPCentralita, MascaraRed, PuertaEnlace FROM centralita", Conexion);
            MySqlDataReader dr;
            ListViewItem notarias = new ListViewItem();
            cmd.Connection.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                notarias = new ListViewItem(dr["NomNotaria"].ToString());
                notarias.SubItems.Add(dr["IPCentralita"].ToString());
                notarias.SubItems.Add(dr["MascaraRed"].ToString());
                notarias.SubItems.Add(dr["PuertaEnlace"].ToString());
                listabusquedanotarias.Items.Add(notarias);
            }
            cmd.Connection.Close();
        }

        private void BtnBuscarNotaria_Click(object sender, EventArgs e)
        {
            String notariaabuscar2 = buscadortextonotaria.Text.ToString();
            this.listabusquedanotarias.Items.Clear();

            MySqlCommand cmd = new MySqlCommand("SELECT NomNotaria, IPCentralita, MascaraRed, PuertaEnlace FROM centralita WHERE NomNotaria LIKE '%" + notariaabuscar2 + "%'", Conexion);
            MySqlDataReader dr;
            ListViewItem notarias = new ListViewItem();
            cmd.Connection.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                notarias = new ListViewItem(dr["NomNotaria"].ToString());
                notarias.SubItems.Add(dr["IPCentralita"].ToString());
                notarias.SubItems.Add(dr["MascaraRed"].ToString());
                notarias.SubItems.Add(dr["PuertaEnlace"].ToString());
                listabusquedanotarias.Items.Add(notarias);
            }
            cmd.Connection.Close();
        }

        MySqlConnection Conexion = new MySqlConnection("server=datostelefonos.ddnsfree.com; database=datostelefonos; Uid=jlozano ; pwd=raper0_legendari0; port=36970");

        private void BtnSeleccionarNotaria_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 pantallaprincipal = Owner as Form1;
                pantallaprincipal.buscadornotaria.Text = listabusquedanotarias.SelectedItems[0].SubItems[0].Text;
                pantallaprincipal.ipcentralitanotaria.Text = listabusquedanotarias.SelectedItems[0].SubItems[1].Text;
                pantallaprincipal.mascararednotaria.Text = listabusquedanotarias.SelectedItems[0].SubItems[2].Text;
                pantallaprincipal.puertaenlacenotaria.Text = listabusquedanotarias.SelectedItems[0].SubItems[3].Text;
                pantallaprincipal.cargarextensiones();
                this.Close();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("No has seleccionado ninguna Notaría", "Advertencia");
                this.Close();
            }
        }

        private void Listabusquedanotarias_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Form1 pantallaprincipal = Owner as Form1;
                pantallaprincipal.buscadornotaria.Text = listabusquedanotarias.SelectedItems[0].SubItems[0].Text;
                pantallaprincipal.ipcentralitanotaria.Text = listabusquedanotarias.SelectedItems[0].SubItems[1].Text;
                pantallaprincipal.mascararednotaria.Text = listabusquedanotarias.SelectedItems[0].SubItems[2].Text;
                pantallaprincipal.puertaenlacenotaria.Text = listabusquedanotarias.SelectedItems[0].SubItems[3].Text;
                pantallaprincipal.cargarextensiones();
                this.Close();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("No has seleccionado ninguna Notaría", "Advertencia");
                this.Close();
            }
        }
    }
}
