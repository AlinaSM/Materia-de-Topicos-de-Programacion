namespace FormasFiguras
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_LineasRectangulos = new System.Windows.Forms.Button();
            this.btn_ElipsesArcos = new System.Windows.Forms.Button();
            this.btn_Poligonos = new System.Windows.Forms.Button();
            this.btn_Tarta = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Regiones = new System.Windows.Forms.Button();
            this.btn_Trazados = new System.Windows.Forms.Button();
            this.btn_Curvas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_LineasRectangulos
            // 
            this.btn_LineasRectangulos.Location = new System.Drawing.Point(626, 87);
            this.btn_LineasRectangulos.Name = "btn_LineasRectangulos";
            this.btn_LineasRectangulos.Size = new System.Drawing.Size(117, 34);
            this.btn_LineasRectangulos.TabIndex = 0;
            this.btn_LineasRectangulos.Text = "Lineas y rectangulos";
            this.btn_LineasRectangulos.UseVisualStyleBackColor = true;
            this.btn_LineasRectangulos.Click += new System.EventHandler(this.btn_LineasRectangulos_Click);
            // 
            // btn_ElipsesArcos
            // 
            this.btn_ElipsesArcos.Location = new System.Drawing.Point(626, 129);
            this.btn_ElipsesArcos.Name = "btn_ElipsesArcos";
            this.btn_ElipsesArcos.Size = new System.Drawing.Size(117, 34);
            this.btn_ElipsesArcos.TabIndex = 1;
            this.btn_ElipsesArcos.Text = "Elipses y arcos";
            this.btn_ElipsesArcos.UseVisualStyleBackColor = true;
            this.btn_ElipsesArcos.Click += new System.EventHandler(this.btn_ElipsesArcos_Click);
            // 
            // btn_Poligonos
            // 
            this.btn_Poligonos.Location = new System.Drawing.Point(626, 207);
            this.btn_Poligonos.Name = "btn_Poligonos";
            this.btn_Poligonos.Size = new System.Drawing.Size(117, 34);
            this.btn_Poligonos.TabIndex = 3;
            this.btn_Poligonos.Text = "Poligonos";
            this.btn_Poligonos.UseVisualStyleBackColor = true;
            this.btn_Poligonos.Click += new System.EventHandler(this.btn_Poligonos_Click);
            // 
            // btn_Tarta
            // 
            this.btn_Tarta.Location = new System.Drawing.Point(626, 167);
            this.btn_Tarta.Name = "btn_Tarta";
            this.btn_Tarta.Size = new System.Drawing.Size(117, 34);
            this.btn_Tarta.TabIndex = 2;
            this.btn_Tarta.Text = "Tartas";
            this.btn_Tarta.UseVisualStyleBackColor = true;
            this.btn_Tarta.Click += new System.EventHandler(this.btn_Tartas_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(626, 367);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(117, 34);
            this.btn_Limpiar.TabIndex = 7;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Regiones
            // 
            this.btn_Regiones.Location = new System.Drawing.Point(626, 328);
            this.btn_Regiones.Name = "btn_Regiones";
            this.btn_Regiones.Size = new System.Drawing.Size(117, 34);
            this.btn_Regiones.TabIndex = 6;
            this.btn_Regiones.Text = "Regiones";
            this.btn_Regiones.UseVisualStyleBackColor = true;
            this.btn_Regiones.Click += new System.EventHandler(this.btn_Regiones_Click);
            // 
            // btn_Trazados
            // 
            this.btn_Trazados.Location = new System.Drawing.Point(626, 287);
            this.btn_Trazados.Name = "btn_Trazados";
            this.btn_Trazados.Size = new System.Drawing.Size(117, 34);
            this.btn_Trazados.TabIndex = 5;
            this.btn_Trazados.Text = "Trazados";
            this.btn_Trazados.UseVisualStyleBackColor = true;
            this.btn_Trazados.Click += new System.EventHandler(this.btn_Trazados_Click);
            // 
            // btn_Curvas
            // 
            this.btn_Curvas.Location = new System.Drawing.Point(626, 247);
            this.btn_Curvas.Name = "btn_Curvas";
            this.btn_Curvas.Size = new System.Drawing.Size(117, 34);
            this.btn_Curvas.TabIndex = 4;
            this.btn_Curvas.Text = "Curvas";
            this.btn_Curvas.UseVisualStyleBackColor = true;
            this.btn_Curvas.Click += new System.EventHandler(this.btn_Curvas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(28, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(549, 427);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 511);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Regiones);
            this.Controls.Add(this.btn_Trazados);
            this.Controls.Add(this.btn_Curvas);
            this.Controls.Add(this.btn_Poligonos);
            this.Controls.Add(this.btn_Tarta);
            this.Controls.Add(this.btn_ElipsesArcos);
            this.Controls.Add(this.btn_LineasRectangulos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_LineasRectangulos;
        private System.Windows.Forms.Button btn_ElipsesArcos;
        private System.Windows.Forms.Button btn_Poligonos;
        private System.Windows.Forms.Button btn_Tarta;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Regiones;
        private System.Windows.Forms.Button btn_Trazados;
        private System.Windows.Forms.Button btn_Curvas;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

