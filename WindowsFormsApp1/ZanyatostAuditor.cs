
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ZanyatostAuditor : Form
    {
        
        
        public ZanyatostAuditor()
        {
            
            InitializeComponent();
        }

        private void ZanyatostAuditor_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.ZanyatostAuditor". При необходимости она может быть перемещена или удалена.
            this.zanyatostAuditorTableAdapter1.Fill(this.dataSet1.ZanyatostAuditor);

        }
    }
}
