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
    public partial class Poseshyaemost : Form
    {
        public Poseshyaemost()
        {
            InitializeComponent();
        }

        private void poseshyaemostBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < poseshyaemostDataGridView.RowCount - 1; i++)
                if (string.IsNullOrEmpty(poseshyaemostDataGridView[3, i].Value.ToString()))
                    poseshyaemostDataGridView[3, i].Value = 0;
            
                this.Validate();
            this.poseshyaemostBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Poseshyaemost_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Poseshyaemost". При необходимости она может быть перемещена или удалена.
            this.poseshyaemostTableAdapter.Fill(this.dataSet1.Poseshyaemost);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.poseshyaemostTableAdapter.FillBy(this.dataSet1.Poseshyaemost);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void отчетОПосещаемостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OtchetPoseshyaemost otchet = new OtchetPoseshyaemost();
            otchet.Show();
        }
    }
}
