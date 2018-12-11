namespace JuegoPalabras
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
            this.btA = new System.Windows.Forms.Button();
            this.btE = new System.Windows.Forms.Button();
            this.btO = new System.Windows.Forms.Button();
            this.btB = new System.Windows.Forms.Button();
            this.btM = new System.Windows.Forms.Button();
            this.btC = new System.Windows.Forms.Button();
            this.btR = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.txtPalabra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPuntos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btA
            // 
            this.btA.Location = new System.Drawing.Point(37, 97);
            this.btA.Name = "btA";
            this.btA.Size = new System.Drawing.Size(56, 55);
            this.btA.TabIndex = 0;
            this.btA.Text = "A";
            this.btA.UseVisualStyleBackColor = true;
            this.btA.Click += new System.EventHandler(this.btA_Click);
            // 
            // btE
            // 
            this.btE.Location = new System.Drawing.Point(112, 97);
            this.btE.Name = "btE";
            this.btE.Size = new System.Drawing.Size(56, 55);
            this.btE.TabIndex = 1;
            this.btE.Text = "E";
            this.btE.UseVisualStyleBackColor = true;
            this.btE.Click += new System.EventHandler(this.btE_Click);
            // 
            // btO
            // 
            this.btO.Location = new System.Drawing.Point(186, 97);
            this.btO.Name = "btO";
            this.btO.Size = new System.Drawing.Size(56, 55);
            this.btO.TabIndex = 2;
            this.btO.Text = "O";
            this.btO.UseVisualStyleBackColor = true;
            this.btO.Click += new System.EventHandler(this.btO_Click);
            // 
            // btB
            // 
            this.btB.Location = new System.Drawing.Point(186, 158);
            this.btB.Name = "btB";
            this.btB.Size = new System.Drawing.Size(56, 55);
            this.btB.TabIndex = 5;
            this.btB.Text = "B";
            this.btB.UseVisualStyleBackColor = true;
            this.btB.Click += new System.EventHandler(this.btB_Click);
            // 
            // btM
            // 
            this.btM.Location = new System.Drawing.Point(112, 158);
            this.btM.Name = "btM";
            this.btM.Size = new System.Drawing.Size(56, 55);
            this.btM.TabIndex = 4;
            this.btM.Text = "M";
            this.btM.UseVisualStyleBackColor = true;
            this.btM.Click += new System.EventHandler(this.btM_Click);
            // 
            // btC
            // 
            this.btC.Location = new System.Drawing.Point(37, 158);
            this.btC.Name = "btC";
            this.btC.Size = new System.Drawing.Size(56, 55);
            this.btC.TabIndex = 3;
            this.btC.Text = "C";
            this.btC.UseVisualStyleBackColor = true;
            this.btC.Click += new System.EventHandler(this.btC_Click);
            // 
            // btR
            // 
            this.btR.Location = new System.Drawing.Point(37, 219);
            this.btR.Name = "btR";
            this.btR.Size = new System.Drawing.Size(56, 55);
            this.btR.TabIndex = 6;
            this.btR.Text = "R";
            this.btR.UseVisualStyleBackColor = true;
            this.btR.Click += new System.EventHandler(this.btR_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(112, 219);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(130, 55);
            this.btAceptar.TabIndex = 7;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // txtPalabra
            // 
            this.txtPalabra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalabra.Location = new System.Drawing.Point(117, 50);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.ReadOnly = true;
            this.txtPalabra.Size = new System.Drawing.Size(124, 24);
            this.txtPalabra.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Palabra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Puntos:";
            // 
            // txtPuntos
            // 
            this.txtPuntos.Location = new System.Drawing.Point(86, 298);
            this.txtPuntos.Name = "txtPuntos";
            this.txtPuntos.Size = new System.Drawing.Size(100, 20);
            this.txtPuntos.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 351);
            this.Controls.Add(this.txtPuntos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPalabra);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.btR);
            this.Controls.Add(this.btB);
            this.Controls.Add(this.btM);
            this.Controls.Add(this.btC);
            this.Controls.Add(this.btO);
            this.Controls.Add(this.btE);
            this.Controls.Add(this.btA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btA;
        private System.Windows.Forms.Button btE;
        private System.Windows.Forms.Button btO;
        private System.Windows.Forms.Button btB;
        private System.Windows.Forms.Button btM;
        private System.Windows.Forms.Button btC;
        private System.Windows.Forms.Button btR;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPuntos;
    }
}

