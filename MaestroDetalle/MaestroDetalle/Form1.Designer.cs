namespace MaestroDetalle
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
            System.Windows.Forms.Label temaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dsLibros = new MaestroDetalle.dsLibros();
            this.titulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titulosTableAdapter = new MaestroDetalle.dsLibrosTableAdapters.titulosTableAdapter();
            this.tableAdapterManager = new MaestroDetalle.dsLibrosTableAdapters.TableAdapterManager();
            this.temasTableAdapter = new MaestroDetalle.dsLibrosTableAdapters.temasTableAdapter();
            this.titulosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.titulosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.titulosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.temaLabel1 = new System.Windows.Forms.Label();
            temaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulosBindingNavigator)).BeginInit();
            this.titulosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titulosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // temaLabel
            // 
            temaLabel.AutoSize = true;
            temaLabel.Location = new System.Drawing.Point(23, 305);
            temaLabel.Name = "temaLabel";
            temaLabel.Size = new System.Drawing.Size(33, 13);
            temaLabel.TabIndex = 2;
            temaLabel.Text = "tema:";
            // 
            // dsLibros
            // 
            this.dsLibros.DataSetName = "dsLibros";
            this.dsLibros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // titulosBindingSource
            // 
            this.titulosBindingSource.DataMember = "titulos";
            this.titulosBindingSource.DataSource = this.dsLibros;
            // 
            // titulosTableAdapter
            // 
            this.titulosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.temasTableAdapter = this.temasTableAdapter;
            this.tableAdapterManager.titulosTableAdapter = this.titulosTableAdapter;
            this.tableAdapterManager.UpdateOrder = MaestroDetalle.dsLibrosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // temasTableAdapter
            // 
            this.temasTableAdapter.ClearBeforeFill = true;
            // 
            // titulosBindingNavigator
            // 
            this.titulosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.titulosBindingNavigator.BindingSource = this.titulosBindingSource;
            this.titulosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.titulosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.titulosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.titulosBindingNavigatorSaveItem});
            this.titulosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.titulosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.titulosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.titulosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.titulosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.titulosBindingNavigator.Name = "titulosBindingNavigator";
            this.titulosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.titulosBindingNavigator.Size = new System.Drawing.Size(422, 25);
            this.titulosBindingNavigator.TabIndex = 0;
            this.titulosBindingNavigator.Text = "bindingNavigator1";
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
            // titulosBindingNavigatorSaveItem
            // 
            this.titulosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.titulosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("titulosBindingNavigatorSaveItem.Image")));
            this.titulosBindingNavigatorSaveItem.Name = "titulosBindingNavigatorSaveItem";
            this.titulosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.titulosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.titulosBindingNavigatorSaveItem.Click += new System.EventHandler(this.titulosBindingNavigatorSaveItem_Click);
            // 
            // titulosDataGridView
            // 
            this.titulosDataGridView.AutoGenerateColumns = false;
            this.titulosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.titulosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.titulosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.titulosDataGridView.DataSource = this.titulosBindingSource;
            this.titulosDataGridView.Location = new System.Drawing.Point(26, 67);
            this.titulosDataGridView.Name = "titulosDataGridView";
            this.titulosDataGridView.Size = new System.Drawing.Size(376, 220);
            this.titulosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_libro";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_libro";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 65;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "titulo";
            this.dataGridViewTextBoxColumn2.HeaderText = "titulo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 54;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_tema";
            this.dataGridViewTextBoxColumn3.HeaderText = "id_tema";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 69;
            // 
            // temasBindingSource
            // 
            this.temasBindingSource.DataMember = "temas_titulos";
            this.temasBindingSource.DataSource = this.titulosBindingSource;
            // 
            // temaLabel1
            // 
            this.temaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.temasBindingSource, "tema", true));
            this.temaLabel1.Location = new System.Drawing.Point(76, 305);
            this.temaLabel1.Name = "temaLabel1";
            this.temaLabel1.Size = new System.Drawing.Size(100, 23);
            this.temaLabel1.TabIndex = 3;
            this.temaLabel1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 340);
            this.Controls.Add(temaLabel);
            this.Controls.Add(this.temaLabel1);
            this.Controls.Add(this.titulosDataGridView);
            this.Controls.Add(this.titulosBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulosBindingNavigator)).EndInit();
            this.titulosBindingNavigator.ResumeLayout(false);
            this.titulosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titulosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsLibros dsLibros;
        private System.Windows.Forms.BindingSource titulosBindingSource;
        private dsLibrosTableAdapters.titulosTableAdapter titulosTableAdapter;
        private dsLibrosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator titulosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton titulosBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView titulosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private dsLibrosTableAdapters.temasTableAdapter temasTableAdapter;
        private System.Windows.Forms.BindingSource temasBindingSource;
        private System.Windows.Forms.Label temaLabel1;
    }
}

