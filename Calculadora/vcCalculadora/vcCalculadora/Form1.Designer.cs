namespace vcCalculadora
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.etPantalla = new System.Windows.Forms.Label();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btPunto = new System.Windows.Forms.Button();
            this.Iniciar = new System.Windows.Forms.Button();
            this.btBorrarEntrada = new System.Windows.Forms.Button();
            this.btMenos = new System.Windows.Forms.Button();
            this.btDividir = new System.Windows.Forms.Button();
            this.btMas = new System.Windows.Forms.Button();
            this.btPor = new System.Windows.Forms.Button();
            this.btTantoPorCiento = new System.Windows.Forms.Button();
            this.btIgual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // etPantalla
            // 
            this.etPantalla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(100)))));
            this.etPantalla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.etPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etPantalla.Location = new System.Drawing.Point(11, 10);
            this.etPantalla.Name = "etPantalla";
            this.etPantalla.Size = new System.Drawing.Size(300, 40);
            this.etPantalla.TabIndex = 0;
            this.etPantalla.Text = "0.";
            this.etPantalla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bt7
            // 
            this.bt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7.Location = new System.Drawing.Point(14, 64);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(50, 49);
            this.bt7.TabIndex = 1;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.btDigito_Click);
            // 
            // bt8
            // 
            this.bt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt8.Location = new System.Drawing.Point(70, 64);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(50, 49);
            this.bt8.TabIndex = 2;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.btDigito_Click);
            // 
            // bt9
            // 
            this.bt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt9.Location = new System.Drawing.Point(126, 64);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(50, 49);
            this.bt9.TabIndex = 3;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.btDigito_Click);
            // 
            // bt4
            // 
            this.bt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.Location = new System.Drawing.Point(12, 119);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(50, 49);
            this.bt4.TabIndex = 4;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.btDigito_Click);
            // 
            // bt5
            // 
            this.bt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.Location = new System.Drawing.Point(70, 119);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(50, 49);
            this.bt5.TabIndex = 5;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.btDigito_Click);
            // 
            // bt6
            // 
            this.bt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.Location = new System.Drawing.Point(126, 119);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(50, 49);
            this.bt6.TabIndex = 6;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.btDigito_Click);
            // 
            // bt1
            // 
            this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(12, 174);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(50, 49);
            this.bt1.TabIndex = 7;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.btDigito_Click);
            // 
            // bt2
            // 
            this.bt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.Location = new System.Drawing.Point(70, 174);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(50, 49);
            this.bt2.TabIndex = 8;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.btDigito_Click);
            // 
            // bt3
            // 
            this.bt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.Location = new System.Drawing.Point(126, 174);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(50, 49);
            this.bt3.TabIndex = 9;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.btDigito_Click);
            // 
            // bt0
            // 
            this.bt0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt0.Location = new System.Drawing.Point(14, 229);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(106, 49);
            this.bt0.TabIndex = 10;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.btDigito_Click);
            // 
            // btPunto
            // 
            this.btPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPunto.Location = new System.Drawing.Point(126, 229);
            this.btPunto.Name = "btPunto";
            this.btPunto.Size = new System.Drawing.Size(50, 49);
            this.btPunto.TabIndex = 11;
            this.btPunto.Text = ".";
            this.btPunto.UseVisualStyleBackColor = true;
            this.btPunto.Click += new System.EventHandler(this.btPunto_Click);
            // 
            // Iniciar
            // 
            this.Iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iniciar.Location = new System.Drawing.Point(207, 64);
            this.Iniciar.Name = "Iniciar";
            this.Iniciar.Size = new System.Drawing.Size(50, 49);
            this.Iniciar.TabIndex = 12;
            this.Iniciar.Text = "C";
            this.Iniciar.UseVisualStyleBackColor = true;
            this.Iniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // btBorrarEntrada
            // 
            this.btBorrarEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBorrarEntrada.Location = new System.Drawing.Point(263, 64);
            this.btBorrarEntrada.Name = "btBorrarEntrada";
            this.btBorrarEntrada.Size = new System.Drawing.Size(50, 49);
            this.btBorrarEntrada.TabIndex = 13;
            this.btBorrarEntrada.Text = "CE";
            this.btBorrarEntrada.UseVisualStyleBackColor = true;
            this.btBorrarEntrada.Click += new System.EventHandler(this.btBorrarEntrada_Click);
            // 
            // btMenos
            // 
            this.btMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenos.Location = new System.Drawing.Point(263, 119);
            this.btMenos.Name = "btMenos";
            this.btMenos.Size = new System.Drawing.Size(50, 49);
            this.btMenos.TabIndex = 15;
            this.btMenos.Text = "-";
            this.btMenos.UseVisualStyleBackColor = true;
            this.btMenos.Click += new System.EventHandler(this.btOperacion_Click);
            // 
            // btDividir
            // 
            this.btDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDividir.Location = new System.Drawing.Point(207, 119);
            this.btDividir.Name = "btDividir";
            this.btDividir.Size = new System.Drawing.Size(50, 49);
            this.btDividir.TabIndex = 14;
            this.btDividir.Text = "/";
            this.btDividir.UseVisualStyleBackColor = true;
            this.btDividir.Click += new System.EventHandler(this.btOperacion_Click);
            // 
            // btMas
            // 
            this.btMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMas.Location = new System.Drawing.Point(263, 174);
            this.btMas.Name = "btMas";
            this.btMas.Size = new System.Drawing.Size(50, 49);
            this.btMas.TabIndex = 17;
            this.btMas.Text = "+";
            this.btMas.UseVisualStyleBackColor = true;
            this.btMas.Click += new System.EventHandler(this.btOperacion_Click);
            // 
            // btPor
            // 
            this.btPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPor.Location = new System.Drawing.Point(207, 174);
            this.btPor.Name = "btPor";
            this.btPor.Size = new System.Drawing.Size(50, 49);
            this.btPor.TabIndex = 16;
            this.btPor.Text = "x";
            this.btPor.UseVisualStyleBackColor = true;
            this.btPor.Click += new System.EventHandler(this.btOperacion_Click);
            // 
            // btTantoPorCiento
            // 
            this.btTantoPorCiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTantoPorCiento.Location = new System.Drawing.Point(263, 229);
            this.btTantoPorCiento.Name = "btTantoPorCiento";
            this.btTantoPorCiento.Size = new System.Drawing.Size(50, 49);
            this.btTantoPorCiento.TabIndex = 19;
            this.btTantoPorCiento.Text = "%";
            this.btTantoPorCiento.UseVisualStyleBackColor = true;
            this.btTantoPorCiento.Click += new System.EventHandler(this.btTantoPorCiento_Click);
            // 
            // btIgual
            // 
            this.btIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIgual.Location = new System.Drawing.Point(207, 229);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(50, 49);
            this.btIgual.TabIndex = 18;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = true;
            this.btIgual.Click += new System.EventHandler(this.btOperacion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(325, 303);
            this.Controls.Add(this.btTantoPorCiento);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.btMas);
            this.Controls.Add(this.btPor);
            this.Controls.Add(this.btMenos);
            this.Controls.Add(this.btDividir);
            this.Controls.Add(this.btBorrarEntrada);
            this.Controls.Add(this.Iniciar);
            this.Controls.Add(this.btPunto);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.etPantalla);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label etPantalla;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btPunto;
        private System.Windows.Forms.Button Iniciar;
        private System.Windows.Forms.Button btBorrarEntrada;
        private System.Windows.Forms.Button btMenos;
        private System.Windows.Forms.Button btDividir;
        private System.Windows.Forms.Button btMas;
        private System.Windows.Forms.Button btPor;
        private System.Windows.Forms.Button btTantoPorCiento;
        private System.Windows.Forms.Button btIgual;
    }
}

