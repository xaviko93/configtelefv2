﻿namespace configurador_tlf_V2
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
            this.label5 = new System.Windows.Forms.Label();
            this.gridextensiones = new System.Windows.Forms.DataGridView();
            this.btnnuevoext = new System.Windows.Forms.Button();
            this.btnreconfigurartlf = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.aliasinput = new System.Windows.Forms.TextBox();
            this.textoalias = new System.Windows.Forms.Label();
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
            this.listamodelo = new System.Windows.Forms.ComboBox();
            this.textomodelotelefonos = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.gridtelefonosaconfigurar = new System.Windows.Forms.DataGridView();
            this.Extension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ipactual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreNotaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IPCentralita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mascarared = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuertaEnlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnconfigurar = new System.Windows.Forms.Button();
            this.btneliminartlf = new System.Windows.Forms.Button();
            this.btnprobar = new System.Windows.Forms.Button();
            this.checkmulticonfig = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.ipcentralitanotaria = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mascararednotaria = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.puertaenlacenotaria = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridextensiones)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NTLFinput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridtelefonosaconfigurar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(663, 557);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Progreso teléfono:";
            this.label1.Visible = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(586, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(583, 530);
            this.webBrowser1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1013, 557);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Progreso total:";
            this.label2.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(635, 578);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(150, 25);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Visible = false;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(974, 578);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(150, 25);
            this.progressBar2.TabIndex = 4;
            this.progressBar2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Notaría seleccionada:";
            // 
            // buscadornotaria
            // 
            this.buscadornotaria.Enabled = false;
            this.buscadornotaria.Location = new System.Drawing.Point(127, 19);
            this.buscadornotaria.Name = "buscadornotaria";
            this.buscadornotaria.Size = new System.Drawing.Size(359, 20);
            this.buscadornotaria.TabIndex = 7;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(492, 12);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(88, 38);
            this.btnbuscar.TabIndex = 8;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Teléfonos notaría (Extensiones):";
            // 
            // gridextensiones
            // 
            this.gridextensiones.AllowUserToOrderColumns = true;
            this.gridextensiones.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.gridextensiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridextensiones.Location = new System.Drawing.Point(12, 116);
            this.gridextensiones.Name = "gridextensiones";
            this.gridextensiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridextensiones.Size = new System.Drawing.Size(474, 162);
            this.gridextensiones.TabIndex = 11;
            this.gridextensiones.SelectionChanged += new System.EventHandler(this.gridextensiones_SelectionChanged);
            // 
            // btnnuevoext
            // 
            this.btnnuevoext.Location = new System.Drawing.Point(491, 116);
            this.btnnuevoext.Name = "btnnuevoext";
            this.btnnuevoext.Size = new System.Drawing.Size(88, 23);
            this.btnnuevoext.TabIndex = 12;
            this.btnnuevoext.Text = "Nuevo";
            this.btnnuevoext.UseVisualStyleBackColor = true;
            this.btnnuevoext.Click += new System.EventHandler(this.btnnuevoext_Click);
            // 
            // btnreconfigurartlf
            // 
            this.btnreconfigurartlf.Location = new System.Drawing.Point(491, 174);
            this.btnreconfigurartlf.Name = "btnreconfigurartlf";
            this.btnreconfigurartlf.Size = new System.Drawing.Size(88, 23);
            this.btnreconfigurartlf.TabIndex = 14;
            this.btnreconfigurartlf.Text = "Reconfigurar";
            this.btnreconfigurartlf.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(491, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.label3.Location = new System.Drawing.Point(810, 557);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 54);
            this.label3.TabIndex = 16;
            this.label3.Text = "1";
            this.label3.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.aliasinput);
            this.groupBox1.Controls.Add(this.textoalias);
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
            this.groupBox1.Controls.Add(this.listamodelo);
            this.groupBox1.Controls.Add(this.textomodelotelefonos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 112);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuración nuevos teléfonos";
            // 
            // aliasinput
            // 
            this.aliasinput.Enabled = false;
            this.aliasinput.Location = new System.Drawing.Point(402, 75);
            this.aliasinput.Name = "aliasinput";
            this.aliasinput.Size = new System.Drawing.Size(66, 20);
            this.aliasinput.TabIndex = 31;
            // 
            // textoalias
            // 
            this.textoalias.AutoSize = true;
            this.textoalias.Enabled = false;
            this.textoalias.Location = new System.Drawing.Point(366, 78);
            this.textoalias.Name = "textoalias";
            this.textoalias.Size = new System.Drawing.Size(32, 13);
            this.textoalias.TabIndex = 30;
            this.textoalias.Text = "Alias:";
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
            this.textomascarared.Location = new System.Drawing.Point(206, 78);
            this.textomascarared.Name = "textomascarared";
            this.textomascarared.Size = new System.Drawing.Size(51, 13);
            this.textomascarared.TabIndex = 28;
            this.textomascarared.Text = "Máscara:";
            // 
            // puertadeenlaceinput
            // 
            this.puertadeenlaceinput.Enabled = false;
            this.puertadeenlaceinput.Location = new System.Drawing.Point(97, 75);
            this.puertadeenlaceinput.Name = "puertadeenlaceinput";
            this.puertadeenlaceinput.Size = new System.Drawing.Size(102, 20);
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
            this.extensioninput.Size = new System.Drawing.Size(66, 20);
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
            this.textoipcentralita.Location = new System.Drawing.Point(206, 48);
            this.textoipcentralita.Name = "textoipcentralita";
            this.textoipcentralita.Size = new System.Drawing.Size(55, 13);
            this.textoipcentralita.TabIndex = 22;
            this.textoipcentralita.Text = "IP central:";
            // 
            // ipaonfigurarinput
            // 
            this.ipaonfigurarinput.Enabled = false;
            this.ipaonfigurarinput.Location = new System.Drawing.Point(97, 45);
            this.ipaonfigurarinput.Name = "ipaonfigurarinput";
            this.ipaonfigurarinput.Size = new System.Drawing.Size(102, 20);
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
            this.NTLFinput.Size = new System.Drawing.Size(65, 20);
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
            // listamodelo
            // 
            this.listamodelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.listamodelo.FormattingEnabled = true;
            this.listamodelo.Location = new System.Drawing.Point(98, 16);
            this.listamodelo.Name = "listamodelo";
            this.listamodelo.Size = new System.Drawing.Size(101, 21);
            this.listamodelo.TabIndex = 1;
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
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.Control;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(492, 364);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 30;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(492, 296);
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
            this.radioButton2.Location = new System.Drawing.Point(492, 318);
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
            this.label6.Location = new System.Drawing.Point(895, 557);
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
            this.label7.Location = new System.Drawing.Point(865, 578);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "DE";
            this.label7.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 399);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "Teléfonos a configurar:";
            // 
            // gridtelefonosaconfigurar
            // 
            this.gridtelefonosaconfigurar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridtelefonosaconfigurar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Extension,
            this.Alias,
            this.IP,
            this.Ipactual,
            this.Modelo,
            this.NombreNotaria,
            this.IPCentralita,
            this.Mascarared,
            this.PuertaEnlace});
            this.gridtelefonosaconfigurar.Location = new System.Drawing.Point(12, 415);
            this.gridtelefonosaconfigurar.Name = "gridtelefonosaconfigurar";
            this.gridtelefonosaconfigurar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridtelefonosaconfigurar.Size = new System.Drawing.Size(474, 188);
            this.gridtelefonosaconfigurar.TabIndex = 23;
            // 
            // Extension
            // 
            this.Extension.HeaderText = "Extensión";
            this.Extension.Name = "Extension";
            // 
            // Alias
            // 
            this.Alias.HeaderText = "Alias";
            this.Alias.Name = "Alias";
            // 
            // IP
            // 
            this.IP.HeaderText = "IP";
            this.IP.Name = "IP";
            // 
            // Ipactual
            // 
            this.Ipactual.HeaderText = "Ipactual";
            this.Ipactual.Name = "Ipactual";
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            // 
            // NombreNotaria
            // 
            this.NombreNotaria.HeaderText = "Nombre Notaría";
            this.NombreNotaria.Name = "NombreNotaria";
            // 
            // IPCentralita
            // 
            this.IPCentralita.HeaderText = "IP Centralita";
            this.IPCentralita.Name = "IPCentralita";
            // 
            // Mascarared
            // 
            this.Mascarared.HeaderText = "Máscara red";
            this.Mascarared.Name = "Mascarared";
            // 
            // PuertaEnlace
            // 
            this.PuertaEnlace.HeaderText = "Puerta Enlace";
            this.PuertaEnlace.Name = "PuertaEnlace";
            // 
            // btnconfigurar
            // 
            this.btnconfigurar.BackColor = System.Drawing.SystemColors.Control;
            this.btnconfigurar.Enabled = false;
            this.btnconfigurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfigurar.Location = new System.Drawing.Point(491, 557);
            this.btnconfigurar.Name = "btnconfigurar";
            this.btnconfigurar.Size = new System.Drawing.Size(87, 46);
            this.btnconfigurar.TabIndex = 24;
            this.btnconfigurar.Text = "Configurar";
            this.btnconfigurar.UseVisualStyleBackColor = false;
            // 
            // btneliminartlf
            // 
            this.btneliminartlf.Location = new System.Drawing.Point(490, 499);
            this.btneliminartlf.Name = "btneliminartlf";
            this.btneliminartlf.Size = new System.Drawing.Size(88, 23);
            this.btneliminartlf.TabIndex = 31;
            this.btneliminartlf.Text = "Eliminar";
            this.btneliminartlf.UseVisualStyleBackColor = true;
            this.btneliminartlf.Click += new System.EventHandler(this.btneliminartlf_Click);
            // 
            // btnprobar
            // 
            this.btnprobar.Location = new System.Drawing.Point(490, 528);
            this.btnprobar.Name = "btnprobar";
            this.btnprobar.Size = new System.Drawing.Size(88, 23);
            this.btnprobar.TabIndex = 32;
            this.btnprobar.Text = "Probar";
            this.btnprobar.UseVisualStyleBackColor = true;
            // 
            // checkmulticonfig
            // 
            this.checkmulticonfig.AutoSize = true;
            this.checkmulticonfig.Location = new System.Drawing.Point(492, 341);
            this.checkmulticonfig.Name = "checkmulticonfig";
            this.checkmulticonfig.Size = new System.Drawing.Size(80, 17);
            this.checkmulticonfig.TabIndex = 33;
            this.checkmulticonfig.Text = "Multi-config";
            this.checkmulticonfig.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.checkBox2.Location = new System.Drawing.Point(490, 203);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(90, 52);
            this.checkBox2.TabIndex = 34;
            this.checkBox2.Text = "Reconfigurar notaría completa";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // ipcentralitanotaria
            // 
            this.ipcentralitanotaria.Enabled = false;
            this.ipcentralitanotaria.Location = new System.Drawing.Point(84, 60);
            this.ipcentralitanotaria.Name = "ipcentralitanotaria";
            this.ipcentralitanotaria.Size = new System.Drawing.Size(93, 20);
            this.ipcentralitanotaria.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "IP centralita:";
            // 
            // mascararednotaria
            // 
            this.mascararednotaria.Enabled = false;
            this.mascararednotaria.Location = new System.Drawing.Point(240, 60);
            this.mascararednotaria.Name = "mascararednotaria";
            this.mascararednotaria.Size = new System.Drawing.Size(93, 20);
            this.mascararednotaria.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(183, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Máscara:";
            // 
            // puertaenlacenotaria
            // 
            this.puertaenlacenotaria.Enabled = false;
            this.puertaenlacenotaria.Location = new System.Drawing.Point(383, 60);
            this.puertaenlacenotaria.Name = "puertaenlacenotaria";
            this.puertaenlacenotaria.Size = new System.Drawing.Size(103, 20);
            this.puertaenlacenotaria.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(339, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Puerta:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoCheck = false;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.checkBox1.Location = new System.Drawing.Point(492, 55);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 30);
            this.checkBox1.TabIndex = 41;
            this.checkBox1.Text = "Notaría manual";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 622);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.puertaenlacenotaria);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mascararednotaria);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ipcentralitanotaria);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkmulticonfig);
            this.Controls.Add(this.btnprobar);
            this.Controls.Add(this.btneliminartlf);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnconfigurar);
            this.Controls.Add(this.gridtelefonosaconfigurar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnreconfigurartlf);
            this.Controls.Add(this.btnnuevoext);
            this.Controls.Add(this.gridextensiones);
            this.Controls.Add(this.label5);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridextensiones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NTLFinput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridtelefonosaconfigurar)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gridextensiones;
        private System.Windows.Forms.Button btnnuevoext;
        private System.Windows.Forms.Button btnreconfigurartlf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox listamodelo;
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
        private System.Windows.Forms.DataGridView gridtelefonosaconfigurar;
        private System.Windows.Forms.Button btnconfigurar;
        private System.Windows.Forms.TextBox aliasinput;
        private System.Windows.Forms.Label textoalias;
        private System.Windows.Forms.Button btneliminartlf;
        private System.Windows.Forms.Button btnprobar;
        private System.Windows.Forms.CheckBox checkmulticonfig;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extension;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alias;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ipactual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreNotaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPCentralita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mascarared;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuertaEnlace;
        private System.Windows.Forms.TextBox ipcentralitanotaria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox mascararednotaria;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox puertaenlacenotaria;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

