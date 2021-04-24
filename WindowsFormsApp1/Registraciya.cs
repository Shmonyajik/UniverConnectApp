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
using WindowsFormsApp1.DataSet1TableAdapters;

namespace WindowsFormsApp1
{
    public partial class Registraciya : Form
    {
        public SqlConnection con;
        public Registraciya(SqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Registraciya_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "Администратор", "Деканат", "Преподаватель", "Староста", "Студент" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != null && textBox2.Text != null && textBox3.Text != null && comboBox1.SelectedIndex != -1)
                {
                    int role = comboBox1.SelectedIndex;
                    string str = "";
                    
                    switch (role)
                    {
                        case 0:
                            str = "db_owner";
                            break;
                        case 1:
                            str = "DecanatRole";
                            break;
                        case 2:
                            str = "TeacherRole";
                            break;
                        case 3:
                            str = "StarostaRole";
                            break;
                        case 4:
                            str = "StudentRole";
                            break;


                    }
                    role++;

                    String quertString = @"insert into _User (login, password, id_role) values ('" + textBox2.Text + "','" + textBox3.Text + "','" + role.ToString() + "');";
                    SqlCommand insert = new SqlCommand(quertString, con);
                    con.Open();
                    insert.ExecuteNonQuery();
                    con.Close();

                    //СОЗДАНИЕ
                    String quertString2 = @"EXEC sp_addlogin " + textBox2.Text + "," + textBox3.Text + ",UniverConnect";
                    SqlCommand create2 = new SqlCommand(quertString2, con);
                    con.Open();
                    create2.ExecuteNonQuery();
                    con.Close();
                    String quertString3 = @"EXEC sp_adduser " + textBox2.Text + "," + textBox1.Text + "";
                    SqlCommand create3 = new SqlCommand(quertString3, con);
                    con.Open();
                    create3.ExecuteNonQuery();
                    con.Close();
                    String quertString4 = @"EXEC sp_addrolemember " + str + "," + textBox1.Text + " ";
                    SqlCommand create4 = new SqlCommand(quertString4, con);
                    con.Open();
                    create4.ExecuteNonQuery();
                    con.Close();
                    MDIParent1 my = Application.OpenForms.OfType<MDIParent1>().Single();
                    my.UserRegistered();
                    

                }
                else
                {
                    MessageBox.Show("Заполнены не все поля", "Ошибка");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "У вас недостаточно прав!");
            }
        }
    }
}
