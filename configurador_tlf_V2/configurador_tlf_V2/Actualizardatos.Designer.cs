﻿namespace configurador_tlf_V2
{
    partial class Actualizardatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actualizardatos));
            this.textoip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textopuerto = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nombrenotaria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.contra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textoip
            // 
            this.textoip.Location = new System.Drawing.Point(120, 50);
            this.textoip.Name = "textoip";
            this.textoip.Size = new System.Drawing.Size(133, 20);
            this.textoip.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP pública centralita:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Puerto:";
            // 
            // textopuerto
            // 
            this.textopuerto.Location = new System.Drawing.Point(303, 50);
            this.textopuerto.Name = "textopuerto";
            this.textopuerto.Size = new System.Drawing.Size(56, 20);
            this.textopuerto.TabIndex = 2;
            this.textopuerto.Text = "6598";
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(140, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 56);
            this.button3.TabIndex = 7;
            this.button3.Text = "Actualizar datos";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre de notaría:";
            // 
            // nombrenotaria
            // 
            this.nombrenotaria.Location = new System.Drawing.Point(120, 16);
            this.nombrenotaria.Name = "nombrenotaria";
            this.nombrenotaria.Size = new System.Drawing.Size(239, 20);
            this.nombrenotaria.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Usuario:";
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(64, 82);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(95, 20);
            this.usuario.TabIndex = 4;
            this.usuario.Text = "root";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Contraseña:";
            // 
            // contra
            // 
            this.contra.Location = new System.Drawing.Point(235, 82);
            this.contra.Name = "contra";
            this.contra.PasswordChar = '*';
            this.contra.Size = new System.Drawing.Size(124, 20);
            this.contra.TabIndex = 5;
            this.contra.Text = "4a9P1dK9xrn1l";
            // 
            // Actualizardatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 193);
            this.Controls.Add(this.contra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nombrenotaria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textopuerto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Actualizardatos";
            this.Text = "Actualizar / Añadir Notaria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Actualizardatos_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.Actualizardatos_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textopuerto;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombrenotaria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox contra;
    }
}