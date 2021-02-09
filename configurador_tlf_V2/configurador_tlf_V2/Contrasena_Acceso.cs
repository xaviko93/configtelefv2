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
    public partial class Contrasena_Acceso : Form
    {
        public Contrasena_Acceso()
        {
            InitializeComponent();
        }

        private void texto_contra_TextChanged(object sender, EventArgs e)
        {
            String contra = "b30330104";
            if (texto_contra.Text.ToString() == contra){
                Form f2 = new Herramientas();
                f2.StartPosition = FormStartPosition.Manual;
                f2.Location = new Point(this.Location.X + (this.Width - f2.Width) / 2, this.Location.Y + (this.Height - f2.Height) / 2);
                this.Hide();
                f2.Show(this);

            }
        }
    }
}
