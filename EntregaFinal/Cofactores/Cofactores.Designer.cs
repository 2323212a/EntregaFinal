namespace EntregaFinal
{
    partial class Cofactores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cofactores));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpDimension = new System.Windows.Forms.GroupBox();
            this.rdb3x3 = new System.Windows.Forms.RadioButton();
            this.rdb2x2 = new System.Windows.Forms.RadioButton();
            this.dgvMatriz = new System.Windows.Forms.DataGridView();
            this.btnResolver = new System.Windows.Forms.Button();
            this.grpResultados = new System.Windows.Forms.GroupBox();
            this.txtResultados = new System.Windows.Forms.TextBox();
            this.btnCorregir = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblConfirmacion = new System.Windows.Forms.Label();
            this.pbSistema2x2 = new System.Windows.Forms.PictureBox();
            this.pbSistema3x3 = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblindicaciones = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpDimension.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            this.grpResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSistema2x2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSistema3x3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitulo.Location = new System.Drawing.Point(112, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(687, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Resolver Sistemas de Ecuaciones Por Cofactores";
            // 
            // grpDimension
            // 
            this.grpDimension.BackColor = System.Drawing.Color.Transparent;
            this.grpDimension.Controls.Add(this.rdb3x3);
            this.grpDimension.Controls.Add(this.rdb2x2);
            this.grpDimension.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDimension.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.grpDimension.Location = new System.Drawing.Point(41, 60);
            this.grpDimension.Name = "grpDimension";
            this.grpDimension.Size = new System.Drawing.Size(272, 69);
            this.grpDimension.TabIndex = 1;
            this.grpDimension.TabStop = false;
            this.grpDimension.Text = "Dimension del sistema";
            // 
            // rdb3x3
            // 
            this.rdb3x3.AutoSize = true;
            this.rdb3x3.Location = new System.Drawing.Point(81, 31);
            this.rdb3x3.Name = "rdb3x3";
            this.rdb3x3.Size = new System.Drawing.Size(61, 28);
            this.rdb3x3.TabIndex = 3;
            this.rdb3x3.TabStop = true;
            this.rdb3x3.Text = "3x3";
            this.rdb3x3.UseVisualStyleBackColor = true;
            this.rdb3x3.CheckedChanged += new System.EventHandler(this.rdb3x3_CheckedChanged);
            // 
            // rdb2x2
            // 
            this.rdb2x2.AutoSize = true;
            this.rdb2x2.Location = new System.Drawing.Point(6, 30);
            this.rdb2x2.Name = "rdb2x2";
            this.rdb2x2.Size = new System.Drawing.Size(61, 28);
            this.rdb2x2.TabIndex = 2;
            this.rdb2x2.TabStop = true;
            this.rdb2x2.Text = "2x2";
            this.rdb2x2.UseVisualStyleBackColor = true;
            this.rdb2x2.CheckedChanged += new System.EventHandler(this.rdb2x2_CheckedChanged);
            // 
            // dgvMatriz
            // 
            this.dgvMatriz.BackgroundColor = System.Drawing.Color.DarkGoldenrod;
            this.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvMatriz.Location = new System.Drawing.Point(41, 135);
            this.dgvMatriz.Name = "dgvMatriz";
            this.dgvMatriz.RowHeadersWidth = 51;
            this.dgvMatriz.RowTemplate.Height = 24;
            this.dgvMatriz.Size = new System.Drawing.Size(353, 118);
            this.dgvMatriz.TabIndex = 2;
            // 
            // btnResolver
            // 
            this.btnResolver.BackColor = System.Drawing.Color.OliveDrab;
            this.btnResolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResolver.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResolver.Location = new System.Drawing.Point(41, 280);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(128, 34);
            this.btnResolver.TabIndex = 3;
            this.btnResolver.Text = "Resolver sistema";
            this.btnResolver.UseVisualStyleBackColor = false;
            this.btnResolver.Click += new System.EventHandler(this.btnResolver_Click);
            // 
            // grpResultados
            // 
            this.grpResultados.BackColor = System.Drawing.Color.Transparent;
            this.grpResultados.Controls.Add(this.txtResultados);
            this.grpResultados.Controls.Add(this.btnCorregir);
            this.grpResultados.Controls.Add(this.btnConfirmar);
            this.grpResultados.Controls.Add(this.lblConfirmacion);
            this.grpResultados.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpResultados.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpResultados.Location = new System.Drawing.Point(41, 341);
            this.grpResultados.Name = "grpResultados";
            this.grpResultados.Size = new System.Drawing.Size(604, 225);
            this.grpResultados.TabIndex = 4;
            this.grpResultados.TabStop = false;
            this.grpResultados.Text = "Resultados y confirmación";
            // 
            // txtResultados
            // 
            this.txtResultados.Location = new System.Drawing.Point(311, 28);
            this.txtResultados.Multiline = true;
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.Size = new System.Drawing.Size(260, 180);
            this.txtResultados.TabIndex = 5;
            // 
            // btnCorregir
            // 
            this.btnCorregir.BackColor = System.Drawing.Color.Firebrick;
            this.btnCorregir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorregir.ForeColor = System.Drawing.Color.Black;
            this.btnCorregir.Location = new System.Drawing.Point(148, 85);
            this.btnCorregir.Name = "btnCorregir";
            this.btnCorregir.Size = new System.Drawing.Size(105, 36);
            this.btnCorregir.TabIndex = 6;
            this.btnCorregir.Text = "Corregir";
            this.btnCorregir.UseVisualStyleBackColor = false;
            this.btnCorregir.Visible = false;
            this.btnCorregir.Click += new System.EventHandler(this.btnCorregir_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmar.Location = new System.Drawing.Point(10, 85);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(132, 36);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Visible = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblConfirmacion
            // 
            this.lblConfirmacion.AutoSize = true;
            this.lblConfirmacion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblConfirmacion.Location = new System.Drawing.Point(16, 58);
            this.lblConfirmacion.Name = "lblConfirmacion";
            this.lblConfirmacion.Size = new System.Drawing.Size(223, 24);
            this.lblConfirmacion.TabIndex = 5;
            this.lblConfirmacion.Text = "¿Son correctos los datos?";
            // 
            // pbSistema2x2
            // 
            this.pbSistema2x2.Image = ((System.Drawing.Image)(resources.GetObject("pbSistema2x2.Image")));
            this.pbSistema2x2.Location = new System.Drawing.Point(449, 151);
            this.pbSistema2x2.Name = "pbSistema2x2";
            this.pbSistema2x2.Size = new System.Drawing.Size(270, 69);
            this.pbSistema2x2.TabIndex = 5;
            this.pbSistema2x2.TabStop = false;
            this.pbSistema2x2.Visible = false;
            // 
            // pbSistema3x3
            // 
            this.pbSistema3x3.Image = ((System.Drawing.Image)(resources.GetObject("pbSistema3x3.Image")));
            this.pbSistema3x3.Location = new System.Drawing.Point(449, 144);
            this.pbSistema3x3.Name = "pbSistema3x3";
            this.pbSistema3x3.Size = new System.Drawing.Size(351, 109);
            this.pbSistema3x3.TabIndex = 6;
            this.pbSistema3x3.TabStop = false;
            this.pbSistema3x3.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Firebrick;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(175, 280);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(128, 34);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar todo";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblindicaciones
            // 
            this.lblindicaciones.AutoSize = true;
            this.lblindicaciones.BackColor = System.Drawing.Color.Transparent;
            this.lblindicaciones.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblindicaciones.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblindicaciones.Location = new System.Drawing.Point(440, 117);
            this.lblindicaciones.Name = "lblindicaciones";
            this.lblindicaciones.Size = new System.Drawing.Size(374, 24);
            this.lblindicaciones.TabIndex = 8;
            this.lblindicaciones.Text = "Recuerda que un sistema tiene esta forma:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel5.Location = new System.Drawing.Point(-2, 572);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(905, 27);
            this.panel5.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel6.Location = new System.Drawing.Point(-5, 596);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(905, 31);
            this.panel6.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Location = new System.Drawing.Point(1, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(902, 58);
            this.panel2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(898, 621);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lblindicaciones);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.pbSistema3x3);
            this.Controls.Add(this.pbSistema2x2);
            this.Controls.Add(this.grpResultados);
            this.Controls.Add(this.btnResolver);
            this.Controls.Add(this.dgvMatriz);
            this.Controls.Add(this.grpDimension);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpDimension.ResumeLayout(false);
            this.grpDimension.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            this.grpResultados.ResumeLayout(false);
            this.grpResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSistema2x2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSistema3x3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpDimension;
        private System.Windows.Forms.RadioButton rdb3x3;
        private System.Windows.Forms.RadioButton rdb2x2;
        private System.Windows.Forms.DataGridView dgvMatriz;
        private System.Windows.Forms.Button btnResolver;
        private System.Windows.Forms.GroupBox grpResultados;
        private System.Windows.Forms.Label lblConfirmacion;
        private System.Windows.Forms.TextBox txtResultados;
        private System.Windows.Forms.Button btnCorregir;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.PictureBox pbSistema2x2;
        private System.Windows.Forms.PictureBox pbSistema3x3;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblindicaciones;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

