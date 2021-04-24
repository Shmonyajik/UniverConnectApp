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
    public partial class ControlRaspisanie : Form
    {
        public ControlRaspisanie()
        {
            InitializeComponent();
        }

        private void raspisanieControlBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.raspisanieControlBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void ControlRaspisanie_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.RaspisanieControl". При необходимости она может быть перемещена или удалена.
            this.raspisanieControlTableAdapter.Fill(this.dataSet1.RaspisanieControl);

        }
    }
}
