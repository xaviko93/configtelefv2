namespace configurador_tlf_V2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.buscadornotaria = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.gridnotarias = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.gridextensiones = new System.Windows.Forms.DataGridView();
            this.btnnuevoext = new System.Windows.Forms.Button();
            this.btneditarext = new System.Windows.Forms.Button();
            this.btnreconfigurartlf = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridnotarias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridextensiones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(641, 514);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Progreso teléfono:";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(613, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(490, 490);
            this.webBrowser1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(991, 514);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Progreso total:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(613, 535);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(150, 25);
            this.progressBar1.TabIndex = 3;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(952, 535);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(150, 25);
            this.progressBar2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre notaría:";
            // 
            // buscadornotaria
            // 
            this.buscadornotaria.Location = new System.Drawing.Point(137, 19);
            this.buscadornotaria.Name = "buscadornotaria";
            this.buscadornotaria.Size = new System.Drawing.Size(265, 20);
            this.buscadornotaria.TabIndex = 7;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(421, 17);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 8;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridnotarias
            // 
            this.gridnotarias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridnotarias.Location = new System.Drawing.Point(39, 46);
            this.gridnotarias.Name = "gridnotarias";
            this.gridnotarias.Size = new System.Drawing.Size(457, 93);
            this.gridnotarias.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Teléfonos notaría (Extensiones):";
            // 
            // gridextensiones
            // 
            this.gridextensiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridextensiones.Location = new System.Drawing.Point(39, 170);
            this.gridextensiones.Name = "gridextensiones";
            this.gridextensiones.Size = new System.Drawing.Size(457, 120);
            this.gridextensiones.TabIndex = 11;
            // 
            // btnnuevoext
            // 
            this.btnnuevoext.Location = new System.Drawing.Point(502, 170);
            this.btnnuevoext.Name = "btnnuevoext";
            this.btnnuevoext.Size = new System.Drawing.Size(88, 23);
            this.btnnuevoext.TabIndex = 12;
            this.btnnuevoext.Text = "Nuevo";
            this.btnnuevoext.UseVisualStyleBackColor = true;
            // 
            // btneditarext
            // 
            this.btneditarext.Location = new System.Drawing.Point(502, 199);
            this.btneditarext.Name = "btneditarext";
            this.btneditarext.Size = new System.Drawing.Size(88, 23);
            this.btneditarext.TabIndex = 13;
            this.btneditarext.Text = "Editar";
            this.btneditarext.UseVisualStyleBackColor = true;
            // 
            // btnreconfigurartlf
            // 
            this.btnreconfigurartlf.Location = new System.Drawing.Point(502, 257);
            this.btnreconfigurartlf.Name = "btnreconfigurartlf";
            this.btnreconfigurartlf.Size = new System.Drawing.Size(88, 23);
            this.btnreconfigurartlf.TabIndex = 14;
            this.btnreconfigurartlf.Text = "Reconfigurar";
            this.btnreconfigurartlf.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(502, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 586);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnreconfigurartlf);
            this.Controls.Add(this.btneditarext);
            this.Controls.Add(this.btnnuevoext);
            this.Controls.Add(this.gridextensiones);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gridnotarias);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.buscadornotaria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridnotarias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridextensiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox buscadornotaria;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.DataGridView gridnotarias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gridextensiones;
        private System.Windows.Forms.Button btnnuevoext;
        private System.Windows.Forms.Button btneditarext;
        private System.Windows.Forms.Button btnreconfigurartlf;
        private System.Windows.Forms.Button button1;
    }
}

