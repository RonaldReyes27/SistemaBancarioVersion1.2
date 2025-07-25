﻿namespace Presentacion
{
    partial class FormRetiro
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
            pnlSaldo = new Panel();
            lblSaldoValor = new Label();
            lblSaldoTitulo = new Label();
            cmbClientes = new ComboBox();
            lblTitulo = new Label();
            pnlAccion = new Panel();
            btnRetirar = new Button();
            txtMonto = new TextBox();
            lblMonto = new Label();
            pnlSaldo.SuspendLayout();
            pnlAccion.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSaldo
            // 
            pnlSaldo.BackColor = Color.FromArgb(63, 63, 70);
            pnlSaldo.Controls.Add(lblSaldoValor);
            pnlSaldo.Controls.Add(lblSaldoTitulo);
            pnlSaldo.ForeColor = Color.White;
            pnlSaldo.Location = new Point(12, 135);
            pnlSaldo.Name = "pnlSaldo";
            pnlSaldo.Size = new Size(447, 82);
            pnlSaldo.TabIndex = 6;
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
            // cmbClientes
            // 
            cmbClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(12, 88);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(447, 28);
            cmbClientes.TabIndex = 5;
            cmbClientes.SelectedIndexChanged += cmbClientes_SelectedIndexChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(12, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(280, 41);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Realizar un Retiro";
            // 
            // pnlAccion
            // 
            pnlAccion.BackColor = Color.FromArgb(63, 63, 70);
            pnlAccion.Controls.Add(btnRetirar);
            pnlAccion.Controls.Add(txtMonto);
            pnlAccion.Controls.Add(lblMonto);
            pnlAccion.Location = new Point(12, 237);
            pnlAccion.Name = "pnlAccion";
            pnlAccion.Size = new Size(447, 170);
            pnlAccion.TabIndex = 7;
            // 
            // btnRetirar
            // 
            btnRetirar.BackColor = Color.Crimson;
            btnRetirar.FlatStyle = FlatStyle.Flat;
            btnRetirar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRetirar.ForeColor = Color.White;
            btnRetirar.Location = new Point(50, 87);
            btnRetirar.Name = "btnRetirar";
            btnRetirar.Size = new Size(337, 61);
            btnRetirar.TabIndex = 4;
            btnRetirar.Text = "Confirmar Retiro";
            btnRetirar.UseVisualStyleBackColor = false;
            btnRetirar.Click += btnRetirar_Click;
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
            lblMonto.Size = new Size(113, 20);
            lblMonto.TabIndex = 4;
            lblMonto.Text = "Monto a Retirar";
            // 
            // FormRetiro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 37, 38);
            ClientSize = new Size(480, 425);
            Controls.Add(pnlSaldo);
            Controls.Add(cmbClientes);
            Controls.Add(lblTitulo);
            Controls.Add(pnlAccion);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRetiro";
            Text = "FormRetiro";
            Load += FormRetiro_Load;
            pnlSaldo.ResumeLayout(false);
            pnlSaldo.PerformLayout();
            pnlAccion.ResumeLayout(false);
            pnlAccion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSaldo;
        private Label lblSaldoValor;
        private Label lblSaldoTitulo;
        private ComboBox cmbClientes;
        private Label lblTitulo;
        private Panel pnlAccion;
        private Button btnRetirar;
        private TextBox txtMonto;
        private Label lblMonto;
    }
}