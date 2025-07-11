using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
// Asegúrate de que este using apunte a tu proyecto de CapaNegocio
using CapaNegocio;
using CapaNegocios;

// Asegúrate de que el namespace coincida con el de tu proyecto de Presentacion
namespace Presentacion
{
    public partial class FormHistorial : Form
    {
        // Variable para guardar el texto del placeholder
        private string placeholderText = "Ingrese el ID del Cliente";

        public FormHistorial()
        {
            // Esta línea es la que conecta con tu diseño visual. ¡Es muy importante!
            InitializeComponent();
        }

        private void FormHistorial_Load(object sender, EventArgs e)
        {
            // --- Propiedades del Formulario ---
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;

            // --- Configuración Inicial del Placeholder ---
            txtBuscarId.Text = placeholderText;
            txtBuscarId.ForeColor = Color.Gray;

            // --- Estilos del DataGridView ---
            dgvTransacciones.ReadOnly = true;
            dgvTransacciones.BackgroundColor = Color.FromArgb(45, 45, 48);
            dgvTransacciones.BorderStyle = BorderStyle.None;
            dgvTransacciones.RowHeadersVisible = false;
            dgvTransacciones.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204);
            dgvTransacciones.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTransacciones.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvTransacciones.EnableHeadersVisualStyles = false;
            dgvTransacciones.DefaultCellStyle.BackColor = Color.FromArgb(63, 63, 70);
            dgvTransacciones.DefaultCellStyle.ForeColor = Color.White;
            dgvTransacciones.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            dgvTransacciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // --- Eventos del Placeholder ---

        // Este evento se dispara cuando el usuario HACE CLIC en el TextBox
        private void txtBuscarId_Enter(object sender, EventArgs e)
        {
            if (txtBuscarId.Text == placeholderText)
            {
                txtBuscarId.Text = "";
                txtBuscarId.ForeColor = Color.Black; // O Color.White si tu TextBox es oscuro
            }
        }

        // Este evento se dispara cuando el usuario HACE CLIC FUERA del TextBox
        private void txtBuscarId_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarId.Text))
            {
                txtBuscarId.Text = placeholderText;
                txtBuscarId.ForeColor = Color.Gray;
            }
        }


        // --- Evento del Botón Buscar ---
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Validamos que el texto no sea el placeholder antes de buscar
            if (txtBuscarId.Text == placeholderText || !int.TryParse(txtBuscarId.Text, out int idCliente))
            {
                MessageBox.Show("Por favor, ingrese un ID de cliente válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                CNPersonas cnPersonas = new CNPersonas();
                Cuenta cuentaEncontrada = cnPersonas.ObtenerCuentaPorId(idCliente);

                if (cuentaEncontrada != null)
                {
                    lblNombreCliente.Text = $"Nombre: {cuentaEncontrada.Nombre}";
                    lblNumCuentaCliente.Text = $"Nro. Cuenta: {cuentaEncontrada.NumCuenta}";
                    lblSaldoCliente.Text = $"Saldo: {cuentaEncontrada.SaldoCuenta:C}";
                    CargarTransaccionesSimuladas();
                }
                else
                {
                    MessageBox.Show("No se encontró ningún cliente con ese ID.", "Búsqueda Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblNombreCliente.Text = "Nombre: ";
                    lblNumCuentaCliente.Text = "Nro. Cuenta: ";
                    lblSaldoCliente.Text = "Saldo: ";
                    dgvTransacciones.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al buscar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarTransaccionesSimuladas()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Fecha", typeof(DateTime));
            dt.Columns.Add("Tipo", typeof(string));
            dt.Columns.Add("Monto", typeof(decimal));

            dt.Rows.Add(DateTime.Now.AddDays(-5), "Depósito", 5000.00m);
            dt.Rows.Add(DateTime.Now.AddDays(-3), "Retiro", -200.00m);
            dt.Rows.Add(DateTime.Now.AddDays(-1), "Depósito", 150.00m);

            dgvTransacciones.DataSource = dt;
            dgvTransacciones.Columns["Monto"].DefaultCellStyle.Format = "C";
        }

        private void txtBuscarId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela la tecla si no es número
            }
        }
    }
}
