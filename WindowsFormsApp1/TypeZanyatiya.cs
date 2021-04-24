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
    public partial class TypeZanyatiya : Form
    {
        public TypeZanyatiya()
        {
            InitializeComponent();
        }

        private void typeZanyatiyaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.typeZanyatiyaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void TypeZanyatiya_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.TypeZanyatiya". При необходимости она может быть перемещена или удалена.
            this.typeZanyatiyaTableAdapter.Fill(this.dataSet1.TypeZanyatiya);

        }
    }
}
