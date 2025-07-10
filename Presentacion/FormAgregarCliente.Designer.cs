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
            btnGuardar = new Button();
            lblNumCuenta = new Label();
            lblNombre = new Label();
            txtNumCuenta = new TextBox();
            txtNombre = new TextBox();
            lblTipoCuenta = new Label();
            cmbTipoCuenta = new ComboBox();
            lblSaldo = new Label();
            txtSaldo = new TextBox();
            btnCancelar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(135, 107);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(217, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Nuevo Cliente";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DodgerBlue;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(22, 479);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(202, 56);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar Cliente";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += this.btnGuardar_Click;
            // 
            // lblNumCuenta
            // 
            lblNumCuenta.AutoSize = true;
            lblNumCuenta.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumCuenta.ForeColor = Color.White;
            lblNumCuenta.Location = new Point(61, 183);
            lblNumCuenta.Name = "lblNumCuenta";
            lblNumCuenta.Size = new Size(162, 25);
            lblNumCuenta.TabIndex = 3;
            lblNumCuenta.Text = "Número de Cuenta";
          //  lblNumCuenta.Click += this.lblNumCuenta_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(61, 272);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(160, 25);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre del Titular";
          // lblNombre.Click += this.lblNombre_Click;
            // 
            // txtNumCuenta
            // 
            txtNumCuenta.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumCuenta.Location = new Point(61, 211);
            txtNumCuenta.Name = "txtNumCuenta";
            txtNumCuenta.Size = new Size(363, 31);
            txtNumCuenta.TabIndex = 6;
           // txtNumCuenta.TextChanged += this.txtNumCuenta_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(61, 300);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(363, 31);
            txtNombre.TabIndex = 7;
         //   txtNombre.TextChanged += this.txtNombre_TextChanged;
            // 
            // lblTipoCuenta
            // 
            lblTipoCuenta.AutoSize = true;
            lblTipoCuenta.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoCuenta.ForeColor = Color.White;
            lblTipoCuenta.Location = new Point(61, 366);
            lblTipoCuenta.Name = "lblTipoCuenta";
            lblTipoCuenta.Size = new Size(132, 25);
            lblTipoCuenta.TabIndex = 8;
            lblTipoCuenta.Text = "Tipo de Cuenta";
           /// lblTipoCuenta.Click += label1_Click;
            // 
            // cmbTipoCuenta
            // 
            cmbTipoCuenta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoCuenta.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTipoCuenta.FormattingEnabled = true;
            cmbTipoCuenta.Location = new Point(61, 394);
            cmbTipoCuenta.Name = "cmbTipoCuenta";
            cmbTipoCuenta.Size = new Size(151, 33);
            cmbTipoCuenta.TabIndex = 9;
           // cmbTipoCuenta.SelectedIndexChanged += this.cmbTipoCuenta_SelectedIndexChanged;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSaldo.ForeColor = Color.White;
            lblSaldo.Location = new Point(290, 366);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(134, 25);
            lblSaldo.TabIndex = 10;
            lblSaldo.Text = "Depósito Inicial";
            //lblSaldo.Click += this.lblSaldo_Click;
            // 
            // txtSaldo
            // 
            txtSaldo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSaldo.Location = new Point(292, 394);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(132, 31);
            txtSaldo.TabIndex = 11;
          //  txtSaldo.TextChanged += this.txtSaldo_TextChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(63, 63, 70);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(263, 479);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(202, 56);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += this.btnCancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.agregar_cliente;
            pictureBox1.Location = new Point(217, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 58);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
           // pictureBox1.Click += pictureBox1_Click;
            // 
            // FormAgregarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 37, 38);
            ClientSize = new Size(492, 577);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancelar);
            Controls.Add(txtSaldo);
            Controls.Add(lblSaldo);
            Controls.Add(cmbTipoCuenta);
            Controls.Add(lblTipoCuenta);
            Controls.Add(txtNombre);
            Controls.Add(txtNumCuenta);
            Controls.Add(lblNombre);
            Controls.Add(lblNumCuenta);
            Controls.Add(btnGuardar);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAgregarCliente";
            Text = "FormAgregarCliente";
            Load += FormAgregarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnGuardar;
        private Label lblNumCuenta;
        private Label lblNombre;
        private TextBox txtNumCuenta;
        private TextBox txtNombre;
        private Label lblTipoCuenta;
        private ComboBox cmbTipoCuenta;
        private Label lblSaldo;
        private TextBox txtSaldo;
        private Button btnCancelar;
        private PictureBox pictureBox1;
    }
}