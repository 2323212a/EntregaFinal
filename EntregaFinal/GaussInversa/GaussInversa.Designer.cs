namespace EntregaFinal
{
    partial class GaussInversa
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnmatriz2x2 = new System.Windows.Forms.Button();
            this.btnmatriz3x3 = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnmatriz2x2
            // 
            this.btnmatriz2x2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnmatriz2x2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnmatriz2x2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmatriz2x2.Location = new System.Drawing.Point(74, 109);
            this.btnmatriz2x2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnmatriz2x2.Name = "btnmatriz2x2";
            this.btnmatriz2x2.Size = new System.Drawing.Size(88, 38);
            this.btnmatriz2x2.TabIndex = 0;
            this.btnmatriz2x2.Text = "2x2";
            this.btnmatriz2x2.UseVisualStyleBackColor = false;
            this.btnmatriz2x2.Click += new System.EventHandler(this.btnmatriz2x2_Click);
            // 
            // btnmatriz3x3
            // 
            this.btnmatriz3x3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnmatriz3x3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnmatriz3x3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmatriz3x3.Location = new System.Drawing.Point(267, 109);
            this.btnmatriz3x3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnmatriz3x3.Name = "btnmatriz3x3";
            this.btnmatriz3x3.Size = new System.Drawing.Size(88, 37);
            this.btnmatriz3x3.TabIndex = 1;
            this.btnmatriz3x3.Text = "3x3";
            this.btnmatriz3x3.UseVisualStyleBackColor = false;
            this.btnmatriz3x3.Click += new System.EventHandler(this.btnmatriz3x3_Click_1);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnsalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnsalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsalir.Location = new System.Drawing.Point(157, 221);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(113, 33);
            this.btnsalir.TabIndex = 2;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-11, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 72);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Selecciona el tamaño del sistema";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(437, 304);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnmatriz3x3);
            this.Controls.Add(this.btnmatriz2x2);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnmatriz2x2;
        private System.Windows.Forms.Button btnmatriz3x3;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

