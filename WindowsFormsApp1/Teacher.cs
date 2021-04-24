using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace WindowsFormsApp1
{
   
    public partial class Teacher : Form
    {
        public SqlConnection con;
        public int id_user;
        public bool est;
        private PopupNotifier popup = null;
        public Teacher(int id_user, bool est, SqlConnection con)
        {
            InitializeComponent();
            this.id_user = id_user;
            this.est = est;
            this.con = con;
        }

       

        private void Teacher_Load(object sender, EventArgs e)
        {
            if (est)
            {
                popup = new PopupNotifier();
                popup.Image = Properties.Resources.уведомления;
                popup.ImageSize = new Size(96, 96);
                popup.TitleText = "Расписание изменено";
                popup.ContentText = "Ваше расписание изменено";
                popup.Popup();
                con.Open();
                SqlCommand command4 = new SqlCommand($" DELETE FROM Changed WHERE id_user = '{id_user.ToString()}';", con);
                command4.ExecuteNonQuery();
                con.Close();
                //SqlDataReader reader1 = command1.ExecuteReader();
                //reader1.Read();
                //int id_user = Convert.ToInt32(reader1[0]);
                //reader1.Close();
            }
            try
            {
                this.raspisanieForTableAdapter.Fill(this.dataSet1.RaspisanieFor, new System.Nullable<int>(((int)(System.Convert.ChangeType(id_user, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void посещаемостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Poseshyaemost poseshyaemost = new Poseshyaemost();
            poseshyaemost.Show();
        }

        private void времяКонтроляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RaspisanieControl rasp = new RaspisanieControl();
            rasp.Show();
        }

        private void занятостьАудиторийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZanyatostAuditor zanyat = new ZanyatostAuditor();
            zanyat.Show();
        }
    }
}
