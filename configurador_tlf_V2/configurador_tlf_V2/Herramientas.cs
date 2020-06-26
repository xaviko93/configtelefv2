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
            Form frm = new Actualizardatos();
            AddOwnedForm(frm);
            frm.Show();
        }
    }
}
