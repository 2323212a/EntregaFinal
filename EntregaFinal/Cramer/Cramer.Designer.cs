namespace EntregaFinal.Metodoslineales
{
    partial class Cramer
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

            private System.Windows.Forms.Button btnEcuaciones2;
        private System.Windows.Forms.Button btnEcuaciones3;
        private System.Windows.Forms.Label lblTitulo;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.btnEcuaciones2 = new System.Windows.Forms.Button();
            this.btnEcuaciones3 = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEcuaciones2
            // 
            this.btnEcuaciones2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnEcuaciones2.FlatAppearance.BorderSize = 0;
            this.btnEcuaciones2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEcuaciones2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEcuaciones2.ForeColor = System.Drawing.Color.White;
            this.btnEcuaciones2.Location = new System.Drawing.Point(80, 123);
            this.btnEcuaciones2.Margin = new System.Windows.Forms.Padding(4);
            this.btnEcuaciones2.Name = "btnEcuaciones2";
            this.btnEcuaciones2.Size = new System.Drawing.Size(373, 86);
            this.btnEcuaciones2.TabIndex = 0;
            this.btnEcuaciones2.Text = "Ecuaciones lineales de 2 incógnitas";
            this.btnEcuaciones2.UseVisualStyleBackColor = false;
            this.btnEcuaciones2.Click += new System.EventHandler(this.btnEcuaciones2_Click);
            this.btnEcuaciones2.MouseEnter += new System.EventHandler(this.btnEcuaciones2_MouseEnter);
            this.btnEcuaciones2.MouseLeave += new System.EventHandler(this.btnEcuaciones2_MouseLeave);
            // 
            // btnEcuaciones3
            // 
            this.btnEcuaciones3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnEcuaciones3.FlatAppearance.BorderSize = 0;
            this.btnEcuaciones3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEcuaciones3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEcuaciones3.ForeColor = System.Drawing.Color.White;
            this.btnEcuaciones3.Location = new System.Drawing.Point(80, 234);
            this.btnEcuaciones3.Margin = new System.Windows.Forms.Padding(4);
            this.btnEcuaciones3.Name = "btnEcuaciones3";
            this.btnEcuaciones3.Size = new System.Drawing.Size(373, 86);
            this.btnEcuaciones3.TabIndex = 1;
            this.btnEcuaciones3.Text = "Ecuaciones lineales de 3 incógnitas";
            this.btnEcuaciones3.UseVisualStyleBackColor = false;
            this.btnEcuaciones3.Click += new System.EventHandler(this.btnEcuaciones3_Click);
            this.btnEcuaciones3.MouseEnter += new System.EventHandler(this.btnEcuaciones3_MouseEnter);
            this.btnEcuaciones3.MouseLeave += new System.EventHandler(this.btnEcuaciones3_MouseLeave);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(533, 98);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Seleccione un método";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cramer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(533, 369);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnEcuaciones3);
            this.Controls.Add(this.btnEcuaciones2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Cramer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.Cramer_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}