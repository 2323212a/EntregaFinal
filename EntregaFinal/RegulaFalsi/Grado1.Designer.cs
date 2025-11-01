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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grado1));
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.txtL2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtL1 = new System.Windows.Forms.TextBox();
            this.btnContinuar1 = new System.Windows.Forms.Button();
            this.lblLimpiar2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblLimpiar1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txta1 = new System.Windows.Forms.TextBox();
            this.txta0 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFuncionRecibida = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();

            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.txtL2);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.txtL1);
            this.panel4.Controls.Add(this.btnContinuar1);
            this.panel4.Controls.Add(this.lblLimpiar2);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(533, 289);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(497, 201);
            this.panel4.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(225, 48);
            this.label14.Text = ",";
            // 
            // txtL2
            // 
            this.txtL2.BackColor = System.Drawing.Color.LightGray;
            this.txtL2.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtL2.Location = new System.Drawing.Point(272, 58);
            this.txtL2.Size = new System.Drawing.Size(47, 39);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(324, 41);
            this.label13.Text = "]";
            // 
            // txtL1
            // 
            this.txtL1.BackColor = System.Drawing.Color.LightGray;
            this.txtL1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtL1.Location = new System.Drawing.Point(169, 58);
            this.txtL1.Size = new System.Drawing.Size(47, 39);
            // 
            // btnContinuar1
            // 
            this.btnContinuar1.BackColor = System.Drawing.Color.FromArgb(88, 101, 242);
            this.btnContinuar1.FlatAppearance.BorderSize = 0;
            this.btnContinuar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnContinuar1.ForeColor = System.Drawing.Color.White;
            this.btnContinuar1.Location = new System.Drawing.Point(313, 133);
            this.btnContinuar1.Size = new System.Drawing.Size(131, 46);
            this.btnContinuar1.Text = "Continuar";
            this.btnContinuar1.UseVisualStyleBackColor = false;
            this.btnContinuar1.Click += new System.EventHandler(this.btnContinuar1_Click);
            // 
            // lblLimpiar2
            // 
            this.lblLimpiar2.BackColor = System.Drawing.Color.FromArgb(88, 101, 242);
            this.lblLimpiar2.FlatAppearance.BorderSize = 0;
            this.lblLimpiar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLimpiar2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblLimpiar2.ForeColor = System.Drawing.Color.White;
            this.lblLimpiar2.Location = new System.Drawing.Point(48, 133);
            this.lblLimpiar2.Size = new System.Drawing.Size(127, 46);
            this.lblLimpiar2.Text = "Limpiar";
            this.lblLimpiar2.UseVisualStyleBackColor = false;
            this.lblLimpiar2.Click += new System.EventHandler(this.lblLimpiar2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(16, 11);
            this.label11.Text = "Límites";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(131, 41);
            this.label12.Text = "[";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblLimpiar1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lblResultado);
            this.panel3.Location = new System.Drawing.Point(9, 289);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(515, 201);
            this.panel3.TabIndex = 24;
            // 
            // lblLimpiar1
            // 
            this.lblLimpiar1.BackColor = System.Drawing.Color.FromArgb(88, 101, 242);
            this.lblLimpiar1.FlatAppearance.BorderSize = 0;
            this.lblLimpiar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLimpiar1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblLimpiar1.ForeColor = System.Drawing.Color.White;
            this.lblLimpiar1.Location = new System.Drawing.Point(59, 133);
            this.lblLimpiar1.Size = new System.Drawing.Size(127, 46);
            this.lblLimpiar1.Text = "Limpiar";
            this.lblLimpiar1.UseVisualStyleBackColor = false;
            this.lblLimpiar1.Click += new System.EventHandler(this.lblLimpiar1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(16, 11);
            this.label7.Text = "Función:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lblResultado.ForeColor = System.Drawing.Color.Black;
            this.lblResultado.Location = new System.Drawing.Point(133, 60);
            this.lblResultado.Text = "resultado";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnEvaluar);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txta1);
            this.panel2.Controls.Add(this.txta0);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(9, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1021, 169);
            this.panel2.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(365, 60);
            this.label10.Text = "a₀";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(224, 59);
            this.label9.Text = "a₁";
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.BackColor = System.Drawing.Color.FromArgb(88, 101, 242);
            this.btnEvaluar.FlatAppearance.BorderSize = 0;
            this.btnEvaluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvaluar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEvaluar.ForeColor = System.Drawing.Color.White;
            this.btnEvaluar.Location = new System.Drawing.Point(796, 105);
            this.btnEvaluar.Size = new System.Drawing.Size(187, 46);
            this.btnEvaluar.Text = "Evaluar";
            this.btnEvaluar.UseVisualStyleBackColor = false;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(420, 18);
            this.label6.Text = "y utiliza los signos correspondientes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(273, 105);
            this.label5.Text = "x";
            // 
            // txta1
            // 
            this.txta1.BackColor = System.Drawing.Color.LightGray;
            this.txta1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txta1.Location = new System.Drawing.Point(199, 100);
            this.txta1.Size = new System.Drawing.Size(65, 39);
            // 
            // txta0
            // 
            this.txta0.BackColor = System.Drawing.Color.LightGray;
            this.txta0.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txta0.Location = new System.Drawing.Point(320, 101);
            this.txta0.Size = new System.Drawing.Size(76, 39);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(52, 18);
            this.label3.Text = "Inserta los valores de tu función";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblFuncionRecibida);
            this.panel1.Location = new System.Drawing.Point(9, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 86);
            this.panel1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Text = "Función guía:";
            // 
            // lblFuncionRecibida
            // 
            this.lblFuncionRecibida.AutoSize = true;
            this.lblFuncionRecibida.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblFuncionRecibida.ForeColor = System.Drawing.Color.Black;
            this.lblFuncionRecibida.Location = new System.Drawing.Point(233, 23);
            this.lblFuncionRecibida.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(-74, 69);
            this.label2.Text = "";
            // 
            // Grado1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 536);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "Grado1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Método Regula Falsi - Grado 1";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
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
