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

    public partial class Form1 : Form
    {

        public String notariaabuscar;

        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection Conexion = new MySqlConnection("server=remotemysql.com; database=wWWHH1xcMX; Uid=wWWHH1xcMX; pwd=MmxyP2R8ey");
        DataSet ds;

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            notariaabuscar = buscadornotaria.Text.ToString();
            gridnotarias.DataSource = "<<>>";



            Conexion.Open();
            MySqlCommand mostrar = new MySqlCommand("SELECT NomNotaria, IPCentralita, MascaraRed, PuertaEnlace FROM centralita WHERE NomNotaria LIKE '%" + notariaabuscar + "%'", Conexion);

            MySqlDataAdapter m_datos = new MySqlDataAdapter(mostrar);
            ds = new DataSet();
            m_datos.Fill(ds);

            gridnotarias.DataSource = ds.Tables[0];
            Conexion.Close();
        }


    }
}
