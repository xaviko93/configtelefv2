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
            if (nombrenotariafiltro.Text == "" && ventanapadre.VariablesGlobales.nombrenotariaseleccionadapublica != null)
            {
                nombrenotariafiltro.Text = ventanapadre.VariablesGlobales.nombrenotariaseleccionadapublica;
                MySqlCommand cmd = new MySqlCommand("SELECT Notaria, Fecha, Hora, Extension, AliasInstalado, IPInstalado, NserieInstalado, ModeloInstalado, AliasRetirado, IPRetirado, NserieRetirado, ModeloRetirado FROM histcambios WHERE Notaria LIKE '" + ventanapadre.VariablesGlobales.nombrenotariaseleccionadapublica + "'", Conexion);
                MySqlDataAdapter m_datos2 = new MySqlDataAdapter(cmd);
                ds2 = new DataSet();
                m_datos2.Fill(ds2);
                gridhistorico.DataSource = ds2.Tables[0];
                Conexion.Close();
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("SELECT Notaria, Fecha, Hora, Extension, AliasInstalado, IPInstalado, NserieInstalado, ModeloInstalado, AliasRetirado, IPRetirado, NserieRetirado, ModeloRetirado FROM histcambios", Conexion);
                MySqlDataAdapter m_datos2 = new MySqlDataAdapter(cmd);
                ds2 = new DataSet();
                m_datos2.Fill(ds2);
                gridhistorico.DataSource = ds2.Tables[0];
                Conexion.Close();
            }

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

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            String notariabuscada = "%" + nombrenotariafiltro.Text.ToString() + "%";
            String nserie = "%" + nseriefiltro.Text.ToString() + "%";
            String extensionbuscada = "%" + extensionfiltro.Text.ToString() + "%";
            String aliasbuscado = "%" + aliasfiltro.Text.ToString() + "%";
            String ipbuscada = "%" + IPfiltro.Text.ToString() + "%";
            String modelobuscado = "%" + modelofiltro.Text.ToString() + "%";
            ds2.Clear();
            if (nombrenotariafiltro.Text.ToString().Equals("")) { notariabuscada = "%"; }
            if (nseriefiltro.Text.ToString().Equals("")) { nserie = "%"; }
            if (extensionfiltro.Text.ToString().Equals("")) { extensionbuscada = "%"; }
            if (aliasfiltro.Text.ToString().Equals("")) { aliasbuscado = "%"; }
            if (IPfiltro.Text.ToString().Equals("")) { ipbuscada = "%"; }
            if (modelofiltro.Text.ToString().Equals("")) { modelobuscado = "%"; }
            MySqlCommand cmd = new MySqlCommand("SELECT Notaria, Fecha, Hora, Extension, AliasInstalado, IPInstalado, NserieInstalado, ModeloInstalado, AliasRetirado, IPRetirado, NserieRetirado, ModeloRetirado FROM histcambios WHERE Notaria LIKE '" + notariabuscada + "' AND (NserieInstalado LIKE '" + nserie + "' OR NserieRetirado LIKE '" + nserie + "') AND (AliasInstalado LIKE '" + aliasbuscado + "' OR AliasRetirado LIKE '" + aliasbuscado + "') AND Extension LIKE '" + extensionbuscada + "' AND (IPInstalado LIKE '" + ipbuscada + "' OR IPRetirado LIKE '" + ipbuscada + "') AND (ModeloInstalado LIKE '" + modelobuscado + "' OR ModeloRetirado LIKE '" + modelobuscado + "')", Conexion);
            MySqlDataAdapter m_datos2 = new MySqlDataAdapter(cmd);
            ds2 = new DataSet();
            m_datos2.Fill(ds2);
            gridhistorico.DataSource = ds2.Tables[0];
            Conexion.Close();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            nombrenotariafiltro.Text = "";
            nseriefiltro.Text = "";
            extensionfiltro.Text = "";
            aliasfiltro.Text = "";
            IPfiltro.Text = "";
            modelofiltro.Text = "";

            MySqlCommand cmd = new MySqlCommand("SELECT Notaria, Fecha, Hora, Extension, AliasInstalado, IPInstalado, NserieInstalado, ModeloInstalado, AliasRetirado, IPRetirado, NserieRetirado, ModeloRetirado FROM histcambios", Conexion);
            MySqlDataAdapter m_datos2 = new MySqlDataAdapter(cmd);
            ds2 = new DataSet();
            m_datos2.Fill(ds2);
            gridhistorico.DataSource = ds2.Tables[0];
            Conexion.Close();
        }

        private void Historicocambios_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
