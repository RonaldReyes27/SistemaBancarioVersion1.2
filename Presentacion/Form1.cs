using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// NO BORRES LA SIGUIENTE LÍNEA - ES LA SOLUCIÓN AL ERROR
using Presentacion;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        // --- Variables para las animaciones ---
        bool sidebarExpand = true;
        bool menuExpand = false;

        public Form1()
        {
            InitializeComponent();
        }

        // --- MÉTODO PARA ABRIR FORMULARIOS EN EL PANEL ---
        private void AbrirFormularioEnPanel(object formHijo)
        {
            // Si ya hay otro formulario en el panel, lo eliminamos
            if (this.pnlContent.Controls.Count > 0)
                this.pnlContent.Controls.RemoveAt(0);

            // Convertimos el objeto a un Formulario
            Form fh = formHijo as Form;

            // Lo configuramos para que se comporte como un control y no como una ventana
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None; // Le quitamos los bordes
            fh.Dock = DockStyle.Fill; // Hacemos que ocupe todo el panel

            // Lo añadimos al panel y lo mostramos
            this.pnlContent.Controls.Add(fh);
            this.pnlContent.Tag = fh;
            fh.Show();
        }

        // --- LÓGICA DE LOS BOTONES DEL MENÚ ---

        // Este es el evento para el botón "Clientes"
        private void button5_Click(object sender, EventArgs e)
        {
            // Aquí le decimos que abra una nueva instancia de tu formulario para agregar clientes
            AbrirFormularioEnPanel(new FormAgregarCliente());
        }

        // Evento para el botón que despliega el submenú (el que tiene la flecha)
        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuTransicion.Start();
        }

        // Evento para el botón que expande/contrae todo el menú lateral (el de las 3 rayas)
        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }


        // --- LÓGICA DE LAS ANIMACIONES (TIMERS) ---

        private void MenuTransicion_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 179)
                {
                    MenuTransicion.Stop();
                    menuContainer.Height = 179;
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 65)
                {
                    MenuTransicion.Stop();
                    menuContainer.Height = 65;
                    menuExpand = false;
                }
            }
        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 43) // Ajustado a tu valor
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                    sidebar.Width = 43;
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 249)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                    sidebar.Width = 249;
                }
            }
        }

        // --- OTROS EVENTOS (PUEDES IGNORARLOS SI NO LOS USAS) ---

        private void label1_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e) { }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e) { }
        private void button2_Click_1(object sender, EventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void nightControlBox1_Click(object sender, EventArgs e) { }
        private void sidebar_Paint(object sender, PaintEventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void button1_Click_1(object sender, EventArgs e) { }
        private void Form1_Load_1(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FormHistorial());
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FormDeposito());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FormRetiro());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FormTransaccion());
        }
    }
}
