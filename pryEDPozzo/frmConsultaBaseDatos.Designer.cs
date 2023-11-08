namespace pryEDPozzo
{
    partial class frmConsultaBaseDatos
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtInstruccion = new System.Windows.Forms.TextBox();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(152, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CONSULTA";
            // 
            // txtInstruccion
            // 
            this.txtInstruccion.Location = new System.Drawing.Point(15, 63);
            this.txtInstruccion.Multiline = true;
            this.txtInstruccion.Name = "txtInstruccion";
            this.txtInstruccion.Size = new System.Drawing.Size(773, 101);
            this.txtInstruccion.TabIndex = 1;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(15, 199);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.Size = new System.Drawing.Size(773, 229);
            this.dgvConsulta.TabIndex = 2;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(713, 170);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // frmConsultaBaseDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.txtInstruccion);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmConsultaBaseDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta a Base de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtInstruccion;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Button btnListar;
    }
}