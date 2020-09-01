namespace configurador_tlf_V2
{
    partial class Buscadornotariahistorico
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
            this.btnBuscarNotaria = new System.Windows.Forms.Button();
            this.btnSeleccionarNotaria = new System.Windows.Forms.Button();
            this.listabusquedanotarias = new System.Windows.Forms.ListView();
            this.NombreNotaria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IPCentralita = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mascarared = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PuertaEnlace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buscadortextonotaria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuscarNotaria
            // 
            this.btnBuscarNotaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarNotaria.Location = new System.Drawing.Point(433, 12);
            this.btnBuscarNotaria.Name = "btnBuscarNotaria";
            this.btnBuscarNotaria.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarNotaria.TabIndex = 11;
            this.btnBuscarNotaria.Text = "Buscar";
            this.btnBuscarNotaria.UseVisualStyleBackColor = true;
            this.btnBuscarNotaria.Click += new System.EventHandler(this.BtnBuscarNotaria_Click);
            // 
            // btnSeleccionarNotaria
            // 
            this.btnSeleccionarNotaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarNotaria.Location = new System.Drawing.Point(433, 480);
            this.btnSeleccionarNotaria.Name = "btnSeleccionarNotaria";
            this.btnSeleccionarNotaria.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionarNotaria.TabIndex = 13;
            this.btnSeleccionarNotaria.Text = "Aceptar";
            this.btnSeleccionarNotaria.UseVisualStyleBackColor = true;
            this.btnSeleccionarNotaria.Click += new System.EventHandler(this.BtnSeleccionarNotaria_Click);
            // 
            // listabusquedanotarias
            // 
            this.listabusquedanotarias.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listabusquedanotarias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NombreNotaria,
            this.IPCentralita,
            this.Mascarared,
            this.PuertaEnlace});
            this.listabusquedanotarias.FullRowSelect = true;
            this.listabusquedanotarias.GridLines = true;
            this.listabusquedanotarias.HideSelection = false;
            this.listabusquedanotarias.Location = new System.Drawing.Point(23, 44);
            this.listabusquedanotarias.Name = "listabusquedanotarias";
            this.listabusquedanotarias.Size = new System.Drawing.Size(398, 459);
            this.listabusquedanotarias.TabIndex = 12;
            this.listabusquedanotarias.UseCompatibleStateImageBehavior = false;
            this.listabusquedanotarias.View = System.Windows.Forms.View.Details;
            this.listabusquedanotarias.SelectedIndexChanged += new System.EventHandler(this.Listabusquedanotarias_SelectedIndexChanged);
            // 
            // NombreNotaria
            // 
            this.NombreNotaria.Text = "Nombre de Notaría";
            this.NombreNotaria.Width = 354;
            // 
            // IPCentralita
            // 
            this.IPCentralita.Width = 0;
            // 
            // Mascarared
            // 
            this.Mascarared.Width = 0;
            // 
            // PuertaEnlace
            // 
            this.PuertaEnlace.Width = 0;
            // 
            // buscadortextonotaria
            // 
            this.buscadortextonotaria.Location = new System.Drawing.Point(110, 14);
            this.buscadortextonotaria.Name = "buscadortextonotaria";
            this.buscadortextonotaria.Size = new System.Drawing.Size(311, 20);
            this.buscadortextonotaria.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nombre notaría:";
            // 
            // Buscadornotariahistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 521);
            this.Controls.Add(this.btnBuscarNotaria);
            this.Controls.Add(this.btnSeleccionarNotaria);
            this.Controls.Add(this.listabusquedanotarias);
            this.Controls.Add(this.buscadortextonotaria);
            this.Controls.Add(this.label4);
            this.Name = "Buscadornotariahistorico";
            this.Text = "Buscadornotariahistorico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarNotaria;
        private System.Windows.Forms.Button btnSeleccionarNotaria;
        private System.Windows.Forms.ListView listabusquedanotarias;
        private System.Windows.Forms.ColumnHeader NombreNotaria;
        private System.Windows.Forms.ColumnHeader IPCentralita;
        private System.Windows.Forms.ColumnHeader Mascarared;
        private System.Windows.Forms.ColumnHeader PuertaEnlace;
        private System.Windows.Forms.TextBox buscadortextonotaria;
        private System.Windows.Forms.Label label4;
    }
}