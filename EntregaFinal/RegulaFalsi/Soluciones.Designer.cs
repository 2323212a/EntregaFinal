namespace EntregaFinal.RegulaFalsi
{
    partial class Soluciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRegresar = new System.Windows.Forms.Button();
            lblRaiz = new System.Windows.Forms.Label();
            dgvReglaFalsa = new System.Windows.Forms.DataGridView();
            panel1 = new System.Windows.Forms.Panel();
            btnCalcular = new System.Windows.Forms.Button();
            txtError = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvReglaFalsa).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = System.Drawing.Color.FromArgb(88, 101, 242);
            btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRegresar.FlatAppearance.BorderSize = 0;
            btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRegresar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnRegresar.ForeColor = System.Drawing.Color.White;
            btnRegresar.Location = new System.Drawing.Point(1246, 176);
            btnRegresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new System.Drawing.Size(197, 55);
            btnRegresar.TabIndex = 8;
            btnRegresar.Text = "Nueva Funcion";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // lblRaiz
            // 
            lblRaiz.AutoSize = true;
            lblRaiz.BackColor = System.Drawing.Color.Transparent;
            lblRaiz.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            lblRaiz.ForeColor = System.Drawing.Color.Black;
            lblRaiz.Location = new System.Drawing.Point(1127, 62);
            lblRaiz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRaiz.Name = "lblRaiz";
            lblRaiz.Size = new System.Drawing.Size(51, 32);
            lblRaiz.TabIndex = 9;
            lblRaiz.Text = "raiz";
            // 
            // dgvReglaFalsa
            // 
            dgvReglaFalsa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvReglaFalsa.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dgvReglaFalsa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReglaFalsa.Location = new System.Drawing.Point(44, 240);
            dgvReglaFalsa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dgvReglaFalsa.Name = "dgvReglaFalsa";
            dgvReglaFalsa.RowHeadersWidth = 51;
            dgvReglaFalsa.Size = new System.Drawing.Size(1343, 502);
            dgvReglaFalsa.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Transparent;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel1.Controls.Add(btnCalcular);
            panel1.Controls.Add(txtError);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblInfo);
            panel1.Location = new System.Drawing.Point(-9, 36);
            panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1101, 176);
            panel1.TabIndex = 6;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = System.Drawing.Color.FromArgb(88, 101, 242);
            btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnCalcular.ForeColor = System.Drawing.Color.White;
            btnCalcular.Location = new System.Drawing.Point(924, 112);
            btnCalcular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new System.Drawing.Size(148, 55);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtError
            // 
            txtError.BackColor = System.Drawing.Color.LightGray;
            txtError.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            txtError.Location = new System.Drawing.Point(947, 11);
            txtError.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtError.Name = "txtError";
            txtError.Size = new System.Drawing.Size(124, 39);
            txtError.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(597, 20);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(320, 32);
            label2.TabIndex = 2;
            label2.Text = "Ingresa el error aproximado: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(59, 20);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(87, 32);
            label1.TabIndex = 1;
            label1.Text = "Datos: ";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            lblInfo.ForeColor = System.Drawing.Color.Black;
            lblInfo.Location = new System.Drawing.Point(59, 72);
            lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new System.Drawing.Size(38, 32);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "ds";
            // 
            // Soluciones
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DarkGray;
            ClientSize = new System.Drawing.Size(1452, 779);
            Controls.Add(btnRegresar);
            Controls.Add(lblRaiz);
            Controls.Add(dgvReglaFalsa);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Soluciones";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvReglaFalsa).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblRaiz;
        private System.Windows.Forms.DataGridView dgvReglaFalsa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInfo;
    }
}