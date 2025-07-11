using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
// Asegúrate de que este using apunte a tu proyecto de CapaNegocio
using CapaNegocio;
using CapaNegocios;

// Asegúrate de que el namespace coincida con el de tu proyecto de Presentacion
namespace Presentacion
{
    public partial class FormTransaccion : Form
    {
        private List<Cuenta> listaDeCuentas;

        public FormTransaccion()
        {
            // Esta línea es la que conecta con tu diseño visual. ¡Es muy importante!
            InitializeComponent();
        }

        // Este evento se ejecuta cuando el formulario se carga por primera vez
        private void FormTransaccion_Load(object sender, EventArgs e)
        {
            // --- Propiedades del Formulario ---
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;

            // Cargar los clientes en ambos ComboBox al iniciar
            CargarClientesEnCombos();
        }

        private void CargarClientesEnCombos()
        {
            try
            {
                CNPersonas cnPersonas = new CNPersonas();
                listaDeCuentas = cnPersonas.ObtenerListaDeCuentas();

                // Cargar ComboBox de Origen
                cmbCuentaOrigen.DataSource = new List<Cuenta>(listaDeCuentas);
                cmbCuentaOrigen.DisplayMember = "Nombre";
                cmbCuentaOrigen.ValueMember = "Id";

                // Cargar ComboBox de Destino
                cmbCuentaDestino.DataSource = new List<Cuenta>(listaDeCuentas);
                cmbCuentaDestino.DisplayMember = "Nombre";
                cmbCuentaDestino.ValueMember = "Id";

                // --- CORRECCIÓN AQUÍ ---
                // Limpiamos la selección inicial para que no aparezca ningún dato.
                cmbCuentaOrigen.SelectedIndex = -1;
                cmbCuentaOrigen.Text = "Seleccione cuenta de origen...";
                lblSaldoOrigen.Text = "Saldo disponible: ";

                cmbCuentaDestino.SelectedIndex = -1;
                cmbCuentaDestino.Text = "Seleccione cuenta de destino...";
                lblSaldoDestino.Text = "Saldo actual: ";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las cuentas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento para cuando se selecciona una cuenta de origen
        private void cmbCuentaOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCuentaOrigen.SelectedItem is Cuenta cuentaSeleccionada)
            {
                lblSaldoOrigen.Text = $"Saldo disponible: {cuentaSeleccionada.SaldoCuenta:C}";
            }
        }

        // Evento para cuando se selecciona una cuenta de destino
        private void cmbCuentaDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCuentaDestino.SelectedItem is Cuenta cuentaSeleccionada)
            {
                lblSaldoDestino.Text = $"Saldo actual: {cuentaSeleccionada.SaldoCuenta:C}";
            }
        }

        // Para crear este evento, ve al diseñador y haz doble clic en el botón "Confirmar Transferencia"
        private void btnTransferir_Click(object sender, EventArgs e)
        {
            // 1. Validaciones iniciales
            if (cmbCuentaOrigen.SelectedItem == null || cmbCuentaDestino.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una cuenta de origen y una de destino.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtMonto.Text, out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Por favor, ingrese un monto válido y positivo.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cuenta cuentaOrigen = (Cuenta)cmbCuentaOrigen.SelectedItem;
            Cuenta cuentaDestino = (Cuenta)cmbCuentaDestino.SelectedItem;

            if (cuentaOrigen.Id == cuentaDestino.Id)
            {
                MessageBox.Show("La cuenta de origen y destino no pueden ser la misma.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Lógica de la transferencia
            try
            {
                // Intentamos retirar de la cuenta de origen
                string resultadoRetiro = cuentaOrigen.Retirar(monto);

                // Si el retiro falla (por fondos insuficientes, etc.), mostramos el mensaje y detenemos la operación.
                if (resultadoRetiro.Contains("Fondos insuficientes"))
                {
                    MessageBox.Show($"Error en la cuenta de origen: {resultadoRetiro}", "Transferencia Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Si el retiro fue exitoso, depositamos en la cuenta de destino
                cuentaDestino.Depositar(monto);

                // 3. Actualizar ambos saldos en la base de datos
                CNPersonas cnPersonas = new CNPersonas();
                cnPersonas.ActualizarSaldo(cuentaOrigen.Id, cuentaOrigen.SaldoCuenta);
                cnPersonas.ActualizarSaldo(cuentaDestino.Id, cuentaDestino.SaldoCuenta);

                // 4. Mostrar mensaje de éxito y actualizar la UI
                MessageBox.Show("¡Transferencia realizada con éxito!", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refrescar saldos en pantalla y limpiar campos
                lblSaldoOrigen.Text = $"Saldo disponible: {cuentaOrigen.SaldoCuenta:C}";
                lblSaldoDestino.Text = $"Saldo actual: {cuentaDestino.SaldoCuenta:C}";
                txtMonto.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado durante la transferencia: {ex.Message}", "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
