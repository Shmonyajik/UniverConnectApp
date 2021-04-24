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
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
        }

        private void teacherBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teacherBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Teacher". При необходимости она может быть перемещена или удалена.
            this.teacherTableAdapter.Fill(this.dataSet1.Teacher);

        }
    }
}
