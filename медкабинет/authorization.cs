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

namespace медкабинет
{
    public partial class authorization : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=LAVRHP\SQLEXPRESS;Initial Catalog=СБД;Integrated Security=True");
        SqlCommand cmd_enter = new SqlCommand();
        SqlCommand cmd_tip = new SqlCommand();
        public authorization()
        {
            InitializeComponent();
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            string login = textBox_login.Text;
            string password = textBox_password.Text;
            string login_check=null;
            string tip_check=null;

            cnn.Open();
            cmd_enter.Connection = cnn;
            cmd_enter.CommandText = string.Format("select логин from сотрудники where логин like '{0}' and пароль like '{1}'",login,password);
            SqlDataReader reader = cmd_enter.ExecuteReader();
            while (reader.Read())
            { 
                login_check = reader[0].ToString();//записываем логин в логин_чек

            }
            reader.Close();
            cnn.Close();

            cnn.Open();
            cmd_tip.Connection = cnn;
            cmd_tip.CommandText = string.Format("select [тип доступа] from [специальности] where [название специальности] = (select [название специальности] from [специальности сотрудников] where логин = '{0}')", login_check);       
            SqlDataReader reader2 = cmd_tip.ExecuteReader();
            while (reader2.Read())
            {
                tip_check = reader2[0].ToString();//записываем тип доступа в тип_чек
            }
            reader2.Close();
            cnn.Close();
            if (tip_check != string.Format("первый"))
            {
                if (tip_check != string.Format("второй"))
                {
                    if (tip_check != string.Format("третий"))
                    {
                        if (tip_check != string.Format("четвертый"))
                        {
                            if (tip_check != string.Format("пятый"))
                            {
                                if (tip_check != string.Format("шестой"))
                                {
                                    MessageBox.Show("Неверный логин и пароль!");
                                }
                                else
                                {
                                    this.Hide();
                                    nachmed nachmedform = new nachmed();
                                    nachmedform.Show();
                                }
                            }
                            else
                            {
                                this.Hide();
                                starshaya_medsestra starshaya_Medsestra = new starshaya_medsestra();
                                starshaya_Medsestra.Show();
                            }
                        }
                        else
                        {
                            this.Hide();
                            registratura registraturaform = new registratura();
                            registraturaform.Show();
                        }
                    }
                    else
                    {
                        this.Hide();
                        medsestra medsestraform = new medsestra(login_check);
                        medsestraform.Show();
                    }
                }
                else
                {
                    this.Hide();
                    vrach vrachform = new vrach(login_check);
                    vrachform.Show();
                }
            }
            else
            {
                this.Hide();
                ter_rasp terapevtform = new ter_rasp(login_check);
                terapevtform.Show();
            }

        }

        private void authorization_Load(object sender, EventArgs e)
        {

        }
    }
}
