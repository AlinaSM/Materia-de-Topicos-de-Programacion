namespace Actividad1VincularControles
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.telefonosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsTelefonos = new Actividad1VincularControles.dsTelefonos();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.txbTelefono = new System.Windows.Forms.TextBox();
            this.txbNotas = new System.Windows.Forms.TextBox();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.etPosicion = new System.Windows.Forms.Label();
            this.telefonosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telefonosTableAdapter = new Actividad1VincularControles.dsTelefonosTableAdapters.telefonosTableAdapter();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txbBuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTelefonos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Direccion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Notas:";
            // 
            // txbNombre
            // 
            this.txbNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefonosBindingSource1, "nombre", true));
            this.txbNombre.Location = new System.Drawing.Point(112, 36);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(257, 20);
            this.txbNombre.TabIndex = 4;
            // 
            // telefonosBindingSource1
            // 
            this.telefonosBindingSource1.DataMember = "telefonos";
            this.telefonosBindingSource1.DataSource = this.dsTelefonos;
            // 
            // dsTelefonos
            // 
            this.dsTelefonos.DataSetName = "dsTelefonos";
            this.dsTelefonos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txbDireccion
            // 
            this.txbDireccion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefonosBindingSource1, "direccion", true));
            this.txbDireccion.Location = new System.Drawing.Point(112, 70);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(257, 20);
            this.txbDireccion.TabIndex = 5;
            // 
            // txbTelefono
            // 
            this.txbTelefono.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefonosBindingSource1, "telefono", true));
            this.txbTelefono.Location = new System.Drawing.Point(115, 111);
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.Size = new System.Drawing.Size(84, 20);
            this.txbTelefono.TabIndex = 6;
            // 
            // txbNotas
            // 
            this.txbNotas.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefonosBindingSource1, "observaciones", true));
            this.txbNotas.Location = new System.Drawing.Point(115, 143);
            this.txbNotas.Multiline = true;
            this.txbNotas.Name = "txbNotas";
            this.txbNotas.Size = new System.Drawing.Size(257, 39);
            this.txbNotas.TabIndex = 7;
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(19, 207);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(84, 23);
            this.btnPrimero.TabIndex = 8;
            this.btnPrimero.Text = "Primero";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(109, 207);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(84, 23);
            this.btnAnterior.TabIndex = 9;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(308, 207);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(84, 23);
            this.btnSiguiente.TabIndex = 10;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(398, 207);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(84, 23);
            this.btnUltimo.TabIndex = 11;
            this.btnUltimo.Text = "Ultimo";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // etPosicion
            // 
            this.etPosicion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.etPosicion.Location = new System.Drawing.Point(199, 207);
            this.etPosicion.Name = "etPosicion";
            this.etPosicion.Size = new System.Drawing.Size(103, 23);
            this.etPosicion.TabIndex = 12;
            this.etPosicion.Text = "No Registros";
            this.etPosicion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // telefonosBindingSource
            // 
            this.telefonosBindingSource.DataSource = this.dsTelefonos;
            this.telefonosBindingSource.Position = 0;
            // 
            // telefonosTableAdapter
            // 
            this.telefonosTableAdapter.ClearBeforeFill = true;
            // 
            // btnAnadir
            // 
            this.btnAnadir.Location = new System.Drawing.Point(398, 31);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(84, 23);
            this.btnAnadir.TabIndex = 13;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(398, 68);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(84, 23);
            this.btnBorrar.TabIndex = 14;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(398, 146);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 23);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txbBuscar
            // 
            this.txbBuscar.Location = new System.Drawing.Point(398, 107);
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.Size = new System.Drawing.Size(84, 20);
            this.txbBuscar.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Buscar:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 252);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.etPosicion);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.txbNotas);
            this.Controls.Add(this.txbTelefono);
            this.Controls.Add(this.txbDireccion);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.telefonosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTelefonos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.TextBox txbTelefono;
        private System.Windows.Forms.TextBox txbNotas;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Label etPosicion;
        private System.Windows.Forms.BindingSource telefonosBindingSource;
        private dsTelefonos dsTelefonos;
        private dsTelefonosTableAdapters.telefonosTableAdapter telefonosTableAdapter;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txbBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource telefonosBindingSource1;
    }
}

