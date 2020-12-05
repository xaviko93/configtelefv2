namespace configurador_tlf_V2
{
    partial class Historicocambios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historicocambios));
            this.nombrenotariafiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gridhistorico = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.nseriefiltro = new System.Windows.Forms.TextBox();
            this.aliasfiltro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.extensionfiltro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IPfiltro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.modelofiltro = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridhistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // nombrenotariafiltro
            // 
            this.nombrenotariafiltro.Location = new System.Drawing.Point(122, 12);
            this.nombrenotariafiltro.Name = "nombrenotariafiltro";
            this.nombrenotariafiltro.Size = new System.Drawing.Size(442, 20);
            this.nombrenotariafiltro.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notaría seleccionada:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(579, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar notaría";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // gridhistorico
            // 
            this.gridhistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridhistorico.Location = new System.Drawing.Point(7, 50);
            this.gridhistorico.Name = "gridhistorico";
            this.gridhistorico.Size = new System.Drawing.Size(557, 388);
            this.gridhistorico.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nserie:";
            // 
            // nseriefiltro
            // 
            this.nseriefiltro.Location = new System.Drawing.Point(579, 66);
            this.nseriefiltro.Name = "nseriefiltro";
            this.nseriefiltro.Size = new System.Drawing.Size(116, 20);
            this.nseriefiltro.TabIndex = 5;
            // 
            // aliasfiltro
            // 
            this.aliasfiltro.Location = new System.Drawing.Point(579, 116);
            this.aliasfiltro.Name = "aliasfiltro";
            this.aliasfiltro.Size = new System.Drawing.Size(116, 20);
            this.aliasfiltro.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Alias:";
            // 
            // extensionfiltro
            // 
            this.extensionfiltro.Location = new System.Drawing.Point(579, 168);
            this.extensionfiltro.Name = "extensionfiltro";
            this.extensionfiltro.Size = new System.Drawing.Size(116, 20);
            this.extensionfiltro.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(576, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Extension:";
            // 
            // IPfiltro
            // 
            this.IPfiltro.Location = new System.Drawing.Point(579, 224);
            this.IPfiltro.Name = "IPfiltro";
            this.IPfiltro.Size = new System.Drawing.Size(116, 20);
            this.IPfiltro.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(576, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "IP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(576, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Modelo:";
            // 
            // modelofiltro
            // 
            this.modelofiltro.FormattingEnabled = true;
            this.modelofiltro.Location = new System.Drawing.Point(579, 278);
            this.modelofiltro.Name = "modelofiltro";
            this.modelofiltro.Size = new System.Drawing.Size(116, 21);
            this.modelofiltro.TabIndex = 13;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFiltrar.Location = new System.Drawing.Point(579, 310);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(116, 61);
            this.btnFiltrar.TabIndex = 14;
            this.btnFiltrar.Text = "FILTRAR";
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.ForeColor = System.Drawing.Color.DarkRed;
            this.btnLimpiarFiltros.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarFiltros.Image")));
            this.btnLimpiarFiltros.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(579, 377);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(116, 61);
            this.btnLimpiarFiltros.TabIndex = 15;
            this.btnLimpiarFiltros.Text = "LIMPIAR FILTROS";
            this.btnLimpiarFiltros.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // Historicocambios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.btnLimpiarFiltros);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.modelofiltro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IPfiltro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.extensionfiltro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.aliasfiltro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nseriefiltro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridhistorico);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombrenotariafiltro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Historicocambios";
            this.Text = "Histórico de cambios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Historicocambios_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gridhistorico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView gridhistorico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nseriefiltro;
        private System.Windows.Forms.TextBox aliasfiltro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox extensionfiltro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IPfiltro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox modelofiltro;
        private System.Windows.Forms.Button btnFiltrar;
        public System.Windows.Forms.TextBox nombrenotariafiltro;
        private System.Windows.Forms.Button btnLimpiarFiltros;
    }
}