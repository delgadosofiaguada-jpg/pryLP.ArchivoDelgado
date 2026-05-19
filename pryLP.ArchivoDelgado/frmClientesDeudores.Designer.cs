namespace pryLP.ArchivoDelgado
{
    partial class frmClientesDeudores
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
            this.gbClientesDeudores = new System.Windows.Forms.GroupBox();
            this.lblProm = new System.Windows.Forms.Label();
            this.lblCantC = new System.Windows.Forms.Label();
            this.lblTot = new System.Windows.Forms.Label();
            this.lblPromedioDeuda = new System.Windows.Forms.Label();
            this.lblCantidadClientes = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvConsultaDatos = new System.Windows.Forms.DataGridView();
            this.clCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbClientesDeudores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbClientesDeudores
            // 
            this.gbClientesDeudores.Controls.Add(this.lblProm);
            this.gbClientesDeudores.Controls.Add(this.lblCantC);
            this.gbClientesDeudores.Controls.Add(this.lblTot);
            this.gbClientesDeudores.Controls.Add(this.lblPromedioDeuda);
            this.gbClientesDeudores.Controls.Add(this.lblCantidadClientes);
            this.gbClientesDeudores.Controls.Add(this.lblTotal);
            this.gbClientesDeudores.Controls.Add(this.dgvConsultaDatos);
            this.gbClientesDeudores.Location = new System.Drawing.Point(16, 30);
            this.gbClientesDeudores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbClientesDeudores.Name = "gbClientesDeudores";
            this.gbClientesDeudores.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbClientesDeudores.Size = new System.Drawing.Size(813, 474);
            this.gbClientesDeudores.TabIndex = 2;
            this.gbClientesDeudores.TabStop = false;
            this.gbClientesDeudores.Text = "Clientes deudores";
            this.gbClientesDeudores.Enter += new System.EventHandler(this.gbClientesDeudores_Enter);
            // 
            // lblProm
            // 
            this.lblProm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProm.Location = new System.Drawing.Point(632, 430);
            this.lblProm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProm.Name = "lblProm";
            this.lblProm.Size = new System.Drawing.Size(149, 26);
            this.lblProm.TabIndex = 6;
            this.lblProm.Visible = true;
            // 
            // lblCantC
            // 
            this.lblCantC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantC.Location = new System.Drawing.Point(632, 377);
            this.lblCantC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantC.Name = "lblCantC";
            this.lblCantC.Size = new System.Drawing.Size(149, 26);
            this.lblCantC.TabIndex = 5;
            this.lblCantC.Visible = true;
            // 
            // lblTot
            // 
            this.lblTot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTot.Location = new System.Drawing.Point(632, 334);
            this.lblTot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(149, 26);
            this.lblTot.TabIndex = 4;
            this.lblTot.Visible = true;
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
            // dgvConsultaDatos
            // 
            this.dgvConsultaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCodigo,
            this.clUsuario,
            this.clLimite,
            this.clDeuda});
            this.dgvConsultaDatos.Location = new System.Drawing.Point(25, 44);
            this.dgvConsultaDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // frmClientesDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 526);
            this.Controls.Add(this.gbClientesDeudores);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmClientesDeudores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClientesDeudore";
            this.Load += new System.EventHandler(this.frmClientesDeudore_Load);
            this.gbClientesDeudores.ResumeLayout(false);
            this.gbClientesDeudores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbClientesDeudores;
        private System.Windows.Forms.Label lblProm;
        private System.Windows.Forms.Label lblCantC;
        private System.Windows.Forms.Label lblTot;
        private System.Windows.Forms.Label lblPromedioDeuda;
        private System.Windows.Forms.Label lblCantidadClientes;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvConsultaDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDeuda;
    }
}