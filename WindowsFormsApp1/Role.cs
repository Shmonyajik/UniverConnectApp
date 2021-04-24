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
    public partial class Role : Form
    {
        public Role()
        {
            InitializeComponent();
        }

        private void roleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Role_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Role". При необходимости она может быть перемещена или удалена.
            this.roleTableAdapter.Fill(this.dataSet1.Role);

        }
    }
}
