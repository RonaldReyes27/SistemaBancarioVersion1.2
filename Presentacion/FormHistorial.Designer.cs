namespace Presentacion
{
    partial class FormHistorial
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            btnBuscar = new Button();
            txtBuscarId = new TextBox();
            pnlDatosCliente = new Panel();
            lblSaldoCliente = new Label();
            lblNumCuentaCliente = new Label();
            lblNombreCliente = new Label();
            lblDatosClienteTitulo = new Label();
            dgvTransacciones = new DataGridView();
            pictureBox1 = new PictureBox();
            pnlDatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransacciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(197, 106);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(290, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Consulta de Historial";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DodgerBlue;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(274, 167);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(115, 32);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscarId
            // 
            txtBuscarId.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarId.Location = new Point(16, 169);
            txtBuscarId.Name = "txtBuscarId";
            txtBuscarId.Size = new Size(252, 30);
            txtBuscarId.TabIndex = 3;
            txtBuscarId.Text = "Ingrese el ID del Cliente";
            txtBuscarId.Enter += txtBuscarId_Enter;
            txtBuscarId.KeyPress += txtBuscarId_KeyPress;
            txtBuscarId.Leave += txtBuscarId_Leave;
            // 
            // pnlDatosCliente
            // 
            pnlDatosCliente.BackColor = Color.FromArgb(63, 63, 70);
            pnlDatosCliente.Controls.Add(lblSaldoCliente);
            pnlDatosCliente.Controls.Add(lblNumCuentaCliente);
            pnlDatosCliente.Controls.Add(lblNombreCliente);
            pnlDatosCliente.Location = new Point(16, 236);
            pnlDatosCliente.Name = "pnlDatosCliente";
            pnlDatosCliente.Size = new Size(331, 190);
            pnlDatosCliente.TabIndex = 4;
            // 
            // lblSaldoCliente
            // 
            lblSaldoCliente.AutoSize = true;
            lblSaldoCliente.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaldoCliente.Location = new Point(7, 137);
            lblSaldoCliente.Name = "lblSaldoCliente";
            lblSaldoCliente.Size = new Size(60, 23);
            lblSaldoCliente.TabIndex = 6;
            lblSaldoCliente.Text = "Saldo:";
            // 
            // lblNumCuentaCliente
            // 
            lblNumCuentaCliente.AutoSize = true;
            lblNumCuentaCliente.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumCuentaCliente.Location = new Point(7, 83);
            lblNumCuentaCliente.Name = "lblNumCuentaCliente";
            lblNumCuentaCliente.Size = new Size(107, 23);
            lblNumCuentaCliente.TabIndex = 8;
            lblNumCuentaCliente.Text = "Nro. Cuenta:";
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreCliente.Location = new Point(7, 38);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(77, 23);
            lblNombreCliente.TabIndex = 7;
            lblNombreCliente.Text = "Nombre:";
            // 
            // lblDatosClienteTitulo
            // 
            lblDatosClienteTitulo.AutoSize = true;
            lblDatosClienteTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosClienteTitulo.Location = new Point(23, 227);
            lblDatosClienteTitulo.Name = "lblDatosClienteTitulo";
            lblDatosClienteTitulo.Size = new Size(172, 20);
            lblDatosClienteTitulo.TabIndex = 5;
            lblDatosClienteTitulo.Text = "Información del Cliente";
            // 
            // dgvTransacciones
            // 
            dgvTransacciones.BackgroundColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTransacciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTransacciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(63, 63, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTransacciones.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTransacciones.Location = new Point(404, 167);
            dgvTransacciones.Name = "dgvTransacciones";
            dgvTransacciones.RowHeadersVisible = false;
            dgvTransacciones.RowHeadersWidth = 51;
            dgvTransacciones.Size = new Size(297, 417);
            dgvTransacciones.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.histo;
            pictureBox1.Location = new Point(318, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // FormHistorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 37, 38);
            ClientSize = new Size(717, 597);
            Controls.Add(pictureBox1);
            Controls.Add(dgvTransacciones);
            Controls.Add(lblDatosClienteTitulo);
            Controls.Add(pnlDatosCliente);
            Controls.Add(txtBuscarId);
            Controls.Add(btnBuscar);
            Controls.Add(lblTitulo);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormHistorial";
            Text = "FormHistorial";
            Load += FormHistorial_Load;
            pnlDatosCliente.ResumeLayout(false);
            pnlDatosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransacciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnBuscar;
        private TextBox txtBuscarId;
        private Panel pnlDatosCliente;
        private Label lblDatosClienteTitulo;
        private Label lblNumCuentaCliente;
        private Label lblNombreCliente;
        private Label lblSaldoCliente;
        private DataGridView dgvTransacciones;
        private PictureBox pictureBox1;
    }
}