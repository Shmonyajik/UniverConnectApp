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
    public partial class Decanat : Form
    {
      

        public Decanat()
        {
            InitializeComponent();
        }

       

        private void raspisanieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.raspisanieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Decanat_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Raspisanie". При необходимости она может быть перемещена или удалена.
            this.raspisanieTableAdapter.Fill(this.dataSet1.Raspisanie);

        }

        private void расписаниеКонтроляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RaspisanieControl rasp = new RaspisanieControl();
            rasp.Show();
        }

        private void спискиСтудентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentList list = new StudentList();
            list.Show();
        }
    }
}
