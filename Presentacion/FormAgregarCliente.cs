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
            InitializeComponent();
        }

        private void FormAgregarCliente_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            cmbTipoCuenta.Items.Add("Ahorros");
            cmbTipoCuenta.Items.Add("Corriente");
            cmbTipoCuenta.SelectedIndex = 0;
        }

        // --- NUEVO MÉTODO PARA LIMPIAR LOS CAMPOS ---
        private void LimpiarCampos()
        {
            txtNumCuenta.Clear();
            txtNombre.Clear();
            txtSaldo.Clear();
            cmbTipoCuenta.SelectedIndex = 0;
            txtNumCuenta.Focus(); // Pone el cursor en el primer campo, listo para el siguiente registro.
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
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

                CNPersonas cnPersonas = new CNPersonas();
                cnPersonas.RegistrarCliente(
                    txtNombre.Text,
                    txtNumCuenta.Text,
                    cmbTipoCuenta.SelectedItem.ToString(),
                    saldo
                );

                // --- COMPORTAMIENTO MEJORADO ---
                MessageBox.Show("Cliente agregado con éxito.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiamos los campos para que se pueda agregar otro cliente.
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar el cliente: {ex.Message}", "Error en la Operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // --- COMPORTAMIENTO MEJORADO ---
            // 1. Mostramos el mensaje de cancelación.
            MessageBox.Show("Operación cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 2. Le pedimos al formulario principal que muestre el Dashboard.
            if (this.ParentForm is Form1 mainForm)
            {
                mainForm.AbrirFormularioEnPanel(new FormDashboard());
            }
        }
    }
}
