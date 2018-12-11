﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaestroDetalle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void titulosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.titulosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsLibros);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsLibros.temas' Puede moverla o quitarla según sea necesario.
            this.temasTableAdapter.Fill(this.dsLibros.temas);
            // TODO: esta línea de código carga datos en la tabla 'dsLibros.titulos' Puede moverla o quitarla según sea necesario.
            this.titulosTableAdapter.Fill(this.dsLibros.titulos);

        }
    }
}
