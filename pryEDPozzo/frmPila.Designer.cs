namespace pryEDPozzo
{
    partial class frmPila
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
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPila = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstPila = new System.Windows.Forms.ListBox();
            this.mrcListado = new System.Windows.Forms.GroupBox();
            this.lblTramiteEliminar = new System.Windows.Forms.Label();
            this.lblNombreEliminar = new System.Windows.Forms.Label();
            this.lblCodigoEliminar = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.lblTrámite = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.mrcEliminar = new System.Windows.Forms.GroupBox();
            this.mrcNuevoElemento = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).BeginInit();
            this.mrcListado.SuspendLayout();
            this.mrcEliminar.SuspendLayout();
            this.mrcNuevoElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 70;
            // 
            // dgvPila
            // 
            this.dgvPila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvPila.Location = new System.Drawing.Point(244, 294);
            this.dgvPila.Name = "dgvPila";
            this.dgvPila.RowHeadersWidth = 51;
            this.dgvPila.Size = new System.Drawing.Size(474, 238);
            this.dgvPila.TabIndex = 4;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Trámite";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // lstPila
            // 
            this.lstPila.FormattingEnabled = true;
            this.lstPila.Location = new System.Drawing.Point(17, 29);
            this.lstPila.Name = "lstPila";
            this.lstPila.Size = new System.Drawing.Size(191, 238);
            this.lstPila.TabIndex = 0;
            // 
            // mrcListado
            // 
            this.mrcListado.Controls.Add(this.lstPila);
            this.mrcListado.Location = new System.Drawing.Point(10, 266);
            this.mrcListado.Name = "mrcListado";
            this.mrcListado.Size = new System.Drawing.Size(727, 293);
            this.mrcListado.TabIndex = 6;
            this.mrcListado.TabStop = false;
            this.mrcListado.Text = "Listado en una Lista y una Grilla";
            // 
            // lblTramiteEliminar
            // 
            this.lblTramiteEliminar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTramiteEliminar.Location = new System.Drawing.Point(90, 114);
            this.lblTramiteEliminar.Name = "lblTramiteEliminar";
            this.lblTramiteEliminar.Size = new System.Drawing.Size(125, 20);
            this.lblTramiteEliminar.TabIndex = 16;
            // 
            // lblNombreEliminar
            // 
            this.lblNombreEliminar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreEliminar.Location = new System.Drawing.Point(90, 79);
            this.lblNombreEliminar.Name = "lblNombreEliminar";
            this.lblNombreEliminar.Size = new System.Drawing.Size(125, 20);
            this.lblNombreEliminar.TabIndex = 15;
            // 
            // lblCodigoEliminar
            // 
            this.lblCodigoEliminar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigoEliminar.Location = new System.Drawing.Point(129, 43);
            this.lblCodigoEliminar.Name = "lblCodigoEliminar";
            this.lblCodigoEliminar.Size = new System.Drawing.Size(86, 20);
            this.lblCodigoEliminar.TabIndex = 14;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(126, 43);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(86, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(21, 48);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(27, 175);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(188, 32);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tramite";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(25, 175);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(188, 32);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(88, 114);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(125, 20);
            this.txtTramite.TabIndex = 5;
            // 
            // lblTrámite
            // 
            this.lblTrámite.AutoSize = true;
            this.lblTrámite.Location = new System.Drawing.Point(22, 119);
            this.lblTrámite.Name = "lblTrámite";
            this.lblTrámite.Size = new System.Drawing.Size(42, 13);
            this.lblTrámite.TabIndex = 4;
            this.lblTrámite.Text = "Tramite";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(88, 79);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(124, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 84);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // mrcEliminar
            // 
            this.mrcEliminar.Controls.Add(this.lblTramiteEliminar);
            this.mrcEliminar.Controls.Add(this.lblNombreEliminar);
            this.mrcEliminar.Controls.Add(this.lblCodigoEliminar);
            this.mrcEliminar.Controls.Add(this.btnEliminar);
            this.mrcEliminar.Controls.Add(this.label2);
            this.mrcEliminar.Controls.Add(this.label3);
            this.mrcEliminar.Controls.Add(this.label1);
            this.mrcEliminar.Location = new System.Drawing.Point(502, 11);
            this.mrcEliminar.Name = "mrcEliminar";
            this.mrcEliminar.Size = new System.Drawing.Size(234, 231);
            this.mrcEliminar.TabIndex = 7;
            this.mrcEliminar.TabStop = false;
            this.mrcEliminar.Text = "Elemento Eliminado";
            // 
            // mrcNuevoElemento
            // 
            this.mrcNuevoElemento.Controls.Add(this.btnAgregar);
            this.mrcNuevoElemento.Controls.Add(this.txtTramite);
            this.mrcNuevoElemento.Controls.Add(this.lblTrámite);
            this.mrcNuevoElemento.Controls.Add(this.txtNombre);
            this.mrcNuevoElemento.Controls.Add(this.lblNombre);
            this.mrcNuevoElemento.Controls.Add(this.txtCodigo);
            this.mrcNuevoElemento.Controls.Add(this.lblCodigo);
            this.mrcNuevoElemento.Location = new System.Drawing.Point(244, 11);
            this.mrcNuevoElemento.Name = "mrcNuevoElemento";
            this.mrcNuevoElemento.Size = new System.Drawing.Size(234, 231);
            this.mrcNuevoElemento.TabIndex = 5;
            this.mrcNuevoElemento.TabStop = false;
            this.mrcNuevoElemento.Text = "Nuevo Elemento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::pryEDPozzo.Properties.Resources._1200px_Pila_svg;
            this.pictureBox1.Location = new System.Drawing.Point(10, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 573);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvPila);
            this.Controls.Add(this.mrcListado);
            this.Controls.Add(this.mrcEliminar);
            this.Controls.Add(this.mrcNuevoElemento);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura de datos no lineales - Pila";
            this.Load += new System.EventHandler(this.frmPila_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).EndInit();
            this.mrcListado.ResumeLayout(false);
            this.mrcEliminar.ResumeLayout(false);
            this.mrcEliminar.PerformLayout();
            this.mrcNuevoElemento.ResumeLayout(false);
            this.mrcNuevoElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dgvPila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ListBox lstPila;
        private System.Windows.Forms.GroupBox mrcListado;
        private System.Windows.Forms.Label lblTramiteEliminar;
        private System.Windows.Forms.Label lblNombreEliminar;
        private System.Windows.Forms.Label lblCodigoEliminar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.Label lblTrámite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox mrcEliminar;
        private System.Windows.Forms.GroupBox mrcNuevoElemento;
    }
}