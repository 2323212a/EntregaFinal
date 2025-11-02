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
            btnmatriz2x2 = new System.Windows.Forms.Button();
            btnmatriz3x3 = new System.Windows.Forms.Button();
            btnsalir = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnmatriz2x2
            // 
            btnmatriz2x2.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            btnmatriz2x2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnmatriz2x2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnmatriz2x2.Location = new System.Drawing.Point(99, 168);
            btnmatriz2x2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            btnmatriz2x2.Name = "btnmatriz2x2";
            btnmatriz2x2.Size = new System.Drawing.Size(117, 58);
            btnmatriz2x2.TabIndex = 0;
            btnmatriz2x2.Text = "2x2";
            btnmatriz2x2.UseVisualStyleBackColor = false;
            btnmatriz2x2.Click += btnmatriz2x2_Click;
            // 
            // btnmatriz3x3
            // 
            btnmatriz3x3.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
            btnmatriz3x3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnmatriz3x3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnmatriz3x3.Location = new System.Drawing.Point(356, 168);
            btnmatriz3x3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            btnmatriz3x3.Name = "btnmatriz3x3";
            btnmatriz3x3.Size = new System.Drawing.Size(117, 57);
            btnmatriz3x3.TabIndex = 1;
            btnmatriz3x3.Text = "3x3";
            btnmatriz3x3.UseVisualStyleBackColor = false;
            btnmatriz3x3.Click += btnmatriz3x3_Click_1;
            // 
            // btnsalir
            // 
            btnsalir.BackColor = System.Drawing.SystemColors.MenuHighlight;
            btnsalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnsalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnsalir.Location = new System.Drawing.Point(209, 340);
            btnsalir.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new System.Drawing.Size(151, 51);
            btnsalir.TabIndex = 2;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(-15, -8);
            panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(828, 111);
            panel1.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(47, 35);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(479, 41);
            label1.TabIndex = 21;
            label1.Text = "Selecciona el tamaño del sistema";
            label1.Click += label1_Click;
            // 
            // GaussInversa
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            ClientSize = new System.Drawing.Size(583, 468);
            Controls.Add(panel1);
            Controls.Add(btnsalir);
            Controls.Add(btnmatriz3x3);
            Controls.Add(btnmatriz2x2);
            Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            Name = "GaussInversa";
            Text = "Form1";
            Load += GaussInversa_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnmatriz2x2;
        private System.Windows.Forms.Button btnmatriz3x3;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

