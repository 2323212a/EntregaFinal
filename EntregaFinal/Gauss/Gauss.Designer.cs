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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.lblResultados = new System.Windows.Forms.Label();
            this.dgvMatriz = new System.Windows.Forms.DataGridView();
            this.btnResolver = new System.Windows.Forms.Button();
            this.txtResultados = new System.Windows.Forms.RichTextBox();
            this.lblEcuaciones = new System.Windows.Forms.Label();
            this.txtEcuaciones = new System.Windows.Forms.TextBox();
            this.lblVariables = new System.Windows.Forms.Label();
            this.txtVariables = new System.Windows.Forms.TextBox();
            this.btnCrearMatriz = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(471, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(180, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Solucionador de Ecuaciones";
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.AutoSize = true;
            this.lblInstrucciones.Location = new System.Drawing.Point(72, 118);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(179, 16);
            this.lblInstrucciones.TabIndex = 1;
            this.lblInstrucciones.Text = "Ingresa la matriz del sistema:";
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Location = new System.Drawing.Point(764, 169);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(79, 16);
            this.lblResultados.TabIndex = 2;
            this.lblResultados.Text = "Resultados:";
            // 
            // dgvMatriz
            // 
            this.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz.Location = new System.Drawing.Point(302, 55);
            this.dgvMatriz.Name = "dgvMatriz";
            this.dgvMatriz.RowHeadersWidth = 51;
            this.dgvMatriz.RowTemplate.Height = 24;
            this.dgvMatriz.Size = new System.Drawing.Size(384, 223);
            this.dgvMatriz.TabIndex = 3;
            // 
            // btnResolver
            // 
            this.btnResolver.Location = new System.Drawing.Point(450, 308);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(107, 53);
            this.btnResolver.TabIndex = 4;
            this.btnResolver.Text = "Resolver";
            this.btnResolver.UseVisualStyleBackColor = true;
            this.btnResolver.Click += new System.EventHandler(this.btnResolver_Click);
            // 
            // txtResultados
            // 
            this.txtResultados.Location = new System.Drawing.Point(855, 55);
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.Size = new System.Drawing.Size(390, 223);
            this.txtResultados.TabIndex = 5;
            this.txtResultados.Text = "";
            // 
            // lblEcuaciones
            // 
            this.lblEcuaciones.AutoSize = true;
            this.lblEcuaciones.Location = new System.Drawing.Point(207, 186);
            this.lblEcuaciones.Name = "lblEcuaciones";
            this.lblEcuaciones.Size = new System.Drawing.Size(78, 16);
            this.lblEcuaciones.TabIndex = 6;
            this.lblEcuaciones.Text = "Ecuaciones";
            // 
            // txtEcuaciones
            // 
            this.txtEcuaciones.Location = new System.Drawing.Point(180, 227);
            this.txtEcuaciones.Name = "txtEcuaciones";
            this.txtEcuaciones.Size = new System.Drawing.Size(100, 22);
            this.txtEcuaciones.TabIndex = 7;
            // 
            // lblVariables
            // 
            this.lblVariables.AutoSize = true;
            this.lblVariables.Location = new System.Drawing.Point(28, 186);
            this.lblVariables.Name = "lblVariables";
            this.lblVariables.Size = new System.Drawing.Size(65, 16);
            this.lblVariables.TabIndex = 8;
            this.lblVariables.Text = "Variables";
            // 
            // txtVariables
            // 
            this.txtVariables.Location = new System.Drawing.Point(31, 227);
            this.txtVariables.Name = "txtVariables";
            this.txtVariables.Size = new System.Drawing.Size(100, 22);
            this.txtVariables.TabIndex = 9;
            // 
            // btnCrearMatriz
            // 
            this.btnCrearMatriz.Location = new System.Drawing.Point(100, 281);
            this.btnCrearMatriz.Name = "btnCrearMatriz";
            this.btnCrearMatriz.Size = new System.Drawing.Size(118, 64);
            this.btnCrearMatriz.TabIndex = 10;
            this.btnCrearMatriz.Text = "Crear Matriz";
            this.btnCrearMatriz.UseVisualStyleBackColor = true;
            this.btnCrearMatriz.Click += new System.EventHandler(this.btnCrearMatriz_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(669, 367);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(266, 44);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCrearMatriz);
            this.Controls.Add(this.txtVariables);
            this.Controls.Add(this.lblVariables);
            this.Controls.Add(this.txtEcuaciones);
            this.Controls.Add(this.lblEcuaciones);
            this.Controls.Add(this.txtResultados);
            this.Controls.Add(this.btnResolver);
            this.Controls.Add(this.dgvMatriz);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.lblInstrucciones);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

