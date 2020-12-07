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
    public partial class Buscadornotariaficha : Form
    {
        public Buscadornotariaficha()
        {
            InitializeComponent();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM centralita", Conexion);
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

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM centralita WHERE NomNotaria LIKE '%" + notariaabuscar2 + "%'", Conexion);
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
                FichaNotaria pantallaprincipal2 = Owner as FichaNotaria;
                pantallaprincipal2.nombrenotaria.Enabled = true;
                pantallaprincipal2.textoipcentralita.Enabled = true;
                pantallaprincipal2.ipcentralitainput.Enabled = true;
                pantallaprincipal2.textomascarared.Enabled = true;
                pantallaprincipal2.mascararedinput.Enabled = true;
                pantallaprincipal2.textopuertadeenlace.Enabled = true;
                pantallaprincipal2.puertadeenlaceinput.Enabled = true;
                pantallaprincipal2.ippublicapretexto.Enabled = true;
                pantallaprincipal2.ippublicatexto.Enabled = true;
                pantallaprincipal2.nombrenotaria.Text = listabusquedanotarias.SelectedItems[0].SubItems[0].Text;
                pantallaprincipal2.ipcentralitainput.Text = listabusquedanotarias.SelectedItems[0].SubItems[1].Text;
                pantallaprincipal2.mascararedinput.Text = listabusquedanotarias.SelectedItems[0].SubItems[2].Text;
                pantallaprincipal2.puertadeenlaceinput.Text = listabusquedanotarias.SelectedItems[0].SubItems[3].Text;
                pantallaprincipal2.cargarextensiones();
                pantallaprincipal2.Show();
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
                Historicocambios pantallaprincipal = Owner as Historicocambios;
                pantallaprincipal.nombrenotariafiltro.Text = listabusquedanotarias.SelectedItems[0].SubItems[0].Text;
                this.Close();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("No has seleccionado ninguna Notaría", "Advertencia");
                this.Close();
            }
        }

        private void Buscadornotariahistorico_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void btnBuscarNotaria_Click_1(object sender, EventArgs e)
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

        private void listabusquedanotarias_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                FichaNotaria pantallaprincipal2 = Owner as FichaNotaria;
                pantallaprincipal2.nombrenotaria.Enabled = true;
                pantallaprincipal2.textoipcentralita.Enabled = true;
                pantallaprincipal2.ipcentralitainput.Enabled = true;
                pantallaprincipal2.textomascarared.Enabled = true;
                pantallaprincipal2.mascararedinput.Enabled = true;
                pantallaprincipal2.textopuertadeenlace.Enabled = true;
                pantallaprincipal2.puertadeenlaceinput.Enabled = true;
                pantallaprincipal2.ippublicapretexto.Enabled = true;
                pantallaprincipal2.ippublicatexto.Enabled = true;
                pantallaprincipal2.nombrenotaria.Text = listabusquedanotarias.SelectedItems[0].SubItems[0].Text;
                pantallaprincipal2.ipcentralitainput.Text = listabusquedanotarias.SelectedItems[0].SubItems[1].Text;
                pantallaprincipal2.mascararedinput.Text = listabusquedanotarias.SelectedItems[0].SubItems[2].Text;
                pantallaprincipal2.puertadeenlaceinput.Text = listabusquedanotarias.SelectedItems[0].SubItems[3].Text;
                pantallaprincipal2.cargarextensiones();
                pantallaprincipal2.Show();
                this.Close();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("No has seleccionado ninguna Notaría", "Advertencia");
                this.Close();
            }
        }

        private void Buscadornotariaficha_FormClosing(object sender, FormClosingEventArgs e)
        {
            FichaNotaria pantallaprincipal2 = Owner as FichaNotaria;
            pantallaprincipal2.Show();
        }
    }
}