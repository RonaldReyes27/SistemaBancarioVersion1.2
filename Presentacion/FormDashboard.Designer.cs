namespace Presentacion
{
    partial class FormDashboard
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblSaludo = new Label();
            lblFechaHora = new Label();
            timerFechaHora = new System.Windows.Forms.Timer(components);
            pnlSaldoTotal = new Panel();
            lblSaldoTotalTitulo = new Label();
            lblSaldoTotalValor = new Label();
            lblAccesosRapidos = new Label();
            btnAgregarCliente = new Button();
            btnDeposito = new Button();
            btnRetiro = new Button();
            pnlTotalClientes = new Panel();
            lblTotalClientesValor = new Label();
            lblTituloTotalClientes = new Label();
            lblUltimosClientes = new Label();
            dgvUltimosClientes = new DataGridView();
            pnlSaldoTotal.SuspendLayout();
            pnlTotalClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUltimosClientes).BeginInit();
            SuspendLayout();
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = true;
            lblSaludo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaludo.Location = new Point(143, 9);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(469, 41);
            lblSaludo.TabIndex = 0;
            lblSaludo.Text = "Bienvenido al Centro de Control";
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.ForeColor = Color.LightGray;
            lblFechaHora.Location = new Point(12, 559);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(123, 20);
            lblFechaHora.TabIndex = 1;
            lblFechaHora.Text = "Cargando fecha...";
            // 
            // timerFechaHora
            // 
            timerFechaHora.Enabled = true;
            timerFechaHora.Interval = 1000;
            // 
            // pnlSaldoTotal
            // 
            pnlSaldoTotal.BackColor = Color.FromArgb(63, 63, 70);
            pnlSaldoTotal.Controls.Add(lblSaldoTotalValor);
            pnlSaldoTotal.Controls.Add(lblSaldoTotalTitulo);
            pnlSaldoTotal.Location = new Point(421, 353);
            pnlSaldoTotal.Name = "pnlSaldoTotal";
            pnlSaldoTotal.Size = new Size(353, 83);
            pnlSaldoTotal.TabIndex = 2;
            // 
            // lblSaldoTotalTitulo
            // 
            lblSaldoTotalTitulo.AutoSize = true;
            lblSaldoTotalTitulo.Location = new Point(3, 11);
            lblSaldoTotalTitulo.Name = "lblSaldoTotalTitulo";
            lblSaldoTotalTitulo.Size = new Size(173, 20);
            lblSaldoTotalTitulo.TabIndex = 3;
            lblSaldoTotalTitulo.Text = "Capital Total Gestionado";
            // 
            // lblSaldoTotalValor
            // 
            lblSaldoTotalValor.AutoSize = true;
            lblSaldoTotalValor.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaldoTotalValor.Location = new Point(3, 31);
            lblSaldoTotalValor.Name = "lblSaldoTotalValor";
            lblSaldoTotalValor.Size = new Size(116, 50);
            lblSaldoTotalValor.TabIndex = 3;
            lblSaldoTotalValor.Text = "$0.00";
            // 
            // lblAccesosRapidos
            // 
            lblAccesosRapidos.AutoSize = true;
            lblAccesosRapidos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccesosRapidos.Location = new Point(12, 114);
            lblAccesosRapidos.Name = "lblAccesosRapidos";
            lblAccesosRapidos.Size = new Size(168, 28);
            lblAccesosRapidos.TabIndex = 3;
            lblAccesosRapidos.Text = "Accesos Rápidos";
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.BackColor = Color.DodgerBlue;
            btnAgregarCliente.FlatStyle = FlatStyle.Flat;
            btnAgregarCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarCliente.Location = new Point(12, 161);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(145, 34);
            btnAgregarCliente.TabIndex = 4;
            btnAgregarCliente.Text = "Agregar Cliente";
            btnAgregarCliente.UseVisualStyleBackColor = false;
            // 
            // btnDeposito
            // 
            btnDeposito.BackColor = Color.SeaGreen;
            btnDeposito.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeposito.Location = new Point(186, 161);
            btnDeposito.Name = "btnDeposito";
            btnDeposito.Size = new Size(121, 34);
            btnDeposito.TabIndex = 5;
            btnDeposito.Text = "Depósito";
            btnDeposito.UseVisualStyleBackColor = false;
            // 
            // btnRetiro
            // 
            btnRetiro.BackColor = Color.Crimson;
            btnRetiro.FlatStyle = FlatStyle.Flat;
            btnRetiro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRetiro.Location = new Point(323, 161);
            btnRetiro.Name = "btnRetiro";
            btnRetiro.Size = new Size(121, 34);
            btnRetiro.TabIndex = 6;
            btnRetiro.Text = "Retiro";
            btnRetiro.UseVisualStyleBackColor = false;
            // 
            // pnlTotalClientes
            // 
            pnlTotalClientes.BackColor = Color.FromArgb(63, 63, 70);
            pnlTotalClientes.Controls.Add(lblTotalClientesValor);
            pnlTotalClientes.Controls.Add(lblTituloTotalClientes);
            pnlTotalClientes.Location = new Point(418, 238);
            pnlTotalClientes.Name = "pnlTotalClientes";
            pnlTotalClientes.Size = new Size(142, 85);
            pnlTotalClientes.TabIndex = 4;
            // 
            // lblTotalClientesValor
            // 
            lblTotalClientesValor.AutoSize = true;
            lblTotalClientesValor.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalClientesValor.Location = new Point(3, 31);
            lblTotalClientesValor.Name = "lblTotalClientesValor";
            lblTotalClientesValor.Size = new Size(43, 50);
            lblTotalClientesValor.TabIndex = 3;
            lblTotalClientesValor.Text = "0";
            // 
            // lblTituloTotalClientes
            // 
            lblTituloTotalClientes.AutoSize = true;
            lblTituloTotalClientes.Location = new Point(3, 11);
            lblTituloTotalClientes.Name = "lblTituloTotalClientes";
            lblTituloTotalClientes.Size = new Size(119, 20);
            lblTituloTotalClientes.TabIndex = 3;
            lblTituloTotalClientes.Text = "Total de Clientes";
            // 
            // lblUltimosClientes
            // 
            lblUltimosClientes.AutoSize = true;
            lblUltimosClientes.Location = new Point(12, 215);
            lblUltimosClientes.Name = "lblUltimosClientes";
            lblUltimosClientes.Size = new Size(198, 20);
            lblUltimosClientes.TabIndex = 7;
            lblUltimosClientes.Text = "Últimos Clientes Registrados";
            //lblUltimosClientes.Click += this.lblUltimosClientes_Click;
            // 
            // dgvUltimosClientes
            // 
            dgvUltimosClientes.BackgroundColor = Color.FromArgb(45, 45, 48);
            dgvUltimosClientes.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvUltimosClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvUltimosClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(63, 63, 70);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvUltimosClientes.DefaultCellStyle = dataGridViewCellStyle4;
            dgvUltimosClientes.Location = new Point(12, 238);
            dgvUltimosClientes.Name = "dgvUltimosClientes";
            dgvUltimosClientes.RowHeadersVisible = false;
            dgvUltimosClientes.RowHeadersWidth = 51;
            dgvUltimosClientes.Size = new Size(380, 297);
            dgvUltimosClientes.TabIndex = 8;
           // dgvUltimosClientes.CellContentClick += this.dgvUltimosClientes_CellContentClick;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 37, 38);
            ClientSize = new Size(797, 588);
            Controls.Add(dgvUltimosClientes);
            Controls.Add(lblUltimosClientes);
            Controls.Add(pnlTotalClientes);
            Controls.Add(btnRetiro);
            Controls.Add(btnDeposito);
            Controls.Add(btnAgregarCliente);
            Controls.Add(lblAccesosRapidos);
            Controls.Add(pnlSaldoTotal);
            Controls.Add(lblFechaHora);
            Controls.Add(lblSaludo);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDashboard";
            Text = "FormDashboard";
            Load += FormDashboard_Load;
            pnlSaldoTotal.ResumeLayout(false);
            pnlSaldoTotal.PerformLayout();
            pnlTotalClientes.ResumeLayout(false);
            pnlTotalClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUltimosClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSaludo;
        private Label lblFechaHora;
        private System.Windows.Forms.Timer timerFechaHora;
        private Panel pnlSaldoTotal;
        private Label lblSaldoTotalTitulo;
        private Label lblSaldoTotalValor;
        private Label lblAccesosRapidos;
        private Button btnAgregarCliente;
        private Button btnDeposito;
        private Button btnRetiro;
        private Panel pnlTotalClientes;
        private Label lblTotalClientesValor;
        private Label lblTituloTotalClientes;
        private Label lblUltimosClientes;
        private DataGridView dgvUltimosClientes;
    }
}