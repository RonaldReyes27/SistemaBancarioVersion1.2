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

            // --- Estilos del DataGridView ---
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

        // Para crear este evento, ve al diseñador y haz doble clic en el botón "Buscar"
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBuscarId.Text, out int idCliente))
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
                    // Actualizamos los labels con la información encontrada
                    lblNombreCliente.Text = $"Nombre: {cuentaEncontrada.Nombre}";
                    lblNumCuentaCliente.Text = $"Nro. Cuenta: {cuentaEncontrada.NumCuenta}";
                    lblSaldoCliente.Text = $"Saldo: {cuentaEncontrada.SaldoCuenta:C}";

                    // Este método simula la carga de transacciones en la tabla
                    CargarTransaccionesSimuladas();
                }
                else
                {
                    MessageBox.Show("No se encontró ningún cliente con ese ID.", "Búsqueda Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Limpiamos los labels si no se encuentra nada
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

        // Método de ejemplo para simular la carga de datos en el DataGridView
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
    }
}
