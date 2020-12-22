namespace configurador_tlf_V2
{
    partial class Agregartlfichanotaria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregartlfichanotaria));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textoextension = new System.Windows.Forms.TextBox();
            this.textoalias = new System.Windows.Forms.TextBox();
            this.textoip = new System.Windows.Forms.TextBox();
            this.listamodelo = new System.Windows.Forms.ComboBox();
            this.textonserie = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarcambios = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textonotaria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Extensión:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alias:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Modelo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nº Serie:";
            // 
            // textoextension
            // 
            this.textoextension.Location = new System.Drawing.Point(75, 43);
            this.textoextension.Name = "textoextension";
            this.textoextension.Size = new System.Drawing.Size(171, 20);
            this.textoextension.TabIndex = 5;
            // 
            // textoalias
            // 
            this.textoalias.Location = new System.Drawing.Point(75, 79);
            this.textoalias.Name = "textoalias";
            this.textoalias.Size = new System.Drawing.Size(171, 20);
            this.textoalias.TabIndex = 6;
            // 
            // textoip
            // 
            this.textoip.Location = new System.Drawing.Point(74, 115);
            this.textoip.Name = "textoip";
            this.textoip.Size = new System.Drawing.Size(172, 20);
            this.textoip.TabIndex = 7;
            // 
            // listamodelo
            // 
            this.listamodelo.FormattingEnabled = true;
            this.listamodelo.Location = new System.Drawing.Point(74, 152);
            this.listamodelo.Name = "listamodelo";
            this.listamodelo.Size = new System.Drawing.Size(172, 21);
            this.listamodelo.TabIndex = 8;
            // 
            // textonserie
            // 
            this.textonserie.Location = new System.Drawing.Point(74, 191);
            this.textonserie.Name = "textonserie";
            this.textonserie.Size = new System.Drawing.Size(172, 20);
            this.textonserie.TabIndex = 9;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(135, 226);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 54);
            this.btnCancelar.TabIndex = 58;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardarcambios
            // 
            this.btnGuardarcambios.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnGuardarcambios.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarcambios.Image")));
            this.btnGuardarcambios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardarcambios.Location = new System.Drawing.Point(17, 226);
            this.btnGuardarcambios.Name = "btnGuardarcambios";
            this.btnGuardarcambios.Size = new System.Drawing.Size(112, 54);
            this.btnGuardarcambios.TabIndex = 57;
            this.btnGuardarcambios.Text = "Añadir teléfono";
            this.btnGuardarcambios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardarcambios.UseVisualStyleBackColor = true;
            this.btnGuardarcambios.Click += new System.EventHandler(this.btnGuardarcambios_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Notaría:";
            // 
            // textonotaria
            // 
            this.textonotaria.AutoSize = true;
            this.textonotaria.Location = new System.Drawing.Point(71, 9);
            this.textonotaria.Name = "textonotaria";
            this.textonotaria.Size = new System.Drawing.Size(47, 13);
            this.textonotaria.TabIndex = 60;
            this.textonotaria.Text = "Ninguna";
            // 
            // Agregartlfichanotaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 303);
            this.Controls.Add(this.textonotaria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarcambios);
            this.Controls.Add(this.textonserie);
            this.Controls.Add(this.listamodelo);
            this.Controls.Add(this.textoip);
            this.Controls.Add(this.textoalias);
            this.Controls.Add(this.textoextension);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Agregartlfichanotaria";
            this.Text = "Agregar teléfono";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox listamodelo;
        private System.Windows.Forms.TextBox textonserie;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarcambios;
        public System.Windows.Forms.TextBox textoextension;
        public System.Windows.Forms.TextBox textoalias;
        public System.Windows.Forms.TextBox textoip;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label textonotaria;
    }
}