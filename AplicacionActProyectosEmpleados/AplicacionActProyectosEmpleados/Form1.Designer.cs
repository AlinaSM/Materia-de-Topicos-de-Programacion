namespace AplicacionActProyectosEmpleados
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
            this.btnIrProyectos = new System.Windows.Forms.Button();
            this.btnIrEmpleados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIrProyectos
            // 
            this.btnIrProyectos.Location = new System.Drawing.Point(59, 124);
            this.btnIrProyectos.Name = "btnIrProyectos";
            this.btnIrProyectos.Size = new System.Drawing.Size(145, 55);
            this.btnIrProyectos.TabIndex = 0;
            this.btnIrProyectos.Text = "Proyectos";
            this.btnIrProyectos.UseVisualStyleBackColor = true;
            this.btnIrProyectos.Click += new System.EventHandler(this.btnIrProyectos_Click);
            // 
            // btnIrEmpleados
            // 
            this.btnIrEmpleados.Location = new System.Drawing.Point(289, 124);
            this.btnIrEmpleados.Name = "btnIrEmpleados";
            this.btnIrEmpleados.Size = new System.Drawing.Size(145, 55);
            this.btnIrEmpleados.TabIndex = 1;
            this.btnIrEmpleados.Text = "Empleados";
            this.btnIrEmpleados.UseVisualStyleBackColor = true;
            this.btnIrEmpleados.Click += new System.EventHandler(this.btnIrEmpleados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 311);
            this.Controls.Add(this.btnIrEmpleados);
            this.Controls.Add(this.btnIrProyectos);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIrProyectos;
        private System.Windows.Forms.Button btnIrEmpleados;
    }
}

