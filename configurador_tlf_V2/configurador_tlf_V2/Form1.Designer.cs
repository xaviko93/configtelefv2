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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.mascararedinput = new System.Windows.Forms.TextBox();
            this.textomascarared = new System.Windows.Forms.Label();
            this.puertadeenlaceinput = new System.Windows.Forms.TextBox();
            this.textopuertadeenlace = new System.Windows.Forms.Label();
            this.extensioninput = new System.Windows.Forms.TextBox();
            this.textoextension = new System.Windows.Forms.Label();
            this.ipcentralitainput = new System.Windows.Forms.TextBox();
            this.textoipcentralita = new System.Windows.Forms.Label();
            this.ipaonfigurarinput = new System.Windows.Forms.TextBox();
            this.textoipaconfigurar = new System.Windows.Forms.Label();
            this.NTLFinput = new System.Windows.Forms.NumericUpDown();
            this.NTLF = new System.Windows.Forms.Label();
            this.ipactualinput = new System.Windows.Forms.TextBox();
            this.textoipactual = new System.Windows.Forms.Label();
            this.listamodelotelefonos = new System.Windows.Forms.ComboBox();
            this.textomodelotelefonos = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnconfigurar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridnotarias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridextensiones)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NTLFinput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.label1.Visible = false;
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
            this.label2.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(613, 535);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(150, 25);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Visible = false;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(952, 535);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(150, 25);
            this.progressBar2.TabIndex = 4;
            this.progressBar2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre notaría:";
            // 
            // buscadornotaria
            // 
            this.buscadornotaria.Location = new System.Drawing.Point(137, 18);
            this.buscadornotaria.Name = "buscadornotaria";
            this.buscadornotaria.Size = new System.Drawing.Size(265, 20);
            this.buscadornotaria.TabIndex = 7;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(421, 16);
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
            this.gridnotarias.Location = new System.Drawing.Point(39, 45);
            this.gridnotarias.Name = "gridnotarias";
            this.gridnotarias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridnotarias.Size = new System.Drawing.Size(457, 93);
            this.gridnotarias.TabIndex = 9;
            this.gridnotarias.SelectionChanged += new System.EventHandler(this.gridnotarias_SelectionChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Teléfonos notaría (Extensiones):";
            // 
            // gridextensiones
            // 
            this.gridextensiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridextensiones.Location = new System.Drawing.Point(39, 162);
            this.gridextensiones.Name = "gridextensiones";
            this.gridextensiones.Size = new System.Drawing.Size(457, 110);
            this.gridextensiones.TabIndex = 11;
            // 
            // btnnuevoext
            // 
            this.btnnuevoext.Location = new System.Drawing.Point(502, 162);
            this.btnnuevoext.Name = "btnnuevoext";
            this.btnnuevoext.Size = new System.Drawing.Size(88, 23);
            this.btnnuevoext.TabIndex = 12;
            this.btnnuevoext.Text = "Nuevo";
            this.btnnuevoext.UseVisualStyleBackColor = true;
            // 
            // btneditarext
            // 
            this.btneditarext.Location = new System.Drawing.Point(502, 191);
            this.btneditarext.Name = "btneditarext";
            this.btneditarext.Size = new System.Drawing.Size(88, 23);
            this.btneditarext.TabIndex = 13;
            this.btneditarext.Text = "Editar";
            this.btneditarext.UseVisualStyleBackColor = true;
            // 
            // btnreconfigurartlf
            // 
            this.btnreconfigurartlf.Location = new System.Drawing.Point(502, 249);
            this.btnreconfigurartlf.Name = "btnreconfigurartlf";
            this.btnreconfigurartlf.Size = new System.Drawing.Size(88, 23);
            this.btnreconfigurartlf.TabIndex = 14;
            this.btnreconfigurartlf.Text = "Reconfigurar";
            this.btnreconfigurartlf.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(502, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.label3.Location = new System.Drawing.Point(788, 514);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 54);
            this.label3.TabIndex = 16;
            this.label3.Text = "1";
            this.label3.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnagregar);
            this.groupBox1.Controls.Add(this.mascararedinput);
            this.groupBox1.Controls.Add(this.textomascarared);
            this.groupBox1.Controls.Add(this.puertadeenlaceinput);
            this.groupBox1.Controls.Add(this.textopuertadeenlace);
            this.groupBox1.Controls.Add(this.extensioninput);
            this.groupBox1.Controls.Add(this.textoextension);
            this.groupBox1.Controls.Add(this.ipcentralitainput);
            this.groupBox1.Controls.Add(this.textoipcentralita);
            this.groupBox1.Controls.Add(this.ipaonfigurarinput);
            this.groupBox1.Controls.Add(this.textoipaconfigurar);
            this.groupBox1.Controls.Add(this.NTLFinput);
            this.groupBox1.Controls.Add(this.NTLF);
            this.groupBox1.Controls.Add(this.ipactualinput);
            this.groupBox1.Controls.Add(this.textoipactual);
            this.groupBox1.Controls.Add(this.listamodelotelefonos);
            this.groupBox1.Controls.Add(this.textomodelotelefonos);
            this.groupBox1.Location = new System.Drawing.Point(39, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 112);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuración nuevos teléfonos";
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.Control;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(376, 73);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 30;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            // 
            // mascararedinput
            // 
            this.mascararedinput.Enabled = false;
            this.mascararedinput.Location = new System.Drawing.Point(263, 75);
            this.mascararedinput.Name = "mascararedinput";
            this.mascararedinput.Size = new System.Drawing.Size(93, 20);
            this.mascararedinput.TabIndex = 29;
            // 
            // textomascarared
            // 
            this.textomascarared.AutoSize = true;
            this.textomascarared.Enabled = false;
            this.textomascarared.Location = new System.Drawing.Point(193, 78);
            this.textomascarared.Name = "textomascarared";
            this.textomascarared.Size = new System.Drawing.Size(69, 13);
            this.textomascarared.TabIndex = 28;
            this.textomascarared.Text = "Máscara red:";
            // 
            // puertadeenlaceinput
            // 
            this.puertadeenlaceinput.Enabled = false;
            this.puertadeenlaceinput.Location = new System.Drawing.Point(97, 75);
            this.puertadeenlaceinput.Name = "puertadeenlaceinput";
            this.puertadeenlaceinput.Size = new System.Drawing.Size(93, 20);
            this.puertadeenlaceinput.TabIndex = 27;
            // 
            // textopuertadeenlace
            // 
            this.textopuertadeenlace.AutoSize = true;
            this.textopuertadeenlace.Enabled = false;
            this.textopuertadeenlace.Location = new System.Drawing.Point(9, 78);
            this.textopuertadeenlace.Name = "textopuertadeenlace";
            this.textopuertadeenlace.Size = new System.Drawing.Size(91, 13);
            this.textopuertadeenlace.TabIndex = 26;
            this.textopuertadeenlace.Text = "Puerta de enlace:";
            // 
            // extensioninput
            // 
            this.extensioninput.Enabled = false;
            this.extensioninput.Location = new System.Drawing.Point(402, 45);
            this.extensioninput.Name = "extensioninput";
            this.extensioninput.Size = new System.Drawing.Size(49, 20);
            this.extensioninput.TabIndex = 25;
            // 
            // textoextension
            // 
            this.textoextension.AutoSize = true;
            this.textoextension.Enabled = false;
            this.textoextension.Location = new System.Drawing.Point(365, 48);
            this.textoextension.Name = "textoextension";
            this.textoextension.Size = new System.Drawing.Size(31, 13);
            this.textoextension.TabIndex = 24;
            this.textoextension.Text = "EXT:";
            // 
            // ipcentralitainput
            // 
            this.ipcentralitainput.Enabled = false;
            this.ipcentralitainput.Location = new System.Drawing.Point(263, 45);
            this.ipcentralitainput.Name = "ipcentralitainput";
            this.ipcentralitainput.Size = new System.Drawing.Size(93, 20);
            this.ipcentralitainput.TabIndex = 23;
            // 
            // textoipcentralita
            // 
            this.textoipcentralita.AutoSize = true;
            this.textoipcentralita.Enabled = false;
            this.textoipcentralita.Location = new System.Drawing.Point(196, 50);
            this.textoipcentralita.Name = "textoipcentralita";
            this.textoipcentralita.Size = new System.Drawing.Size(66, 13);
            this.textoipcentralita.TabIndex = 22;
            this.textoipcentralita.Text = "IP centralita:";
            // 
            // ipaonfigurarinput
            // 
            this.ipaonfigurarinput.Enabled = false;
            this.ipaonfigurarinput.Location = new System.Drawing.Point(97, 45);
            this.ipaonfigurarinput.Name = "ipaonfigurarinput";
            this.ipaonfigurarinput.Size = new System.Drawing.Size(93, 20);
            this.ipaonfigurarinput.TabIndex = 7;
            // 
            // textoipaconfigurar
            // 
            this.textoipaconfigurar.AutoSize = true;
            this.textoipaconfigurar.Enabled = false;
            this.textoipaconfigurar.Location = new System.Drawing.Point(9, 48);
            this.textoipaconfigurar.Name = "textoipaconfigurar";
            this.textoipaconfigurar.Size = new System.Drawing.Size(79, 13);
            this.textoipaconfigurar.TabIndex = 6;
            this.textoipaconfigurar.Text = "IP a configurar:";
            // 
            // NTLFinput
            // 
            this.NTLFinput.Location = new System.Drawing.Point(403, 16);
            this.NTLFinput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NTLFinput.Name = "NTLFinput";
            this.NTLFinput.Size = new System.Drawing.Size(48, 20);
            this.NTLFinput.TabIndex = 5;
            this.NTLFinput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NTLF
            // 
            this.NTLF.AutoSize = true;
            this.NTLF.Location = new System.Drawing.Point(362, 19);
            this.NTLF.Name = "NTLF";
            this.NTLF.Size = new System.Drawing.Size(44, 13);
            this.NTLF.TabIndex = 4;
            this.NTLF.Text = "Nº TLF:";
            // 
            // ipactualinput
            // 
            this.ipactualinput.Location = new System.Drawing.Point(263, 15);
            this.ipactualinput.Name = "ipactualinput";
            this.ipactualinput.Size = new System.Drawing.Size(93, 20);
            this.ipactualinput.TabIndex = 3;
            // 
            // textoipactual
            // 
            this.textoipactual.AutoSize = true;
            this.textoipactual.Location = new System.Drawing.Point(205, 20);
            this.textoipactual.Name = "textoipactual";
            this.textoipactual.Size = new System.Drawing.Size(52, 13);
            this.textoipactual.TabIndex = 2;
            this.textoipactual.Text = "IP actual:";
            // 
            // listamodelotelefonos
            // 
            this.listamodelotelefonos.FormattingEnabled = true;
            this.listamodelotelefonos.Location = new System.Drawing.Point(98, 16);
            this.listamodelotelefonos.Name = "listamodelotelefonos";
            this.listamodelotelefonos.Size = new System.Drawing.Size(92, 21);
            this.listamodelotelefonos.TabIndex = 1;
            // 
            // textomodelotelefonos
            // 
            this.textomodelotelefonos.AutoSize = true;
            this.textomodelotelefonos.Location = new System.Drawing.Point(6, 20);
            this.textomodelotelefonos.Name = "textomodelotelefonos";
            this.textomodelotelefonos.Size = new System.Drawing.Size(86, 13);
            this.textomodelotelefonos.TabIndex = 0;
            this.textomodelotelefonos.Text = "Modelo teléfono:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(502, 303);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(78, 17);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Automática";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(502, 326);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 17);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.Text = "Manual";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.label6.Location = new System.Drawing.Point(873, 514);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 54);
            this.label6.TabIndex = 20;
            this.label6.Text = "1";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(843, 535);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "DE";
            this.label7.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(42, 397);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "Teléfonos a configurar:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 413);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(457, 147);
            this.dataGridView1.TabIndex = 23;
            // 
            // btnconfigurar
            // 
            this.btnconfigurar.BackColor = System.Drawing.SystemColors.Control;
            this.btnconfigurar.Enabled = false;
            this.btnconfigurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfigurar.Location = new System.Drawing.Point(503, 514);
            this.btnconfigurar.Name = "btnconfigurar";
            this.btnconfigurar.Size = new System.Drawing.Size(87, 46);
            this.btnconfigurar.TabIndex = 24;
            this.btnconfigurar.Text = "Configurar";
            this.btnconfigurar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 586);
            this.Controls.Add(this.btnconfigurar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NTLFinput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox listamodelotelefonos;
        private System.Windows.Forms.Label textomodelotelefonos;
        private System.Windows.Forms.Label NTLF;
        private System.Windows.Forms.TextBox ipactualinput;
        private System.Windows.Forms.Label textoipactual;
        private System.Windows.Forms.TextBox ipcentralitainput;
        private System.Windows.Forms.Label textoipcentralita;
        private System.Windows.Forms.TextBox ipaonfigurarinput;
        private System.Windows.Forms.Label textoipaconfigurar;
        private System.Windows.Forms.NumericUpDown NTLFinput;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.TextBox mascararedinput;
        private System.Windows.Forms.Label textomascarared;
        private System.Windows.Forms.TextBox puertadeenlaceinput;
        private System.Windows.Forms.Label textopuertadeenlace;
        private System.Windows.Forms.TextBox extensioninput;
        private System.Windows.Forms.Label textoextension;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnconfigurar;
    }
}

