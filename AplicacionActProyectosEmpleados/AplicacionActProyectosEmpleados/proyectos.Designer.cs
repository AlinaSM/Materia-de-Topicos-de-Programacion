namespace AplicacionActProyectosEmpleados
{
    partial class proyectos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label proyectoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(proyectos));
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.dsProyectos = new AplicacionActProyectosEmpleados.dsProyectos();
            this.proyectosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectosTableAdapter = new AplicacionActProyectosEmpleados.dsProyectosTableAdapters.proyectosTableAdapter();
            this.tableAdapterManager = new AplicacionActProyectosEmpleados.dsProyectosTableAdapters.TableAdapterManager();
            this.proyectosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.proyectosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dgvTrabajadores = new System.Windows.Forms.DataGridView();
            this.proyectoLabel1 = new System.Windows.Forms.Label();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            proyectoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsProyectos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosBindingNavigator)).BeginInit();
            this.proyectosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajadores)).BeginInit();
            this.SuspendLayout();
            // 
            // proyectoLabel
            // 
            proyectoLabel.AutoSize = true;
            proyectoLabel.Location = new System.Drawing.Point(50, 99);
            proyectoLabel.Name = "proyectoLabel";
            proyectoLabel.Size = new System.Drawing.Size(51, 13);
            proyectoLabel.TabIndex = 11;
            proyectoLabel.Text = "proyecto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Empleados trabajando en el proyecto:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Primero";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Primero";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(362, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Primero";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(467, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Primero";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lblPosicion
            // 
            this.lblPosicion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPosicion.Location = new System.Drawing.Point(246, 40);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(110, 23);
            this.lblPosicion.TabIndex = 9;
            this.lblPosicion.Text = "No Registros";
            this.lblPosicion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dsProyectos
            // 
            this.dsProyectos.DataSetName = "dsProyectos";
            this.dsProyectos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proyectosBindingSource
            // 
            this.proyectosBindingSource.DataMember = "proyectos";
            this.proyectosBindingSource.DataSource = this.dsProyectos;
            // 
            // proyectosTableAdapter
            // 
            this.proyectosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Empleado_ProyectoTableAdapter = null;
            this.tableAdapterManager.empleadosTableAdapter = null;
            this.tableAdapterManager.proyectosTableAdapter = this.proyectosTableAdapter;
            this.tableAdapterManager.UpdateOrder = AplicacionActProyectosEmpleados.dsProyectosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // proyectosBindingNavigator
            // 
            this.proyectosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.proyectosBindingNavigator.BindingSource = this.proyectosBindingSource;
            this.proyectosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.proyectosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.proyectosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.proyectosBindingNavigatorSaveItem});
            this.proyectosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.proyectosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.proyectosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.proyectosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.proyectosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.proyectosBindingNavigator.Name = "proyectosBindingNavigator";
            this.proyectosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.proyectosBindingNavigator.Size = new System.Drawing.Size(615, 25);
            this.proyectosBindingNavigator.TabIndex = 10;
            this.proyectosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // proyectosBindingNavigatorSaveItem
            // 
            this.proyectosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.proyectosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("proyectosBindingNavigatorSaveItem.Image")));
            this.proyectosBindingNavigatorSaveItem.Name = "proyectosBindingNavigatorSaveItem";
            this.proyectosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.proyectosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.proyectosBindingNavigatorSaveItem.Click += new System.EventHandler(this.proyectosBindingNavigatorSaveItem_Click);
            // 
            // dgvTrabajadores
            // 
            this.dgvTrabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrabajadores.Location = new System.Drawing.Point(36, 223);
            this.dgvTrabajadores.Name = "dgvTrabajadores";
            this.dgvTrabajadores.Size = new System.Drawing.Size(525, 183);
            this.dgvTrabajadores.TabIndex = 11;
            // 
            // proyectoLabel1
            // 
            this.proyectoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proyectosBindingSource, "proyecto", true));
            this.proyectoLabel1.Location = new System.Drawing.Point(107, 99);
            this.proyectoLabel1.Name = "proyectoLabel1";
            this.proyectoLabel1.Size = new System.Drawing.Size(443, 23);
            this.proyectoLabel1.TabIndex = 12;
            this.proyectoLabel1.Text = "label1";
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proyectosBindingSource, "descripcion", true));
            this.txbDescripcion.Location = new System.Drawing.Point(36, 130);
            this.txbDescripcion.Multiline = true;
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(525, 48);
            this.txbDescripcion.TabIndex = 1;
            // 
            // proyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(615, 495);
            this.Controls.Add(proyectoLabel);
            this.Controls.Add(this.proyectoLabel1);
            this.Controls.Add(this.dgvTrabajadores);
            this.Controls.Add(this.proyectosBindingNavigator);
            this.Controls.Add(this.lblPosicion);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbDescripcion);
            this.Name = "proyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "proyectos";
            this.Load += new System.EventHandler(this.proyectos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsProyectos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosBindingNavigator)).EndInit();
            this.proyectosBindingNavigator.ResumeLayout(false);
            this.proyectosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblPosicion;
        private dsProyectos dsProyectos;
        private System.Windows.Forms.BindingSource proyectosBindingSource;
        private dsProyectosTableAdapters.proyectosTableAdapter proyectosTableAdapter;
        private dsProyectosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator proyectosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton proyectosBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dgvTrabajadores;
        private System.Windows.Forms.Label proyectoLabel1;
        private System.Windows.Forms.TextBox txbDescripcion;
    }
}