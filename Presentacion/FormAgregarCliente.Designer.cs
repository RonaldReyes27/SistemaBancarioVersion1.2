namespace Presentacion
{
    partial class FormAgregarCliente
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
            lblNumCuenta = new Label();
            txtNumCuenta = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblTipoCuenta = new Label();
            cmbTipoCuenta = new ComboBox();
            lblSaldo = new Label();
            txtSaldo = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(239, 28);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registro de Nuevo Cliente";
            // 
            // lblNumCuenta
            // 
            lblNumCuenta.AutoSize = true;
            lblNumCuenta.Location = new Point(12, 89);
            lblNumCuenta.Name = "lblNumCuenta";
            lblNumCuenta.Size = new Size(137, 20);
            lblNumCuenta.TabIndex = 1;
            lblNumCuenta.Text = "Número de Cuenta:";
            // 
            // txtNumCuenta
            // 
            txtNumCuenta.Location = new Point(155, 88);
            txtNumCuenta.Name = "txtNumCuenta";
            txtNumCuenta.Size = new Size(210, 27);
            txtNumCuenta.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 139);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(138, 20);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre del Titular:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(155, 136);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(209, 27);
            txtNombre.TabIndex = 4;
            // 
            // lblTipoCuenta
            // 
            lblTipoCuenta.AutoSize = true;
            lblTipoCuenta.Location = new Point(12, 189);
            lblTipoCuenta.Name = "lblTipoCuenta";
            lblTipoCuenta.Size = new Size(113, 20);
            lblTipoCuenta.TabIndex = 5;
            lblTipoCuenta.Text = "Tipo de Cuenta:";
            // 
            // cmbTipoCuenta
            // 
            cmbTipoCuenta.FormattingEnabled = true;
            cmbTipoCuenta.Location = new Point(131, 186);
            cmbTipoCuenta.Name = "cmbTipoCuenta";
            cmbTipoCuenta.Size = new Size(151, 28);
            cmbTipoCuenta.TabIndex = 6;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(13, 249);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(93, 20);
            lblSaldo.TabIndex = 7;
            lblSaldo.Text = "Saldo Inicial:";
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(112, 246);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(209, 27);
            txtSaldo.TabIndex = 8;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(163, 364);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(395, 395);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormAgregarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 551);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtSaldo);
            Controls.Add(lblSaldo);
            Controls.Add(cmbTipoCuenta);
            Controls.Add(lblTipoCuenta);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtNumCuenta);
            Controls.Add(lblNumCuenta);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAgregarCliente";
            Text = "FormAgregarCliente";
            Load += FormAgregarCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNumCuenta;
        private TextBox txtNumCuenta;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblTipoCuenta;
        private ComboBox cmbTipoCuenta;
        private Label lblSaldo;
        private TextBox txtSaldo;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}