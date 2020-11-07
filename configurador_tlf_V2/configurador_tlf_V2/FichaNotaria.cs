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
    }
}
