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
    public partial class StudentList : Form
    {
        public StudentList()
        {
            InitializeComponent();
        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.StudentList". При необходимости она может быть перемещена или удалена.
            this.studentListTableAdapter.Fill(this.dataSet1.StudentList);

        }
    }
}
