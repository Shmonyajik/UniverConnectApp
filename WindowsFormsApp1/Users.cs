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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void _UserBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this._UserBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
            MDIParent1 my = Application.OpenForms.OfType<MDIParent1>().Single();
            my.UserRegistered();

        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1._User". При необходимости она может быть перемещена или удалена.
            this._UserTableAdapter.Fill(this.dataSet1._User);

        }
    }
}
