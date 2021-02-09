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
    public partial class Herramientas : Form
    {
        public Herramientas()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f2 = new Actualizardatos();
            f2.StartPosition = FormStartPosition.Manual;
            f2.Location = new Point(this.Location.X + (this.Width - f2.Width) / 2, this.Location.Y + (this.Height - f2.Height) / 2);
            f2.Show(this);
        }

        private void Herramientas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/1WUBY5rI54wvNLcoWWIgv9h5PRXuQsEzA/view?usp=sharing");
        }

        private void BtnHistCambios_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f2 = new Historicocambios();
            f2.StartPosition = FormStartPosition.Manual;
            f2.Location = new Point(this.Location.X + (this.Width - f2.Width) / 2, this.Location.Y + (this.Height - f2.Height) / 2);
            f2.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f2 = new FichaNotaria();
            f2.StartPosition = FormStartPosition.Manual;
            f2.Location = new Point(this.Location.X + (this.Width - f2.Width) / 2, this.Location.Y + (this.Height - f2.Height) / 2);
            f2.Show(this);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new BuscarNotaria(this);
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(this.Location.X + (this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);
            frm.Show(this);
        }
    }
}
