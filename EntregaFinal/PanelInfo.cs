using System;
using System.Drawing;
using System.Windows.Forms;

public class PanelInfo : Panel
{
    public PanelInfo(string titulo, string contenido)
    {
        this.BackColor = Color.FromArgb(245, 250, 255);
        this.Margin = new Padding(10);
        this.Padding = new Padding(15);
        this.BorderStyle = BorderStyle.FixedSingle;
        this.Height = 200;
        this.Width = 500;

        Label lblTitulo = new Label()
        {
            Text = titulo,
            Font = new Font("Segoe UI", 14, FontStyle.Bold),
            ForeColor = Color.FromArgb(40, 60, 150),
            Dock = DockStyle.Top,
            Height = 35,
            TextAlign = ContentAlignment.MiddleCenter
        };

        Label lblContenido = new Label()
        {
            Text = contenido,
            Font = new Font("Segoe UI", 12),
            Dock = DockStyle.Fill,
            AutoSize = false,
            TextAlign = ContentAlignment.MiddleLeft
        };

        Controls.Add(lblContenido);
        Controls.Add(lblTitulo);
    }
}
