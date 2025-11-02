using System;
using System.Drawing;
using System.Windows.Forms;

public class MenuButton : Button
{
    public MenuButton(string texto)
    {
        this.Text = texto;
        this.Font = new Font("Segoe UI", 14, FontStyle.Bold);
        this.ForeColor = Color.White;
        this.BackColor = Color.FromArgb(80, 110, 200);
        this.FlatStyle = FlatStyle.Flat;
        this.FlatAppearance.BorderSize = 0;
        this.Height = 200;
        this.Width = 550;
        this.Cursor = Cursors.Hand;
        this.Margin = new Padding(10);

        this.MouseEnter += (s, e) => this.BackColor = Color.FromArgb(100, 130, 220);
        this.MouseLeave += (s, e) => this.BackColor = Color.FromArgb(80, 110, 200);
    }
}
