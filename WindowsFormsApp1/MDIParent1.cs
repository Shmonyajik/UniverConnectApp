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
    public partial class MDIParent1 : Form
    {

        public SqlConnection con;
        

        public MDIParent1(SqlConnection con)
        {
            InitializeComponent();
            this.con = con;

            
            
        }

        private void занятостьАудиторийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZanyatostAuditor zanyatost = new ZanyatostAuditor();
            zanyatost.Show();
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
        }

        private void ролиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Role role = new Role();
            role.Show();
        }

        private void группыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Group group = new Group();
            group.Show();
        }

        private void аудиторииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Auditorium group = new Auditorium();
            group.Show();
        }

        private void кафедрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cafedra group = new Cafedra();
            group.Show();
        }

        private void сотрудникиДеканатаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DecanatSotrudnik group = new DecanatSotrudnik();
            group.Show();
        }

        private void дисциплиныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Discipline group = new Discipline();
            group.Show();
        }

        private void посещаемостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Poseshyaemost group = new Poseshyaemost();
            group.Show();
        }

        private void расписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raspisanie group = new Raspisanie();
            group.Show();
        }

        private void расписаниеКонтроляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RaspisanieControl group = new RaspisanieControl();
            group.Show();
        }

        private void преподавателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teachers group = new Teachers();
            group.Show();
        }

        private void типыЗанятийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeZanyatiya group = new TypeZanyatiya();
            group.Show();
        }

        private void типыКонтроляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeControl group = new TypeControl();
            group.Show();
        }

        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registraciya reg = new Registraciya(con);
            reg.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа служит для работы с базой данных для связь старост со службами университета. Система выводит справочники из базы данных и даёт пользователю возможность добавлять, изменять и удалять данные. Так же система обеспечивает формирование печатных форм. " +
                "Разработчик программы: Ракутин Семен Дмитриевич ЭИС-37",
                "О программе");
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.AdminView". При необходимости она может быть перемещена или удалена.
            this.adminViewTableAdapter.Fill(this.dataSet1.AdminView);

            

        }
        public void UserRegistered()
        {
            adminViewTableAdapter.Fill(this.dataSet1.AdminView);
        }

        private void adminViewBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.adminViewBindingSource.EndEdit();
                //this.adminViewTableAdapter.UpdateQ();
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed "+ ex.Message);
            }
        }

        private void cтудентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Students stud = new Students();
            stud.Show();
        }
    }
}
