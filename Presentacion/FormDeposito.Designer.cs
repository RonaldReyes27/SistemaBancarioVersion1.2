namespace Presentacion
{
    partial class FormDeposito
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
            lblTitulo = new Label();
            cmbClientes = new ComboBox();
            pnlSaldo = new Panel();
            lblSaldoValor = new Label();
            lblSaldoTitulo = new Label();
            pnlAccion = new Panel();
            btnDepositar = new Button();
            txtMonto = new TextBox();
            lblMonto = new Label();
            pnlSaldo.SuspendLayout();
            pnlAccion.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(12, 44);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(322, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Realizar un Depósito";
            // 
            // cmbClientes
            // 
            cmbClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(12, 104);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(447, 28);
            cmbClientes.TabIndex = 1;
            cmbClientes.SelectedIndexChanged += cmbClientes_SelectedIndexChanged;
            // 
            // pnlSaldo
            // 
            pnlSaldo.BackColor = Color.FromArgb(63, 63, 70);
            pnlSaldo.Controls.Add(lblSaldoValor);
            pnlSaldo.Controls.Add(lblSaldoTitulo);
            pnlSaldo.ForeColor = Color.White;
            pnlSaldo.Location = new Point(12, 151);
            pnlSaldo.Name = "pnlSaldo";
            pnlSaldo.Size = new Size(447, 82);
            pnlSaldo.TabIndex = 2;
            // 
            // lblSaldoValor
            // 
            lblSaldoValor.AutoSize = true;
            lblSaldoValor.BackColor = Color.FromArgb(63, 63, 70);
            lblSaldoValor.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaldoValor.ForeColor = Color.White;
            lblSaldoValor.Location = new Point(13, 31);
            lblSaldoValor.Name = "lblSaldoValor";
            lblSaldoValor.Size = new Size(109, 46);
            lblSaldoValor.TabIndex = 3;
            lblSaldoValor.Text = "$0.00";
            // 
            // lblSaldoTitulo
            // 
            lblSaldoTitulo.AutoSize = true;
            lblSaldoTitulo.BackColor = Color.FromArgb(63, 63, 70);
            lblSaldoTitulo.Font = new Font("Segoe UI", 9F);
            lblSaldoTitulo.ForeColor = Color.LightGray;
            lblSaldoTitulo.Location = new Point(20, 11);
            lblSaldoTitulo.Name = "lblSaldoTitulo";
            lblSaldoTitulo.Size = new Size(93, 20);
            lblSaldoTitulo.TabIndex = 0;
            lblSaldoTitulo.Text = "Saldo Actual";
            // 
            // pnlAccion
            // 
            pnlAccion.BackColor = Color.FromArgb(63, 63, 70);
            pnlAccion.Controls.Add(btnDepositar);
            pnlAccion.Controls.Add(txtMonto);
            pnlAccion.Controls.Add(lblMonto);
            pnlAccion.Location = new Point(12, 253);
            pnlAccion.Name = "pnlAccion";
            pnlAccion.Size = new Size(447, 170);
            pnlAccion.TabIndex = 3;
            // 
            // btnDepositar
            // 
            btnDepositar.BackColor = Color.SeaGreen;
            btnDepositar.FlatStyle = FlatStyle.Flat;
            btnDepositar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDepositar.ForeColor = Color.White;
            btnDepositar.Location = new Point(50, 87);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(337, 61);
            btnDepositar.TabIndex = 4;
            btnDepositar.Text = "Confirmar Depósito";
            btnDepositar.UseVisualStyleBackColor = false;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // txtMonto
            // 
            txtMonto.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMonto.Location = new Point(13, 43);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(415, 38);
            txtMonto.TabIndex = 4;
            txtMonto.KeyPress += txtMonto_KeyPress;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.ForeColor = Color.LightGray;
            lblMonto.Location = new Point(13, 20);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(134, 20);
            lblMonto.TabIndex = 4;
            lblMonto.Text = "Monto a Depositar";
            // 
            // FormDeposito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 37, 38);
            ClientSize = new Size(480, 496);
            Controls.Add(pnlAccion);
            Controls.Add(pnlSaldo);
            Controls.Add(cmbClientes);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDeposito";
            Text = "FormDeposito";
            Load += FormDeposito_Load;
            pnlSaldo.ResumeLayout(false);
            pnlSaldo.PerformLayout();
            pnlAccion.ResumeLayout(false);
            pnlAccion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private ComboBox cmbClientes;
        private Panel pnlSaldo;
        private Label lblSaldoValor;
        private Label lblSaldoTitulo;
        private Panel pnlAccion;
        private Label lblMonto;
        private Button btnDepositar;
        private TextBox txtMonto;
    }
}