namespace Presentacion
{
    partial class FormTransaccion
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
            pnlOrigen = new Panel();
            lblSaldoOrigen = new Label();
            cmbCuentaOrigen = new ComboBox();
            lblSaldoTitulo = new Label();
            lblTitulo = new Label();
            pnlMonto = new Panel();
            btnDepositar = new Button();
            txtMonto = new TextBox();
            lblMonto = new Label();
            pnlDestino = new Panel();
            lblSaldoDestino = new Label();
            cmbCuentaDestino = new ComboBox();
            lblDestinoTitulo = new Label();
            pnlOrigen.SuspendLayout();
            pnlMonto.SuspendLayout();
            pnlDestino.SuspendLayout();
            SuspendLayout();
            // 
            // pnlOrigen
            // 
            pnlOrigen.BackColor = Color.FromArgb(63, 63, 70);
            pnlOrigen.Controls.Add(lblSaldoOrigen);
            pnlOrigen.Controls.Add(cmbCuentaOrigen);
            pnlOrigen.Controls.Add(lblSaldoTitulo);
            pnlOrigen.ForeColor = Color.White;
            pnlOrigen.Location = new Point(21, 82);
            pnlOrigen.Name = "pnlOrigen";
            pnlOrigen.Size = new Size(492, 120);
            pnlOrigen.TabIndex = 6;
            // 
            // lblSaldoOrigen
            // 
            lblSaldoOrigen.AutoSize = true;
            lblSaldoOrigen.BackColor = Color.FromArgb(63, 63, 70);
            lblSaldoOrigen.Font = new Font("Segoe UI", 9F);
            lblSaldoOrigen.ForeColor = Color.LightGray;
            lblSaldoOrigen.Location = new Point(20, 82);
            lblSaldoOrigen.Name = "lblSaldoOrigen";
            lblSaldoOrigen.Size = new Size(163, 20);
            lblSaldoOrigen.TabIndex = 8;
            lblSaldoOrigen.Text = "Saldo disponible: $0.00";
            // 
            // cmbCuentaOrigen
            // 
            cmbCuentaOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCuentaOrigen.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCuentaOrigen.FormattingEnabled = true;
            cmbCuentaOrigen.Location = new Point(20, 46);
            cmbCuentaOrigen.Name = "cmbCuentaOrigen";
            cmbCuentaOrigen.Size = new Size(447, 33);
            cmbCuentaOrigen.TabIndex = 5;
            cmbCuentaOrigen.SelectedIndexChanged += cmbCuentaOrigen_SelectedIndexChanged;
            // 
            // lblSaldoTitulo
            // 
            lblSaldoTitulo.AutoSize = true;
            lblSaldoTitulo.BackColor = Color.FromArgb(63, 63, 70);
            lblSaldoTitulo.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaldoTitulo.ForeColor = Color.LightGray;
            lblSaldoTitulo.Location = new Point(20, 23);
            lblSaldoTitulo.Name = "lblSaldoTitulo";
            lblSaldoTitulo.Size = new Size(131, 17);
            lblSaldoTitulo.TabIndex = 0;
            lblSaldoTitulo.Text = "CUENTA DE ORIGEN";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(76, 26);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(345, 41);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Realizar Transferencia";
            // 
            // pnlMonto
            // 
            pnlMonto.BackColor = Color.FromArgb(63, 63, 70);
            pnlMonto.Controls.Add(btnDepositar);
            pnlMonto.Controls.Add(txtMonto);
            pnlMonto.Controls.Add(lblMonto);
            pnlMonto.Location = new Point(21, 345);
            pnlMonto.Name = "pnlMonto";
            pnlMonto.Size = new Size(492, 170);
            pnlMonto.TabIndex = 7;
            // 
            // btnDepositar
            // 
            btnDepositar.BackColor = Color.DodgerBlue;
            btnDepositar.FlatStyle = FlatStyle.Flat;
            btnDepositar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDepositar.ForeColor = Color.White;
            btnDepositar.Location = new Point(72, 87);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(337, 61);
            btnDepositar.TabIndex = 4;
            btnDepositar.Text = "Confirmar Transferencia";
            btnDepositar.UseVisualStyleBackColor = false;
            btnDepositar.Click += btnTransferir_Click;
            // 
            // txtMonto
            // 
            txtMonto.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMonto.Location = new Point(23, 43);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(442, 38);
            txtMonto.TabIndex = 4;
            txtMonto.KeyPress += txtMonto_KeyPress;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.ForeColor = Color.LightGray;
            lblMonto.Location = new Point(23, 20);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(130, 20);
            lblMonto.TabIndex = 4;
            lblMonto.Text = "Monto a Transferir";
            // 
            // pnlDestino
            // 
            pnlDestino.BackColor = Color.FromArgb(63, 63, 70);
            pnlDestino.Controls.Add(lblSaldoDestino);
            pnlDestino.Controls.Add(cmbCuentaDestino);
            pnlDestino.Controls.Add(lblDestinoTitulo);
            pnlDestino.ForeColor = Color.White;
            pnlDestino.Location = new Point(21, 219);
            pnlDestino.Name = "pnlDestino";
            pnlDestino.Size = new Size(492, 120);
            pnlDestino.TabIndex = 8;
            // 
            // lblSaldoDestino
            // 
            lblSaldoDestino.AutoSize = true;
            lblSaldoDestino.BackColor = Color.FromArgb(63, 63, 70);
            lblSaldoDestino.Font = new Font("Segoe UI", 9F);
            lblSaldoDestino.ForeColor = Color.LightGray;
            lblSaldoDestino.Location = new Point(20, 82);
            lblSaldoDestino.Name = "lblSaldoDestino";
            lblSaldoDestino.Size = new Size(133, 20);
            lblSaldoDestino.TabIndex = 8;
            lblSaldoDestino.Text = "Saldo actual: $0.00";
            // 
            // cmbCuentaDestino
            // 
            cmbCuentaDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCuentaDestino.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCuentaDestino.FormattingEnabled = true;
            cmbCuentaDestino.Location = new Point(20, 46);
            cmbCuentaDestino.Name = "cmbCuentaDestino";
            cmbCuentaDestino.Size = new Size(447, 33);
            cmbCuentaDestino.TabIndex = 5;
            cmbCuentaDestino.SelectedIndexChanged += cmbCuentaDestino_SelectedIndexChanged;
            // 
            // lblDestinoTitulo
            // 
            lblDestinoTitulo.AutoSize = true;
            lblDestinoTitulo.BackColor = Color.FromArgb(63, 63, 70);
            lblDestinoTitulo.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDestinoTitulo.ForeColor = Color.LightGray;
            lblDestinoTitulo.Location = new Point(20, 23);
            lblDestinoTitulo.Name = "lblDestinoTitulo";
            lblDestinoTitulo.Size = new Size(139, 17);
            lblDestinoTitulo.TabIndex = 0;
            lblDestinoTitulo.Text = "CUENTA DE DESTINO";
            // 
            // FormTransaccion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 37, 38);
            ClientSize = new Size(541, 593);
            Controls.Add(pnlDestino);
            Controls.Add(pnlOrigen);
            Controls.Add(lblTitulo);
            Controls.Add(pnlMonto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTransaccion";
            Text = "FormTransaccion";
            Load += FormTransaccion_Load;
            pnlOrigen.ResumeLayout(false);
            pnlOrigen.PerformLayout();
            pnlMonto.ResumeLayout(false);
            pnlMonto.PerformLayout();
            pnlDestino.ResumeLayout(false);
            pnlDestino.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlOrigen;
        private Label lblSaldoOrigen;
        private ComboBox cmbCuentaOrigen;
        private Label lblSaldoTitulo;
        private Label lblTitulo;
        private Panel pnlMonto;
        private Button btnDepositar;
        private TextBox txtMonto;
        private Label lblMonto;
        private Panel pnlDestino;
        private Label lblSaldoDestino;
        private ComboBox cmbCuentaDestino;
        private Label lblDestinoTitulo;
    }
}