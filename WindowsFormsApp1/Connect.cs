using System;

using System.Data.SqlClient;

using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Connect : Form
    {
        
        public Connect()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Создание строки подключения
            String ConnectString = "Integrated Security=false; User Id = " + textBox1.Text + "; Password = " + textBox2.Text + @"; server= " + textBox3.Text + "; Initial Catalog = " + textBox4.Text;
            // Объявление новой переменной типа SqlConection
            SqlConnection con = new SqlConnection(ConnectString);
            Exception error = null; // Переменная, представляющая ошибки, появляющиеся во время выполнения приложения
            try
            {
                con.Open(); // Открытие подключения
            }
            catch (Exception ex) // При возникновении неполадок при подключении появится сообщение с информацией об ошибке
            {
                error = ex; // Переменная error запоминает конкретную ошибку
                MessageBox.Show(string.Format("Error: {0}", ex.Message), "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (error == null) // Если переменная не изменилась, то ошибок при подключении не было и соединение с БД установлено
                {
                    SqlCommand command = new SqlCommand($" sp_helpuser'{textBox1.Text}'", con);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    string a = reader["Rolename"].ToString();
                    reader.Close();
                   
                    
                    SqlCommand command1 = new SqlCommand($" SELECT id_user FROM dbo._User WHERE(login = SUSER_SNAME())", con);
                    SqlDataReader reader1 = command1.ExecuteReader();
                    reader1.Read(); 
                    int id_user = Convert.ToInt32(reader1[0]);
                    reader1.Close();

                    SqlCommand command2 = new SqlCommand($"SELECT  Changed.id_user FROM Changed where Changed.id_user = '{id_user.ToString()}' ", con);
                    SqlDataReader reader2 = command2.ExecuteReader();
                    reader2.Read();
                    
                    bool est = reader2.HasRows;
                    reader2.Close();
                    con.Close();
                    switch (a)
                    {
                        case "db_owner":
                            MDIParent1 mdi = new MDIParent1(con);
                            mdi.Show();
                            break;
                        case "DecanatRole": Decanat decanat = new Decanat();
                            decanat.Show(); break;
                        case "TeacherRole": Teacher teach = new Teacher(id_user,est,con);
                            teach.Show();
                            break;
                        case "StarostaRole":
                            Starosta starosta = new Starosta(con, id_user,est);
                            starosta.Show();
                            
                            break;
                        case "StudentRole": Student stud = new Student(id_user,est,con);
                            stud.Show();
                              break;

                    }
                    con.Close();
                    
                }
            }

        }
    }
}
