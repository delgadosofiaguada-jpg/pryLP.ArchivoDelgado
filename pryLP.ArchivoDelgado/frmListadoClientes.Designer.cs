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
            this.dgvConsultaDatos = new System.Windows.Forms.DataGridView();
            this.clCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbConsultaDatos = new System.Windows.Forms.GroupBox();
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
            this.dgvConsultaDatos.Location = new System.Drawing.Point(19, 51);
            this.dgvConsultaDatos.Name = "dgvConsultaDatos";
            this.dgvConsultaDatos.Size = new System.Drawing.Size(583, 217);
            this.dgvConsultaDatos.TabIndex = 0;
            // 
            // clCodigo
            // 
            this.clCodigo.HeaderText = "Código";
            this.clCodigo.Name = "clCodigo";
            this.clCodigo.Width = 120;
            // 
            // clUsuario
            // 
            this.clUsuario.HeaderText = "Usuario";
            this.clUsuario.Name = "clUsuario";
            this.clUsuario.Width = 160;
            // 
            // clLimite
            // 
            this.clLimite.HeaderText = "Limite";
            this.clLimite.Name = "clLimite";
            this.clLimite.Width = 160;
            // 
            // clDeuda
            // 
            this.clDeuda.HeaderText = "Deuda";
            this.clDeuda.Name = "clDeuda";
            // 
            // gbConsultaDatos
            // 
            this.gbConsultaDatos.Controls.Add(this.cmdReporte);
            this.gbConsultaDatos.Controls.Add(this.lblProm);
            this.gbConsultaDatos.Controls.Add(this.lblCantC);
            this.gbConsultaDatos.Controls.Add(this.lblTot);
            this.gbConsultaDatos.Controls.Add(this.lblPromedioDeuda);
            this.gbConsultaDatos.Controls.Add(this.lblCantidadClientes);
            this.gbConsultaDatos.Controls.Add(this.lblTotal);
            this.gbConsultaDatos.Controls.Add(this.dgvConsultaDatos);
            this.gbConsultaDatos.Location = new System.Drawing.Point(13, 13);
            this.gbConsultaDatos.Name = "gbConsultaDatos";
            this.gbConsultaDatos.Size = new System.Drawing.Size(610, 385);
            this.gbConsultaDatos.TabIndex = 1;
            this.gbConsultaDatos.TabStop = false;
            this.gbConsultaDatos.Text = "Consulta de datos";
            this.gbConsultaDatos.Enter += new System.EventHandler(this.gbConsultaDatos_Enter);
            // 
            // cmdReporte
            // 
            this.cmdReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReporte.Location = new System.Drawing.Point(19, 340);
            this.cmdReporte.Name = "cmdReporte";
            this.cmdReporte.Size = new System.Drawing.Size(75, 30);
            this.cmdReporte.TabIndex = 7;
            this.cmdReporte.Text = "Reporte";
            this.cmdReporte.UseVisualStyleBackColor = true;
            this.cmdReporte.Click += new System.EventHandler(this.cmdReporte_Click);
            // 
            // lblProm
            // 
            this.lblProm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProm.Location = new System.Drawing.Point(474, 349);
            this.lblProm.Name = "lblProm";
            this.lblProm.Size = new System.Drawing.Size(112, 21);
            this.lblProm.TabIndex = 6;
            this.lblProm.Visible = false;
            // 
            // lblCantC
            // 
            this.lblCantC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantC.Location = new System.Drawing.Point(474, 306);
            this.lblCantC.Name = "lblCantC";
            this.lblCantC.Size = new System.Drawing.Size(112, 21);
            this.lblCantC.TabIndex = 5;
            this.lblCantC.Visible = false;
            // 
            // lblTot
            // 
            this.lblTot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTot.Location = new System.Drawing.Point(474, 271);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(112, 21);
            this.lblTot.TabIndex = 4;
            this.lblTot.Visible = false;
            this.lblTot.Click += new System.EventHandler(this.lblTot_Click);
            // 
            // lblPromedioDeuda
            // 
            this.lblPromedioDeuda.AutoSize = true;
            this.lblPromedioDeuda.Location = new System.Drawing.Point(367, 357);
            this.lblPromedioDeuda.Name = "lblPromedioDeuda";
            this.lblPromedioDeuda.Size = new System.Drawing.Size(102, 13);
            this.lblPromedioDeuda.TabIndex = 3;
            this.lblPromedioDeuda.Text = "Promedio de deuda:";
            // 
            // lblCantidadClientes
            // 
            this.lblCantidadClientes.AutoSize = true;
            this.lblCantidadClientes.Location = new System.Drawing.Point(367, 314);
            this.lblCantidadClientes.Name = "lblCantidadClientes";
            this.lblCantidadClientes.Size = new System.Drawing.Size(91, 13);
            this.lblCantidadClientes.TabIndex = 2;
            this.lblCantidadClientes.Text = "Cantidad clientes:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(367, 279);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(67, 13);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total deuda:";
            // 
            // frmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 410);
            this.Controls.Add(this.gbConsultaDatos);
            this.Name = "frmListadoClientes";
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
    }
}