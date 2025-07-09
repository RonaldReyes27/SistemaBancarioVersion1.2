namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            sidebar = new FlowLayoutPanel();
            panel2 = new Panel();
            button1 = new Button();
            menuContainer = new FlowLayoutPanel();
            panel3 = new Panel();
            btnMenu = new Button();
            panel6 = new Panel();
            button5 = new Button();
            panel7 = new Panel();
            button6 = new Button();
            panel8 = new Panel();
            button2 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            panel5 = new Panel();
            button4 = new Button();
            label1 = new Label();
            btnHam = new PictureBox();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            panel1 = new Panel();
            MenuTransicion = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            sidebar.SuspendLayout();
            panel2.SuspendLayout();
            menuContainer.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(23, 24, 29);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(menuContainer);
            sidebar.Controls.Add(panel8);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel5);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 46);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(249, 602);
            sidebar.TabIndex = 1;
            sidebar.Paint += sidebar_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(246, 53);
            panel2.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(23, 24, 29);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.euro;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-7, -7);
            button1.Name = "button1";
            button1.Size = new Size(262, 68);
            button1.TabIndex = 2;
            button1.Text = "          Deashboard";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // menuContainer
            // 
            menuContainer.BackColor = Color.FromArgb(32, 33, 36);
            menuContainer.Controls.Add(panel3);
            menuContainer.Controls.Add(panel6);
            menuContainer.Controls.Add(panel7);
            menuContainer.Location = new Point(0, 59);
            menuContainer.Margin = new Padding(0);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(246, 68);
            menuContainer.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnMenu);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(246, 53);
            panel3.TabIndex = 4;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(23, 24, 29);
            btnMenu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu.ForeColor = Color.White;
            btnMenu.Image = Properties.Resources.flecha_abajo;
            btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenu.Location = new Point(-7, -7);
            btnMenu.Margin = new Padding(0);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(262, 68);
            btnMenu.TabIndex = 2;
            btnMenu.Text = "          Menu";
            btnMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(button5);
            panel6.Location = new Point(3, 62);
            panel6.Name = "panel6";
            panel6.Size = new Size(246, 53);
            panel6.TabIndex = 5;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(32, 33, 36);
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Image = Properties.Resources.grupo_de_usuario;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(-5, -7);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(270, 68);
            button5.TabIndex = 2;
            button5.Text = "          Clientes";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(button6);
            panel7.Location = new Point(3, 121);
            panel7.Name = "panel7";
            panel7.Size = new Size(246, 53);
            panel7.TabIndex = 6;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(32, 33, 36);
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Image = Properties.Resources.lupa;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(-5, -7);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(262, 68);
            button6.TabIndex = 2;
            button6.Text = "          Historial";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(button2);
            panel8.Location = new Point(3, 130);
            panel8.Name = "panel8";
            panel8.Size = new Size(246, 53);
            panel8.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(23, 24, 29);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.deposito;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-4, -7);
            button2.Name = "button2";
            button2.Size = new Size(262, 68);
            button2.TabIndex = 2;
            button2.Text = "          Depósito";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.Location = new Point(3, 189);
            panel4.Name = "panel4";
            panel4.Size = new Size(246, 53);
            panel4.TabIndex = 4;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(23, 24, 29);
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = Properties.Resources.retiro;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-5, -7);
            button3.Name = "button3";
            button3.Size = new Size(262, 68);
            button3.TabIndex = 2;
            button3.Text = "          Retiro";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(button4);
            panel5.Location = new Point(3, 248);
            panel5.Name = "panel5";
            panel5.Size = new Size(246, 53);
            panel5.TabIndex = 5;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(23, 24, 29);
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Image = Properties.Resources.transaccion;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-4, -7);
            button4.Name = "button4";
            button4.Size = new Size(262, 68);
            button4.TabIndex = 2;
            button4.Text = "          Transacción";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 7);
            label1.Name = "label1";
            label1.Size = new Size(183, 28);
            label1.TabIndex = 1;
            label1.Text = "Banco Eurux | Menu";
            label1.Click += label1_Click;
            // 
            // btnHam
            // 
            btnHam.Image = Properties.Resources.Slideropci;
            btnHam.Location = new Point(8, 4);
            btnHam.Name = "btnHam";
            btnHam.Size = new Size(46, 36);
            btnHam.SizeMode = PictureBoxSizeMode.CenterImage;
            btnHam.TabIndex = 1;
            btnHam.TabStop = false;
            btnHam.Click += btnHam_Click;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(1072, 9);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 1;
            nightControlBox1.Click += nightControlBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(btnHam);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1211, 46);
            panel1.TabIndex = 0;
            // 
            // MenuTransicion
            // 
            MenuTransicion.Interval = 10;
            MenuTransicion.Tick += MenuTransicion_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1241, 648);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Padding = new Padding(0, 0, 30, 0);
            Text = "Form1";
            Load += Form1_Load_1;
            sidebar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            menuContainer.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHam).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel sidebar;
        private Label label1;
        private PictureBox btnHam;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Panel panel1;
        private System.Windows.Forms.Timer MenuTransicion;
        private System.Windows.Forms.Timer sidebarTransition;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
        private Button btnMenu;
        private Panel panel4;
        private Button button3;
        private Panel panel5;
        private Button button4;
        private FlowLayoutPanel menuContainer;
        private Panel panel6;
        private Button button5;
        private Panel panel7;
        private Button button6;
        private Panel panel8;
        private Button button2;
    }
}
