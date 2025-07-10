using System;
using System.Drawing;
using System.Windows.Forms;
// Asegúrate de que este using apunte a tu proyecto de CapaNegocio
using CapaNegocio;
using CapaNegocios;

// Asegúrate de que el namespace coincida con el de tu proyecto de Presentacion
namespace Presentacion
{
    public partial class FormAgregarCliente : Form
    {
        public FormAgregarCliente()
        {
            // Esta línea es la que conecta con tu diseño visual. ¡Es muy importante!
            InitializeComponent();
        }

        // Este evento se ejecuta cuando el formulario se carga por primera vez
        private void FormAgregarCliente_Load(object sender, EventArgs e)
        {
            // --- Propiedades del Formulario ---
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;

            // Pre-llenar el ComboBox de Tipo de Cuenta
            cmbTipoCuenta.Items.Add("Ahorros");
            cmbTipoCuenta.Items.Add("Corriente");
            cmbTipoCuenta.SelectedIndex = 0; // Seleccionar "Ahorros" por defecto
        }

        // Para crear este evento, ve al diseñador y haz doble clic en el botón "Guardar"
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validaciones de los campos
                if (string.IsNullOrWhiteSpace(txtNumCuenta.Text) ||
                    string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtSaldo.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtSaldo.Text, out decimal saldo))
                {
                    MessageBox.Show("El saldo ingresado no es un número válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Llamada a la Capa de Negocio para registrar el cliente
                CNPersonas cnPersonas = new CNPersonas();
                cnPersonas.RegistrarCliente(
                    txtNombre.Text,
                    txtNumCuenta.Text,
                    cmbTipoCuenta.SelectedItem.ToString(),
                    saldo
                );

                // 3. Mensaje de éxito y cierre del formulario
                MessageBox.Show("Cliente guardado con éxito.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cierra este formulario para volver a la pantalla principal
                this.Parent.Controls.Remove(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar el cliente: {ex.Message}", "Error en la Operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Para crear este evento, ve al diseñador y haz doble clic en el botón "Cancelar"
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Simplemente cierra el formulario
            this.Parent.Controls.Remove(this);
        }
    }
}
