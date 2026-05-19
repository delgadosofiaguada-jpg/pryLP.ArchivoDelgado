namespace pryLP.ArchivoDelgado
{
    partial class frmListadoOrdenadoClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoOrdenadoClientes));
            this.dgvListar = new System.Windows.Forms.DataGridView();
            this.clCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbLimite = new System.Windows.Forms.RadioButton();
            this.rbDeuda = new System.Windows.Forms.RadioButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListar
            // 
            this.dgvListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCodigo,
            this.clUsuario,
            this.clLimite,
            this.clDeuda});
            this.dgvListar.Location = new System.Drawing.Point(10, 200);
            this.dgvListar.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListar.Name = "dgvListar";
            this.dgvListar.RowHeadersWidth = 51;
            this.dgvListar.Size = new System.Drawing.Size(777, 267);
            this.dgvListar.TabIndex = 1;
            // 
            // clCodigo
            // 
            this.clCodigo.HeaderText = "Código";
            this.clCodigo.MinimumWidth = 6;
            this.clCodigo.Name = "clCodigo";
            this.clCodigo.Width = 120;
            // 
            // clUsuario
            // 
            this.clUsuario.HeaderText = "Usuario";
            this.clUsuario.MinimumWidth = 6;
            this.clUsuario.Name = "clUsuario";
            this.clUsuario.Width = 160;
            // 
            // clLimite
            // 
            this.clLimite.HeaderText = "Limite";
            this.clLimite.MinimumWidth = 6;
            this.clLimite.Name = "clLimite";
            this.clLimite.Width = 160;
            // 
            // clDeuda
            // 
            this.clDeuda.HeaderText = "Deuda";
            this.clDeuda.MinimumWidth = 6;
            this.clDeuda.Name = "clDeuda";
            this.clDeuda.Width = 125;
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCodigo.Location = new System.Drawing.Point(13, 61);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(161, 22);
            this.rbCodigo.TabIndex = 2;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Ordenar por Código";
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // rbLimite
            // 
            this.rbLimite.AutoSize = true;
            this.rbLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLimite.Location = new System.Drawing.Point(13, 106);
            this.rbLimite.Name = "rbLimite";
            this.rbLimite.Size = new System.Drawing.Size(152, 22);
            this.rbLimite.TabIndex = 3;
            this.rbLimite.TabStop = true;
            this.rbLimite.Text = "Ordenar por Límite";
            this.rbLimite.UseVisualStyleBackColor = true;
            // 
            // rbDeuda
            // 
            this.rbDeuda.AutoSize = true;
            this.rbDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDeuda.Location = new System.Drawing.Point(13, 146);
            this.rbDeuda.Name = "rbDeuda";
            this.rbDeuda.Size = new System.Drawing.Size(156, 22);
            this.rbDeuda.TabIndex = 4;
            this.rbDeuda.TabStop = true;
            this.rbDeuda.Text = "Ordenar por Deuda";
            this.rbDeuda.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(10, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(416, 18);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Seleccione como desea ordenar el listado de clientes:";
            // 
            // frmListadoOrdenadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.rbDeuda);
            this.Controls.Add(this.rbLimite);
            this.Controls.Add(this.rbCodigo);
            this.Controls.Add(this.dgvListar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListadoOrdenadoClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Ordenado de los clientes";
            this.Load += new System.EventHandler(this.frmListadoOrdenadoClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDeuda;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbLimite;
        private System.Windows.Forms.RadioButton rbDeuda;
        private System.Windows.Forms.Label lblTitulo;
    }
}