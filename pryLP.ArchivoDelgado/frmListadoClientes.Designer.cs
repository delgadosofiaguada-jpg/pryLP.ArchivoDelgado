namespace pryLP.ArchivoDelgado
{
    partial class frmListadoClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoClientes));
            this.dgvConsultaDatos = new System.Windows.Forms.DataGridView();
            this.clCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbConsultaDatos = new System.Windows.Forms.GroupBox();
            this.cmdOrdenar = new System.Windows.Forms.Button();
            this.cmdReporte = new System.Windows.Forms.Button();
            this.lblProm = new System.Windows.Forms.Label();
            this.lblCantC = new System.Windows.Forms.Label();
            this.lblTot = new System.Windows.Forms.Label();
            this.lblPromedioDeuda = new System.Windows.Forms.Label();
            this.lblCantidadClientes = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaDatos)).BeginInit();
            this.gbConsultaDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsultaDatos
            // 
            this.dgvConsultaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCodigo,
            this.clUsuario,
            this.clLimite,
            this.clDeuda});
            this.dgvConsultaDatos.Location = new System.Drawing.Point(25, 63);
            this.dgvConsultaDatos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvConsultaDatos.Name = "dgvConsultaDatos";
            this.dgvConsultaDatos.RowHeadersWidth = 51;
            this.dgvConsultaDatos.Size = new System.Drawing.Size(777, 267);
            this.dgvConsultaDatos.TabIndex = 0;
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
            // gbConsultaDatos
            // 
            this.gbConsultaDatos.Controls.Add(this.cmdOrdenar);
            this.gbConsultaDatos.Controls.Add(this.cmdReporte);
            this.gbConsultaDatos.Controls.Add(this.lblProm);
            this.gbConsultaDatos.Controls.Add(this.lblCantC);
            this.gbConsultaDatos.Controls.Add(this.lblTot);
            this.gbConsultaDatos.Controls.Add(this.lblPromedioDeuda);
            this.gbConsultaDatos.Controls.Add(this.lblCantidadClientes);
            this.gbConsultaDatos.Controls.Add(this.lblTotal);
            this.gbConsultaDatos.Controls.Add(this.dgvConsultaDatos);
            this.gbConsultaDatos.Location = new System.Drawing.Point(17, 16);
            this.gbConsultaDatos.Margin = new System.Windows.Forms.Padding(4);
            this.gbConsultaDatos.Name = "gbConsultaDatos";
            this.gbConsultaDatos.Padding = new System.Windows.Forms.Padding(4);
            this.gbConsultaDatos.Size = new System.Drawing.Size(813, 474);
            this.gbConsultaDatos.TabIndex = 1;
            this.gbConsultaDatos.TabStop = false;
            this.gbConsultaDatos.Text = "Consulta de datos";
            this.gbConsultaDatos.Enter += new System.EventHandler(this.gbConsultaDatos_Enter);
            // 
            // cmdOrdenar
            // 
            this.cmdOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOrdenar.Location = new System.Drawing.Point(171, 418);
            this.cmdOrdenar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdOrdenar.Name = "cmdOrdenar";
            this.cmdOrdenar.Size = new System.Drawing.Size(100, 37);
            this.cmdOrdenar.TabIndex = 8;
            this.cmdOrdenar.Text = "Ordenar";
            this.cmdOrdenar.UseVisualStyleBackColor = true;
            this.cmdOrdenar.Click += new System.EventHandler(this.cmdOrdenar_Click);
            // 
            // cmdReporte
            // 
            this.cmdReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReporte.Location = new System.Drawing.Point(25, 418);
            this.cmdReporte.Margin = new System.Windows.Forms.Padding(4);
            this.cmdReporte.Name = "cmdReporte";
            this.cmdReporte.Size = new System.Drawing.Size(100, 37);
            this.cmdReporte.TabIndex = 7;
            this.cmdReporte.Text = "Reporte";
            this.cmdReporte.UseVisualStyleBackColor = true;
            this.cmdReporte.Click += new System.EventHandler(this.cmdReporte_Click);
            // 
            // lblProm
            // 
            this.lblProm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProm.Location = new System.Drawing.Point(632, 430);
            this.lblProm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProm.Name = "lblProm";
            this.lblProm.Size = new System.Drawing.Size(149, 26);
            this.lblProm.TabIndex = 6;
            // 
            // lblCantC
            // 
            this.lblCantC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantC.Location = new System.Drawing.Point(632, 377);
            this.lblCantC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantC.Name = "lblCantC";
            this.lblCantC.Size = new System.Drawing.Size(149, 26);
            this.lblCantC.TabIndex = 5;
            // 
            // lblTot
            // 
            this.lblTot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTot.Location = new System.Drawing.Point(632, 334);
            this.lblTot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(149, 26);
            this.lblTot.TabIndex = 4;
            this.lblTot.Click += new System.EventHandler(this.lblTot_Click);
            // 
            // lblPromedioDeuda
            // 
            this.lblPromedioDeuda.AutoSize = true;
            this.lblPromedioDeuda.Location = new System.Drawing.Point(489, 439);
            this.lblPromedioDeuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromedioDeuda.Name = "lblPromedioDeuda";
            this.lblPromedioDeuda.Size = new System.Drawing.Size(130, 16);
            this.lblPromedioDeuda.TabIndex = 3;
            this.lblPromedioDeuda.Text = "Promedio de deuda:";
            // 
            // lblCantidadClientes
            // 
            this.lblCantidadClientes.AutoSize = true;
            this.lblCantidadClientes.Location = new System.Drawing.Point(489, 386);
            this.lblCantidadClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadClientes.Name = "lblCantidadClientes";
            this.lblCantidadClientes.Size = new System.Drawing.Size(113, 16);
            this.lblCantidadClientes.TabIndex = 2;
            this.lblCantidadClientes.Text = "Cantidad clientes:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(489, 343);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(83, 16);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total deuda:";
            // 
            // frmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 505);
            this.Controls.Add(this.gbConsultaDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListadoClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListadoClientes";
            this.Load += new System.EventHandler(this.frmListadoClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaDatos)).EndInit();
            this.gbConsultaDatos.ResumeLayout(false);
            this.gbConsultaDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDeuda;
        private System.Windows.Forms.GroupBox gbConsultaDatos;
        private System.Windows.Forms.Label lblCantidadClientes;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblProm;
        private System.Windows.Forms.Label lblCantC;
        private System.Windows.Forms.Label lblTot;
        private System.Windows.Forms.Label lblPromedioDeuda;
        private System.Windows.Forms.Button cmdReporte;
        private System.Windows.Forms.Button cmdOrdenar;
    }
}