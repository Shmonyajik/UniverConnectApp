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
    public partial class Group : Form
    {
        public Group()
        {
            InitializeComponent();
        }

        private void _GroupBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this._GroupBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Group_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1._Group". При необходимости она может быть перемещена или удалена.
            this._GroupTableAdapter.Fill(this.dataSet1._Group);

        }
    }
}
