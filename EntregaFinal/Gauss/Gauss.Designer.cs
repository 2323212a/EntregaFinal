namespace EntregaFinal
{
    partial class Gauss
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
            lblTitulo = new System.Windows.Forms.Label();
            lblInstrucciones = new System.Windows.Forms.Label();
            lblResultados = new System.Windows.Forms.Label();
            dgvMatriz = new System.Windows.Forms.DataGridView();
            btnResolver = new System.Windows.Forms.Button();
            txtResultados = new System.Windows.Forms.RichTextBox();
            lblEcuaciones = new System.Windows.Forms.Label();
            txtEcuaciones = new System.Windows.Forms.TextBox();
            lblVariables = new System.Windows.Forms.Label();
            txtVariables = new System.Windows.Forms.TextBox();
            btnCrearMatriz = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvMatriz).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new System.Drawing.Point(386, 29);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(195, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Solucionador de Ecuaciones";
            // 
            // lblInstrucciones
            // 
            lblInstrucciones.AutoSize = true;
            lblInstrucciones.Location = new System.Drawing.Point(31, 29);
            lblInstrucciones.Name = "lblInstrucciones";
            lblInstrucciones.Size = new System.Drawing.Size(201, 20);
            lblInstrucciones.TabIndex = 1;
            lblInstrucciones.Text = "Ingresa la matriz del sistema:";
            // 
            // lblResultados
            // 
            lblResultados.AutoSize = true;
            lblResultados.Location = new System.Drawing.Point(919, 11);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new System.Drawing.Size(84, 20);
            lblResultados.TabIndex = 2;
            lblResultados.Text = "Resultados:";
            // 
            // dgvMatriz
            // 
            dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatriz.Location = new System.Drawing.Point(386, 84);
            dgvMatriz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvMatriz.Name = "dgvMatriz";
            dgvMatriz.RowHeadersWidth = 51;
            dgvMatriz.RowTemplate.Height = 24;
            dgvMatriz.Size = new System.Drawing.Size(366, 279);
            dgvMatriz.TabIndex = 3;
            // 
            // btnResolver
            // 
            btnResolver.Location = new System.Drawing.Point(210, 417);
            btnResolver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnResolver.Name = "btnResolver";
            btnResolver.Size = new System.Drawing.Size(118, 80);
            btnResolver.TabIndex = 4;
            btnResolver.Text = "Resolver";
            btnResolver.UseVisualStyleBackColor = true;
            btnResolver.Click += btnResolver_Click;
            // 
            // txtResultados
            // 
            txtResultados.Location = new System.Drawing.Point(798, 84);
            txtResultados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtResultados.Name = "txtResultados";
            txtResultados.Size = new System.Drawing.Size(321, 279);
            txtResultados.TabIndex = 5;
            txtResultados.Text = "";
            // 
            // lblEcuaciones
            // 
            lblEcuaciones.AutoSize = true;
            lblEcuaciones.Location = new System.Drawing.Point(150, 92);
            lblEcuaciones.Name = "lblEcuaciones";
            lblEcuaciones.Size = new System.Drawing.Size(82, 20);
            lblEcuaciones.TabIndex = 6;
            lblEcuaciones.Text = "Ecuaciones";
            // 
            // txtEcuaciones
            // 
            txtEcuaciones.Location = new System.Drawing.Point(150, 134);
            txtEcuaciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtEcuaciones.Name = "txtEcuaciones";
            txtEcuaciones.Size = new System.Drawing.Size(82, 27);
            txtEcuaciones.TabIndex = 7;
            // 
            // lblVariables
            // 
            lblVariables.AutoSize = true;
            lblVariables.Location = new System.Drawing.Point(31, 92);
            lblVariables.Name = "lblVariables";
            lblVariables.Size = new System.Drawing.Size(69, 20);
            lblVariables.TabIndex = 8;
            lblVariables.Text = "Variables";
            // 
            // txtVariables
            // 
            txtVariables.Location = new System.Drawing.Point(31, 134);
            txtVariables.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtVariables.Name = "txtVariables";
            txtVariables.Size = new System.Drawing.Size(69, 27);
            txtVariables.TabIndex = 9;
            // 
            // btnCrearMatriz
            // 
            btnCrearMatriz.Location = new System.Drawing.Point(31, 417);
            btnCrearMatriz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCrearMatriz.Name = "btnCrearMatriz";
            btnCrearMatriz.Size = new System.Drawing.Size(118, 80);
            btnCrearMatriz.TabIndex = 10;
            btnCrearMatriz.Text = "Crear Matriz";
            btnCrearMatriz.UseVisualStyleBackColor = true;
            btnCrearMatriz.Click += btnCrearMatriz_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new System.Drawing.Point(416, 417);
            btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(266, 80);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Gauss
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.WindowFrame;
            ClientSize = new System.Drawing.Size(1321, 562);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCrearMatriz);
            Controls.Add(txtVariables);
            Controls.Add(lblVariables);
            Controls.Add(txtEcuaciones);
            Controls.Add(lblEcuaciones);
            Controls.Add(txtResultados);
            Controls.Add(btnResolver);
            Controls.Add(dgvMatriz);
            Controls.Add(lblResultados);
            Controls.Add(lblInstrucciones);
            Controls.Add(lblTitulo);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Gauss";
            Text = "Solucionador Gauss";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMatriz).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblInstrucciones;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.DataGridView dgvMatriz;
        private System.Windows.Forms.Button btnResolver;
        private System.Windows.Forms.RichTextBox txtResultados;
        private System.Windows.Forms.Label lblEcuaciones;
        private System.Windows.Forms.TextBox txtEcuaciones;
        private System.Windows.Forms.Label lblVariables;
        private System.Windows.Forms.TextBox txtVariables;
        private System.Windows.Forms.Button btnCrearMatriz;
        private System.Windows.Forms.Button btnLimpiar;
    }
}
