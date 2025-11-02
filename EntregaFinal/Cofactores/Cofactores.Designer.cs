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
            lblTitulo = new System.Windows.Forms.Label();
            grpDimension = new System.Windows.Forms.GroupBox();
            rdb3x3 = new System.Windows.Forms.RadioButton();
            rdb2x2 = new System.Windows.Forms.RadioButton();
            dgvMatriz = new System.Windows.Forms.DataGridView();
            btnResolver = new System.Windows.Forms.Button();
            grpResultados = new System.Windows.Forms.GroupBox();
            txtResultados = new System.Windows.Forms.TextBox();
            btnCorregir = new System.Windows.Forms.Button();
            btnConfirmar = new System.Windows.Forms.Button();
            lblConfirmacion = new System.Windows.Forms.Label();
            pbSistema2x2 = new System.Windows.Forms.PictureBox();
            pbSistema3x3 = new System.Windows.Forms.PictureBox();
            btnLimpiar = new System.Windows.Forms.Button();
            lblindicaciones = new System.Windows.Forms.Label();
            panel5 = new System.Windows.Forms.Panel();
            panel6 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            btnMainMenu = new System.Windows.Forms.Button();
            grpDimension.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatriz).BeginInit();
            grpResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSistema2x2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSistema3x3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = System.Drawing.Color.Transparent;
            lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = System.Drawing.Color.MidnightBlue;
            lblTitulo.Location = new System.Drawing.Point(112, 16);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(687, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Resolver Sistemas de Ecuaciones Por Cofactores";
            // 
            // grpDimension
            // 
            grpDimension.BackColor = System.Drawing.Color.DarkGoldenrod;
            grpDimension.Controls.Add(rdb3x3);
            grpDimension.Controls.Add(rdb2x2);
            grpDimension.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            grpDimension.ForeColor = System.Drawing.Color.AntiqueWhite;
            grpDimension.Location = new System.Drawing.Point(41, 75);
            grpDimension.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grpDimension.Name = "grpDimension";
            grpDimension.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grpDimension.Size = new System.Drawing.Size(272, 86);
            grpDimension.TabIndex = 1;
            grpDimension.TabStop = false;
            grpDimension.Text = "Dimension del sistema";
            // 
            // rdb3x3
            // 
            rdb3x3.AutoSize = true;
            rdb3x3.Location = new System.Drawing.Point(81, 39);
            rdb3x3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            rdb3x3.Name = "rdb3x3";
            rdb3x3.Size = new System.Drawing.Size(61, 28);
            rdb3x3.TabIndex = 3;
            rdb3x3.TabStop = true;
            rdb3x3.Text = "3x3";
            rdb3x3.UseVisualStyleBackColor = true;
            rdb3x3.CheckedChanged += rdb3x3_CheckedChanged;
            // 
            // rdb2x2
            // 
            rdb2x2.AutoSize = true;
            rdb2x2.Location = new System.Drawing.Point(6, 38);
            rdb2x2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            rdb2x2.Name = "rdb2x2";
            rdb2x2.Size = new System.Drawing.Size(61, 28);
            rdb2x2.TabIndex = 2;
            rdb2x2.TabStop = true;
            rdb2x2.Text = "2x2";
            rdb2x2.UseVisualStyleBackColor = true;
            rdb2x2.CheckedChanged += rdb2x2_CheckedChanged;
            // 
            // dgvMatriz
            // 
            dgvMatriz.BackgroundColor = System.Drawing.Color.DarkGoldenrod;
            dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatriz.GridColor = System.Drawing.SystemColors.ActiveBorder;
            dgvMatriz.Location = new System.Drawing.Point(41, 169);
            dgvMatriz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvMatriz.Name = "dgvMatriz";
            dgvMatriz.RowHeadersWidth = 51;
            dgvMatriz.RowTemplate.Height = 24;
            dgvMatriz.Size = new System.Drawing.Size(353, 148);
            dgvMatriz.TabIndex = 2;
            // 
            // btnResolver
            // 
            btnResolver.BackColor = System.Drawing.Color.OliveDrab;
            btnResolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnResolver.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnResolver.Location = new System.Drawing.Point(41, 350);
            btnResolver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnResolver.Name = "btnResolver";
            btnResolver.Size = new System.Drawing.Size(128, 42);
            btnResolver.TabIndex = 3;
            btnResolver.Text = "Resolver sistema";
            btnResolver.UseVisualStyleBackColor = false;
            btnResolver.Click += btnResolver_Click;
            // 
            // grpResultados
            // 
            grpResultados.BackColor = System.Drawing.Color.DarkGoldenrod;
            grpResultados.Controls.Add(txtResultados);
            grpResultados.Controls.Add(btnCorregir);
            grpResultados.Controls.Add(btnConfirmar);
            grpResultados.Controls.Add(lblConfirmacion);
            grpResultados.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            grpResultados.ForeColor = System.Drawing.Color.WhiteSmoke;
            grpResultados.Location = new System.Drawing.Point(41, 426);
            grpResultados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grpResultados.Name = "grpResultados";
            grpResultados.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grpResultados.Size = new System.Drawing.Size(604, 281);
            grpResultados.TabIndex = 4;
            grpResultados.TabStop = false;
            grpResultados.Text = "Resultados y confirmación";
            // 
            // txtResultados
            // 
            txtResultados.Location = new System.Drawing.Point(311, 35);
            txtResultados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtResultados.Multiline = true;
            txtResultados.Name = "txtResultados";
            txtResultados.Size = new System.Drawing.Size(260, 224);
            txtResultados.TabIndex = 5;
            // 
            // btnCorregir
            // 
            btnCorregir.BackColor = System.Drawing.Color.Firebrick;
            btnCorregir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCorregir.ForeColor = System.Drawing.Color.Black;
            btnCorregir.Location = new System.Drawing.Point(148, 106);
            btnCorregir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCorregir.Name = "btnCorregir";
            btnCorregir.Size = new System.Drawing.Size(105, 45);
            btnCorregir.TabIndex = 6;
            btnCorregir.Text = "Corregir";
            btnCorregir.UseVisualStyleBackColor = false;
            btnCorregir.Visible = false;
            btnCorregir.Click += btnCorregir_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = System.Drawing.Color.OliveDrab;
            btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConfirmar.ForeColor = System.Drawing.Color.Black;
            btnConfirmar.Location = new System.Drawing.Point(10, 106);
            btnConfirmar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new System.Drawing.Size(132, 45);
            btnConfirmar.TabIndex = 5;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Visible = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblConfirmacion
            // 
            lblConfirmacion.AutoSize = true;
            lblConfirmacion.ForeColor = System.Drawing.Color.WhiteSmoke;
            lblConfirmacion.Location = new System.Drawing.Point(16, 72);
            lblConfirmacion.Name = "lblConfirmacion";
            lblConfirmacion.Size = new System.Drawing.Size(223, 24);
            lblConfirmacion.TabIndex = 5;
            lblConfirmacion.Text = "¿Son correctos los datos?";
            // 
            // pbSistema2x2
            // 
            pbSistema2x2.Image = (System.Drawing.Image)resources.GetObject("pbSistema2x2.Image");
            pbSistema2x2.Location = new System.Drawing.Point(449, 194);
            pbSistema2x2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pbSistema2x2.Name = "pbSistema2x2";
            pbSistema2x2.Size = new System.Drawing.Size(209, 49);
            pbSistema2x2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pbSistema2x2.TabIndex = 5;
            pbSistema2x2.TabStop = false;
            pbSistema2x2.Visible = false;
            pbSistema2x2.Click += pbSistema2x2_Click;
            // 
            // pbSistema3x3
            // 
            pbSistema3x3.Image = (System.Drawing.Image)resources.GetObject("pbSistema3x3.Image");
            pbSistema3x3.Location = new System.Drawing.Point(449, 184);
            pbSistema3x3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pbSistema3x3.Name = "pbSistema3x3";
            pbSistema3x3.Size = new System.Drawing.Size(259, 90);
            pbSistema3x3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pbSistema3x3.TabIndex = 6;
            pbSistema3x3.TabStop = false;
            pbSistema3x3.Visible = false;
            pbSistema3x3.Click += pbSistema3x3_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = System.Drawing.Color.Firebrick;
            btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLimpiar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnLimpiar.Location = new System.Drawing.Point(175, 350);
            btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(128, 42);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar todo";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblindicaciones
            // 
            lblindicaciones.AutoSize = true;
            lblindicaciones.BackColor = System.Drawing.Color.Transparent;
            lblindicaciones.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblindicaciones.ForeColor = System.Drawing.Color.WhiteSmoke;
            lblindicaciones.Location = new System.Drawing.Point(440, 146);
            lblindicaciones.Name = "lblindicaciones";
            lblindicaciones.Size = new System.Drawing.Size(374, 24);
            lblindicaciones.TabIndex = 8;
            lblindicaciones.Text = "Recuerda que un sistema tiene esta forma:";
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.Color.MidnightBlue;
            panel5.Location = new System.Drawing.Point(-2, 715);
            panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(905, 34);
            panel5.TabIndex = 10;
            // 
            // panel6
            // 
            panel6.BackColor = System.Drawing.Color.DarkGoldenrod;
            panel6.Location = new System.Drawing.Point(-5, 745);
            panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(905, 39);
            panel6.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.DarkGoldenrod;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lblTitulo);
            panel2.Location = new System.Drawing.Point(1, -5);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(902, 72);
            panel2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(14, 4);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(93, 64);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // btnMainMenu
            // 
            btnMainMenu.BackColor = System.Drawing.Color.RoyalBlue;
            btnMainMenu.Location = new System.Drawing.Point(773, 656);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new System.Drawing.Size(94, 29);
            btnMainMenu.TabIndex = 12;
            btnMainMenu.Text = "Regresar";
            btnMainMenu.UseVisualStyleBackColor = false;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // Cofactores
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DarkGoldenrod;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            ClientSize = new System.Drawing.Size(898, 776);
            Controls.Add(btnMainMenu);
            Controls.Add(panel2);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(lblindicaciones);
            Controls.Add(btnLimpiar);
            Controls.Add(pbSistema3x3);
            Controls.Add(pbSistema2x2);
            Controls.Add(grpResultados);
            Controls.Add(btnResolver);
            Controls.Add(dgvMatriz);
            Controls.Add(grpDimension);
            DoubleBuffered = true;
            ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Cofactores";
            Text = "Form1";
            grpDimension.ResumeLayout(false);
            grpDimension.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatriz).EndInit();
            grpResultados.ResumeLayout(false);
            grpResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSistema2x2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSistema3x3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

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
        private System.Windows.Forms.Button btnMainMenu;
    }
}

