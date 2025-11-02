using System;
using System.Drawing;
using System.Windows.Forms;

namespace EntregaFinal.RegulaFalsi
{
    partial class Grado1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            panel4 = new Panel();
            label14 = new Label();
            txtL2 = new TextBox();
            label13 = new Label();
            txtL1 = new TextBox();
            btnContinuar1 = new Button();
            lblLimpiar2 = new Button();
            label11 = new Label();
            label12 = new Label();
            panel3 = new Panel();
            lblLimpiar1 = new Button();
            label7 = new Label();
            lblResultado = new Label();
            panel2 = new Panel();
            label10 = new Label();
            label9 = new Label();
            btnEvaluar = new Button();
            label6 = new Label();
            label5 = new Label();
            txta1 = new TextBox();
            txta0 = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            lblFuncionRecibida = new Label();
            label2 = new Label();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label14);
            panel4.Controls.Add(txtL2);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(txtL1);
            panel4.Controls.Add(btnContinuar1);
            panel4.Controls.Add(lblLimpiar2);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label12);
            panel4.Location = new Point(533, 361);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(497, 250);
            panel4.TabIndex = 25;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 27.75F);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(225, 60);
            label14.Name = "label14";
            label14.Size = new Size(37, 62);
            label14.TabIndex = 0;
            label14.Text = ",";
            // 
            // txtL2
            // 
            txtL2.BackColor = Color.LightGray;
            txtL2.Font = new Font("Segoe UI", 14.25F);
            txtL2.Location = new Point(272, 72);
            txtL2.Margin = new Padding(3, 4, 3, 4);
            txtL2.Name = "txtL2";
            txtL2.Size = new Size(47, 39);
            txtL2.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 27.75F);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(324, 51);
            label13.Name = "label13";
            label13.Size = new Size(41, 62);
            label13.TabIndex = 2;
            label13.Text = "]";
            // 
            // txtL1
            // 
            txtL1.BackColor = Color.LightGray;
            txtL1.Font = new Font("Segoe UI", 14.25F);
            txtL1.Location = new Point(169, 72);
            txtL1.Margin = new Padding(3, 4, 3, 4);
            txtL1.Name = "txtL1";
            txtL1.Size = new Size(47, 39);
            txtL1.TabIndex = 3;
            // 
            // btnContinuar1
            // 
            btnContinuar1.BackColor = Color.FromArgb(88, 101, 242);
            btnContinuar1.FlatAppearance.BorderSize = 0;
            btnContinuar1.FlatStyle = FlatStyle.Flat;
            btnContinuar1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnContinuar1.ForeColor = Color.White;
            btnContinuar1.Location = new Point(313, 166);
            btnContinuar1.Margin = new Padding(3, 4, 3, 4);
            btnContinuar1.Name = "btnContinuar1";
            btnContinuar1.Size = new Size(131, 58);
            btnContinuar1.TabIndex = 4;
            btnContinuar1.Text = "Continuar";
            btnContinuar1.UseVisualStyleBackColor = false;
            btnContinuar1.Click += btnContinuar1_Click;
            // 
            // lblLimpiar2
            // 
            lblLimpiar2.BackColor = Color.FromArgb(88, 101, 242);
            lblLimpiar2.FlatAppearance.BorderSize = 0;
            lblLimpiar2.FlatStyle = FlatStyle.Flat;
            lblLimpiar2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblLimpiar2.ForeColor = Color.White;
            lblLimpiar2.Location = new Point(48, 166);
            lblLimpiar2.Margin = new Padding(3, 4, 3, 4);
            lblLimpiar2.Name = "lblLimpiar2";
            lblLimpiar2.Size = new Size(127, 58);
            lblLimpiar2.TabIndex = 5;
            lblLimpiar2.Text = "Limpiar";
            lblLimpiar2.UseVisualStyleBackColor = false;
            lblLimpiar2.Click += lblLimpiar2_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(16, 14);
            label11.Name = "label11";
            label11.Size = new Size(101, 37);
            label11.TabIndex = 6;
            label11.Text = "Límites";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 27.75F);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(131, 51);
            label12.Name = "label12";
            label12.Size = new Size(41, 62);
            label12.TabIndex = 7;
            label12.Text = "[";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(lblLimpiar1);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(lblResultado);
            panel3.Location = new Point(9, 361);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(515, 250);
            panel3.TabIndex = 24;
            // 
            // lblLimpiar1
            // 
            lblLimpiar1.BackColor = Color.FromArgb(88, 101, 242);
            lblLimpiar1.FlatAppearance.BorderSize = 0;
            lblLimpiar1.FlatStyle = FlatStyle.Flat;
            lblLimpiar1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblLimpiar1.ForeColor = Color.White;
            lblLimpiar1.Location = new Point(59, 166);
            lblLimpiar1.Margin = new Padding(3, 4, 3, 4);
            lblLimpiar1.Name = "lblLimpiar1";
            lblLimpiar1.Size = new Size(127, 58);
            lblLimpiar1.TabIndex = 0;
            lblLimpiar1.Text = "Limpiar";
            lblLimpiar1.UseVisualStyleBackColor = false;
            lblLimpiar1.Click += lblLimpiar1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(16, 14);
            label7.Name = "label7";
            label7.Size = new Size(116, 37);
            label7.TabIndex = 1;
            label7.Text = "Función:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 15.75F);
            lblResultado.ForeColor = Color.Black;
            lblResultado.Location = new Point(133, 75);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(128, 37);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "resultado";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(btnEvaluar);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txta1);
            panel2.Controls.Add(txta0);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(9, 139);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1021, 210);
            panel2.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15.75F);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(365, 75);
            label10.Name = "label10";
            label10.Size = new Size(41, 37);
            label10.TabIndex = 0;
            label10.Text = "a₀";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(224, 74);
            label9.Name = "label9";
            label9.Size = new Size(40, 37);
            label9.TabIndex = 1;
            label9.Text = "a₁";
            // 
            // btnEvaluar
            // 
            btnEvaluar.BackColor = Color.FromArgb(88, 101, 242);
            btnEvaluar.FlatAppearance.BorderSize = 0;
            btnEvaluar.FlatStyle = FlatStyle.Flat;
            btnEvaluar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEvaluar.ForeColor = Color.White;
            btnEvaluar.Location = new Point(796, 131);
            btnEvaluar.Margin = new Padding(3, 4, 3, 4);
            btnEvaluar.Name = "btnEvaluar";
            btnEvaluar.Size = new Size(187, 58);
            btnEvaluar.TabIndex = 2;
            btnEvaluar.Text = "Evaluar";
            btnEvaluar.UseVisualStyleBackColor = false;
            btnEvaluar.Click += btnEvaluar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(420, 22);
            label6.Name = "label6";
            label6.Size = new Size(399, 32);
            label6.TabIndex = 3;
            label6.Text = "y utiliza los signos correspondientes";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(273, 131);
            label5.Name = "label5";
            label5.Size = new Size(29, 37);
            label5.TabIndex = 4;
            label5.Text = "x";
            // 
            // txta1
            // 
            txta1.BackColor = Color.LightGray;
            txta1.Font = new Font("Segoe UI", 14.25F);
            txta1.Location = new Point(199, 125);
            txta1.Margin = new Padding(3, 4, 3, 4);
            txta1.Name = "txta1";
            txta1.Size = new Size(65, 39);
            txta1.TabIndex = 5;
            // 
            // txta0
            // 
            txta0.BackColor = Color.LightGray;
            txta0.Font = new Font("Segoe UI", 14.25F);
            txta0.Location = new Point(320, 126);
            txta0.Margin = new Padding(3, 4, 3, 4);
            txta0.Name = "txta0";
            txta0.Size = new Size(76, 39);
            txta0.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(52, 22);
            label3.Name = "label3";
            label3.Size = new Size(355, 32);
            label3.TabIndex = 7;
            label3.Text = "Inserta los valores de tu función";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblFuncionRecibida);
            panel1.Location = new Point(9, 21);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1021, 106);
            panel1.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(33, 29);
            label1.Name = "label1";
            label1.Size = new Size(157, 32);
            label1.TabIndex = 0;
            label1.Text = "Función guía:";
            // 
            // lblFuncionRecibida
            // 
            lblFuncionRecibida.AutoSize = true;
            lblFuncionRecibida.Font = new Font("Segoe UI", 14.25F);
            lblFuncionRecibida.ForeColor = Color.Black;
            lblFuncionRecibida.Location = new Point(233, 29);
            lblFuncionRecibida.Name = "lblFuncionRecibida";
            lblFuncionRecibida.Size = new Size(78, 32);
            lblFuncionRecibida.TabIndex = 1;
            lblFuncionRecibida.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(-74, 86);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 26;
            // 
            // Grado1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1087, 670);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Grado1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Método Regula Falsi - Grado 1";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtL2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtL1;
        private System.Windows.Forms.Button btnContinuar1;
        private System.Windows.Forms.Button lblLimpiar2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button lblLimpiar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txta1;
        private System.Windows.Forms.TextBox txta0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFuncionRecibida;
        private System.Windows.Forms.Label label2;
    }
}
