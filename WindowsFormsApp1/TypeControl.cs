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
    public partial class TypeControl : Form
    {
        public TypeControl()
        {
            InitializeComponent();
        }

        private void typeControlBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.typeControlBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void TypeControl_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.TypeControl". При необходимости она может быть перемещена или удалена.
            this.typeControlTableAdapter.Fill(this.dataSet1.TypeControl);

        }
    }
}
