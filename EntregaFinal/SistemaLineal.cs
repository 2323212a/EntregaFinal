using System;
using System.Drawing;
using System.Windows.Forms;
using EntregaFinal.Metodoslineales;

namespace EntregaFinal
{
    public partial class SistemaLineal : Form
    {
        private Label lblTitulo;
        private FlowLayoutPanel panelBotones;
        private Button btnCramer;
        private Button btnGauss;
        private Button btnGaussJordan;
        private Button btnCofactores;
        private Button btnVolver;

        public SistemaLineal()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new Label();
            this.panelBotones = new FlowLayoutPanel();
            this.btnCramer = new Button();
            this.btnGauss = new Button();
            this.btnGaussJordan = new Button();
            this.btnCofactores = new Button();
            this.btnVolver = new Button();
            this.SuspendLayout();

            // ======== FORM ========
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1000, 750);
            this.BackColor = Color.FromArgb(230, 240, 255);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Sistemas de Ecuaciones Lineales";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.FormClosed += SistemaLineal_FormClosed;

            // ======== TÍTULO ========
            this.lblTitulo.Dock = DockStyle.Top;
            this.lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            this.lblTitulo.ForeColor = Color.FromArgb(40, 60, 150);
            this.lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            this.lblTitulo.Text = "Métodos para resolver sistemas de ecuaciones lineales";
            this.lblTitulo.Height = 140;
            this.lblTitulo.BackColor = Color.FromArgb(245, 250, 255);

            // ======== PANEL BOTONES ========
            this.panelBotones.Dock = DockStyle.Fill;
            this.panelBotones.FlowDirection = FlowDirection.TopDown;
            this.panelBotones.AutoScroll = true;
            this.panelBotones.WrapContents = false;
            this.panelBotones.Padding = new Padding(0, 40, 0, 40);
            this.panelBotones.BackColor = Color.Transparent;

            // ======== BOTONES ========
            ConfigurarBoton(this.btnCramer, "Método de Cramer", BtnCramer_Click);
            ConfigurarBoton(this.btnGauss, "Eliminación de Gauss", BtnGauss_Click);
            ConfigurarBoton(this.btnGaussJordan, "Inversa por Gauss-Jordan", BtnGaussJordan_Click);
            ConfigurarBoton(this.btnCofactores, "Inversa por Cofactores", BtnCofactores_Click);

            // Botón volver
            ConfigurarBoton(this.btnVolver, "⬅ Volver al Menú Principal", BtnVolver_Click);
            this.btnVolver.BackColor = Color.FromArgb(90, 150, 90);
            this.btnVolver.MouseEnter += (s, e) => this.btnVolver.BackColor = Color.FromArgb(110, 180, 110);
            this.btnVolver.MouseLeave += (s, e) => this.btnVolver.BackColor = Color.FromArgb(90, 150, 90);

            // ======== AGREGAR BOTONES ========
            this.panelBotones.Controls.Add(this.btnCramer);
            this.panelBotones.Controls.Add(this.btnGauss);
            this.panelBotones.Controls.Add(this.btnGaussJordan);
            this.panelBotones.Controls.Add(this.btnCofactores);
            this.panelBotones.Controls.Add(this.btnVolver);

            // ======== AGREGAR CONTROLES AL FORM ========
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.lblTitulo);

            this.ResumeLayout(false);
        }

        private void ConfigurarBoton(Button boton, string texto, EventHandler evento)
        {
            boton.Text = texto;
            boton.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            boton.Size = new Size(500, 75);
            boton.Margin = new Padding(20);
            boton.BackColor = Color.FromArgb(80, 110, 200);
            boton.ForeColor = Color.White;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.Cursor = Cursors.Hand;
            boton.TextAlign = ContentAlignment.MiddleCenter;
            boton.Click += evento;
            boton.MouseEnter += (s, e) => boton.BackColor = Color.FromArgb(100, 130, 220);
            boton.MouseLeave += (s, e) => boton.BackColor = Color.FromArgb(80, 110, 200);
        }

        // ======== EVENTOS DE BOTONES ========
        private void BtnCramer_Click(object sender, EventArgs e)
        {
            new Cramer().Show();
            this.Hide();
        }

        private void BtnGauss_Click(object sender, EventArgs e)
        {
            new Gauss().Show();
            this.Hide();
        }

        private void BtnGaussJordan_Click(object sender, EventArgs e)
        {
            new GaussInversa().Show();
            this.Hide();
        }

        private void BtnCofactores_Click(object sender, EventArgs e)
        {
            new Cofactores().Show();
            this.Hide();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            VolverMenu();
        }

        private void SistemaLineal_FormClosed(object sender, FormClosedEventArgs e)
        {
            VolverMenu();
        }

        private void VolverMenu()
        {
            MainMenu menu = new MainMenu();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
            this.Hide();
        }
    }
}
