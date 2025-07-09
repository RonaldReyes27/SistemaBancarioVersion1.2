namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MenuTransicion.Start();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nightControlBox1_Click(object sender, EventArgs e)
        {

        }
        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            // Si el men� est� expandido, lo ocultamos
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 60)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                    sidebar.Width = 43; // <-- A�adido para asegurar el tama�o exacto
                }
            }
            // Si est� oculto, lo expandimos
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 249)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                    sidebar.Width = 249; // <-- A�adido para asegurar el tama�o exacto
                }
            }


        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
        bool menuExpand = false;
        private void MenuTransicion_Tick(object sender, EventArgs e)
        {
            // L�gica para EXPANDIR el men�
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                // Si la altura alcanza o supera el m�ximo, se detiene.
                if (menuContainer.Height >= 179)
                {
                    MenuTransicion.Stop();      // Detiene el timer
                    menuContainer.Height = 179; // Asegura la altura final exacta
                    menuExpand = true;          // Cambia el estado a expandido
                }
            }
            // L�gica para CONTRAER el men�
            else
            {
                menuContainer.Height -= 10;
                // Si la altura alcanza o es menor que el m�nimo, se detiene.
                if (menuContainer.Height <= 68)
                {
                    MenuTransicion.Stop();     // Detiene el timer
                    menuContainer.Height = 68; // Asegura la altura final exacta
                    menuExpand = false;        // Cambia el estado a contra�do
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuTransicion.Start();
        }
    }
}
