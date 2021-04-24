using System;
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
    public partial class Cafedra : Form
    {
        public Cafedra()
        {
            InitializeComponent();
        }

        private void cafedraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cafedraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Cafedra_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Cafedra". При необходимости она может быть перемещена или удалена.
            this.cafedraTableAdapter.Fill(this.dataSet1.Cafedra);

        }
    }
}
