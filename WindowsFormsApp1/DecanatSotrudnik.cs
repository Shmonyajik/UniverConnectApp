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
    public partial class DecanatSotrudnik : Form
    {
        public DecanatSotrudnik()
        {
            InitializeComponent();
        }

        private void decanatSotrudnikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.decanatSotrudnikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void DecanatSotrudnik_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.DecanatSotrudnik". При необходимости она может быть перемещена или удалена.
            this.decanatSotrudnikTableAdapter.Fill(this.dataSet1.DecanatSotrudnik);

        }
    }
}
