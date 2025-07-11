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
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            // Esta línea es la que conecta con tu diseño visual. ¡Es muy importante!
            InitializeComponent();
        }

        // Este evento se ejecuta cuando el formulario se carga por primera vez
        private void FormDashboard_Load(object sender, EventArgs e)
        {
            // --- Propiedades del Formulario ---
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;

            // Iniciar la carga de datos del dashboard
            CargarDatosDashboard();
        }

        // Este evento se ejecuta cada segundo para actualizar la hora
        private void timerFechaHora_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }

        // Método para obtener y mostrar los datos en el dashboard
        private void CargarDatosDashboard()
        {
            try
            {
                CNPersonas cnPersonas = new CNPersonas();
                List<Cuenta> cuentas = cnPersonas.ObtenerListaDeCuentas();

                // Actualizar tarjeta de total de clientes
                lblTotalClientesValor.Text = cuentas.Count.ToString();

                // Actualizar tarjeta de saldo total
                decimal saldoTotal = cuentas.Sum(c => c.SaldoCuenta);
                lblSaldoTotalValor.Text = saldoTotal.ToString("C"); // "C" formatea como moneda

                // Cargar últimos clientes en la tabla (DataGridView)
                var ultimosClientes = cuentas.OrderByDescending(c => c.Id).Take(4).ToList();
                dgvUltimosClientes.DataSource = ultimosClientes;

                // Configurar las columnas del DataGridView para que se vean bien
                if (dgvUltimosClientes.Columns["Id"] != null)
                    dgvUltimosClientes.Columns["Id"].Visible = false; // Ocultamos la columna de ID

                if (dgvUltimosClientes.Columns["TipoCuenta"] != null)
                    dgvUltimosClientes.Columns["TipoCuenta"].HeaderText = "Tipo de Cuenta";

                if (dgvUltimosClientes.Columns["SaldoCuenta"] != null)
                {
                    dgvUltimosClientes.Columns["SaldoCuenta"].HeaderText = "Saldo";
                    dgvUltimosClientes.Columns["SaldoCuenta"].DefaultCellStyle.Format = "C";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos del dashboard: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- Eventos de los Botones de Acceso Rápido ---
        // Para crear estos eventos, ve al diseñador y haz doble clic en cada botón.

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            // Llama al método público de Form1 para abrir el formulario
            ((Form1)this.ParentForm).AbrirFormularioEnPanel(new FormAgregarCliente());
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            ((Form1)this.ParentForm).AbrirFormularioEnPanel(new FormDeposito());
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            ((Form1)this.ParentForm).AbrirFormularioEnPanel(new FormRetiro());
        }
    }
}
