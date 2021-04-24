﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Auditorium : Form
    {
        public Auditorium()
        {
            InitializeComponent();
        }

        private void auditoriumBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.auditoriumBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Auditorium_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Auditorium". При необходимости она может быть перемещена или удалена.
            this.auditoriumTableAdapter.Fill(this.dataSet1.Auditorium);

        }
    }
}
