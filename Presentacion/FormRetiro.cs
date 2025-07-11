using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
// Asegúrate de que este using apunte a tu proyecto de CapaNegocio
using CapaNegocio;
using CapaNegocios;

// Asegúrate de que el namespace coincida con el de tu proyecto de Presentacion
namespace Presentacion
{
    public partial class FormRetiro : Form
    {
        // Variable para mantener la lista de cuentas cargada
        private List<Cuenta> listaDeCuentas;

        public FormRetiro()
        {
            // Esta línea es la que conecta con tu diseño visual. ¡Es muy importante!
            InitializeComponent();
        }

        // Este evento se ejecuta cuando el formulario se carga por primera vez
        private void FormRetiro_Load(object sender, EventArgs e)
        {
            // --- Propiedades del Formulario ---
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;

            // Cargar los clientes en el ComboBox al iniciar
            CargarClientes();
        }

        private void CargarClientes()
        {
            try
            {
                CNPersonas cnPersonas = new CNPersonas();
                listaDeCuentas = cnPersonas.ObtenerListaDeCuentas();

                cmbClientes.DataSource = listaDeCuentas;
                cmbClientes.DisplayMember = "Nombre"; // Muestra el nombre del cliente
                cmbClientes.ValueMember = "Id";       // El valor interno será el ID

                // Limpiar la selección inicial
                cmbClientes.SelectedIndex = -1;
                cmbClientes.Text = "Seleccione una cuenta...";
                lblSaldoValor.Text = "$0.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Este evento se dispara cuando el usuario selecciona un cliente del ComboBox
        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificamos que haya un cliente seleccionado
            if (cmbClientes.SelectedItem is Cuenta cuentaSeleccionada)
            {
                // Actualizamos el label con el saldo del cliente, formateado como moneda.
                lblSaldoValor.Text = $"{cuentaSeleccionada.SaldoCuenta:C}";
            }
        }

        // Este evento se dispara cuando se hace clic en el botón "Confirmar Retiro"
        private void btnRetirar_Click(object sender, EventArgs e)
        {
            // 1. Validar que se seleccionó un cliente
            if (cmbClientes.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un cliente.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validar que el monto es un número válido
            if (!decimal.TryParse(txtMonto.Text, out decimal monto))
            {
                MessageBox.Show("Por favor, ingrese un monto válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 3. Realizar la operación de retiro en el objeto
                Cuenta cuentaSeleccionada = (Cuenta)cmbClientes.SelectedItem;
                string resultado = cuentaSeleccionada.Retirar(monto);

                // 4. Mostrar el resultado de la operación (éxito o error como "Fondos insuficientes")
                MessageBox.Show(resultado, "Resultado del Retiro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 5. Actualizar el saldo en la base de datos SOLO SI el retiro fue exitoso
                if (!resultado.Contains("Fondos insuficientes") && !resultado.Contains("debe ser positivo"))
                {
                    CNPersonas cnPersonas = new CNPersonas();
                    cnPersonas.ActualizarSaldo(cuentaSeleccionada.Id, cuentaSeleccionada.SaldoCuenta);
                }

                // 6. Refrescar la UI y limpiar los campos
                lblSaldoValor.Text = $"{cuentaSeleccionada.SaldoCuenta:C}";
                txtMonto.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al realizar el retiro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela la tecla si no es número
            }
        }
    }
}
