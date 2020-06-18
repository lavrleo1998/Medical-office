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
    public partial class ter : Form
    {
        string per_nazn_nomer_zapisi;
        string per_nomer_specialnosti_sotrudnika;
        string per_nomer_istorii;
        string per_nazn_login_sotrudnika_local;
        string mesbox;
        string date_global;
        string time_global;
        string local_date;
        string connectionString = @"Data Source=LAVRHP\SQLEXPRESS;Initial Catalog=СБД;Integrated Security=True";
        public ter(string per, string per_nazn_login_sotrudnika)
        {
            InitializeComponent();
            this.per_nazn_nomer_zapisi = per;
            this.per_nazn_login_sotrudnika_local = per_nazn_login_sotrudnika;
        }

        private void ter_Load(object sender, EventArgs e)
        {

            comboBox1.Items.AddRange(new string[] { "грязи общие", "импедансометрия", "кинезиотерапия", "колоноскопия", "консультация врача мануальной терапии", "консультация врача ОФД", "консультация врача узи", "консультация гинеколога", "консультация диетолога", "консультация кардиолога", "консультация лор врача", "консультация невролога", "консультация педиатра", "консультация уролога", "консультация физиотерапевта", "консультация эндокринолога", "консультация эндоскописта", "минеральные ванны", "осмотр терапевтом", "осмотр терапевтом 7", "расшифровка экг", "РВГ", "ректороманоскопия", "РЭГ", "узи желчного пузыря", "узи органов малого таза", "узи печени", "узи поджелудочной железы", "узи почек", "узи сердца", "холтерофское мониторирование", "ЭГДС", "ЭЭГ" });
            comboBox2.Items.AddRange(new string[] { "предварительный диагноз", "клинический диагноз", "заключительный диагноз", });
            comboBox3.Items.AddRange(new string[] { "гипертаническая болезнь", "жировой гипатоз", "ибс атеросклеротический кардиосклероз", "ожирение", "остеохондроз", "подагра", "полиостеоартроз", "сахарный диабет", "стенокардия грудная жаба", "узловой зоб", "хронический бронхит", "хронический гастрит в обострении", "хронический запор", "хронический панкреатит", "хронический фаренгит ремиссия ", "хронический холицестит", "энцифалопатия" });

            string sqlExpression = "";
            //Получение номера истории болезни
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                sqlExpression = "sp_poluchenie_nomera_istorii";
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@nomer_zapisi",
                    Value = per_nazn_nomer_zapisi
                };
                command.Parameters.Add(nameParam);
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    per_nomer_istorii = String.Format("{0}", reader[0]);

                }
                reader.Close();
                connection.Close();
            }
            //Получение номера спецециальности сотрудника
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                sqlExpression = "sp_docktor_from_istoriya";
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@nomer_istorii",
                    Value = per_nomer_istorii
                };
                command.Parameters.Add(nameParam);
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    per_nomer_specialnosti_sotrudnika = String.Format("{0}", reader[0]);

                }
                reader.Close();
                connection.Close();
            }
            //Выдача всех данных об отдыхающем
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                sqlExpression = "sp_data_otd";
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@nomer_istorii",
                    Value = per_nomer_istorii
                };
                command.Parameters.Add(nameParam);
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    richTextBox_otd_and_istoriya.Text += String.Format("ФИО: {0} {1} {2}\nДата рождения: {3}\nПол: {4}\nАдрес: {5}\n ", reader[1], reader[2], reader[3], reader[4], reader[5], reader[6]);
                }
                reader.Close();
                connection.Close();
            }
            //Лечащий врач
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                sqlExpression = "sp_docktor";
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@nomer_specsot",
                    Value = per_nomer_specialnosti_sotrudnika
                };
                command.Parameters.Add(nameParam);
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    richTextBox_otd_and_istoriya.Text += String.Format("Лечащий врач: {0} {1} {2}\n", reader[1], reader[2], reader[3]);
                }
                reader.Close();
                connection.Close();
            }
            //Предварительный диагноз
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                richTextBox_otd_and_istoriya.Text += "Предварительный диагноз:\n";
                sqlExpression = "sp_data_predvariteln_diagnoz";
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@nomer_istorii",
                    Value = per_nomer_istorii
                };
                command.Parameters.Add(nameParam);
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    richTextBox_otd_and_istoriya.Text += String.Format("{0}\n", reader[1]);
                }
                reader.Close();
                connection.Close();
            }
            //Клинический диагноз
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                richTextBox_otd_and_istoriya.Text += "Клинический диагноз:\n";
                sqlExpression = "sp_data_clinicheskiy_diagnoz";
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@nomer_istorii",
                    Value = per_nomer_istorii
                };
                command.Parameters.Add(nameParam);
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    richTextBox_otd_and_istoriya.Text += String.Format("{0}\n", reader[1]);
                }
                reader.Close();
                connection.Close();
            }
            //Заключительный диагноз
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                richTextBox_otd_and_istoriya.Text += "Заключительный диагноз:\n";
                sqlExpression = "sp_data_zaklychitel_diagnoz";
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@nomer_istorii",
                    Value = per_nomer_istorii
                };
                command.Parameters.Add(nameParam);
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    richTextBox_otd_and_istoriya.Text += String.Format("{0}\n", reader[1]);
                }
                reader.Close();
                connection.Close();
            }
            //Выдача всех данных истории болезни
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                sqlExpression = "sp_data_istoriya";
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@nomer_istorii",
                    Value = per_nomer_istorii
                };
                command.Parameters.Add(nameParam);
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    richTextBox_otd_and_istoriya.Text += String.Format("Дата заезда: {0}\nДата выезда: {1}\n", reader[4], reader[5]);
                }
                reader.Close();
                connection.Close();
            }
            //Выдача всех данных о процедурах отдыхающего
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                sqlExpression = "sp_vse_naznacheniya_otd";
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@nomer_istorii",
                    Value = per_nomer_istorii
                };
                command.Parameters.Add(nameParam);
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    richTextBox_vse_naznacheniya.Text += String.Format("№{0}: {1}\nДата: {2}\n///////////////////////\n", reader[0], reader[1], reader[2]);
                }
                reader.Close();
                connection.Close();
            }
            //Зарузка данных назначения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                sqlExpression = "sp_odno_nazn";
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@nomer_nazn",
                    Value = per_nazn_nomer_zapisi
                };
                command.Parameters.Add(nameParam);
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    richTextBox_nazn.Text += String.Format("№{0} Назначено: {1}\n ДАТА {2} ВРЕМЯ {3}\n", reader[0], reader[2], reader[4], reader[5]);
                    textBox_zaklychenie.Text = string.Format("{0}", reader[3]);
                    // mesbox += richTextBox_otd_and_istoriya.Text;
                }
                reader.Close();
                connection.Close();
            }
        }
        private void button_go_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            ter_rasp form = new ter_rasp(per_nazn_login_sotrudnika_local);
            form.Show();
        }
        private void button_open_result_nazn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlExpression = "";
                sqlExpression = "sp_odno_nazn_full";
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@nomer_nazn",
                    Value = textBox_open_result_nazn.Text
                };
                command.Parameters.Add(nameParam);
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    mesbox = String.Format("Номер назначения: {0}\nНазвание: {1}\nДАТА: {2}\nВРЕМЯ: {3}\nЗаключение врача:\n{4}", reader[0], reader[2], reader[4], reader[5], reader[3]);

                }
                reader.Close();
                connection.Close();
            }
            MessageBox.Show(mesbox);
        }
        private void button_add_zaklychenie_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlExpression = "";
                string test = String.Format("{0}", textBox_zaklychenie.Text);
                sqlExpression = "sp_update_zaklychenie";
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@nomer_nazn",
                    Value = per_nazn_nomer_zapisi
                };
                command.Parameters.Add(nameParam);
                SqlParameter nameParam2 = new SqlParameter
                {
                    ParameterName = "@zaklychenie",
                    Value = test
                };
                command.Parameters.Add(nameParam2);
                int per_dlya_deystviya = command.ExecuteNonQuery();
                MessageBox.Show(string.Format("Заключение добавлено.\nОбновлено объектов: {0}", per_dlya_deystviya));
                connection.Close();
            }

        }
        private void button_add_nazn_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAVRHP\SQLEXPRESS;Initial Catalog=СБД;Integrated Security=True";


            //Получение даты по номеру записи 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlExpression = "";
                sqlExpression = "sp_poluchenie_date";
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@nomer_zapisi",
                    Value = per_nazn_nomer_zapisi
                };
                command.Parameters.Add(nameParam);
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                     local_date = String.Format("{0}", reader[0]);

                }
                reader.Close();
                connection.Close();
            }

            //Добавить получение даты по номеру записи
            //DateTime local_date2 = new DateTime();
            //local_date = DateTime.Parse("2020-05-13");

            funkciya(DateTime.Parse(local_date), int.Parse(per_nomer_istorii), comboBox1.SelectedItem.ToString());

            
            string test = string.Format("insert into [журнал назначений] ([номер  истории],[название назначения],[дата],[время]) values ({0}, '{1}','{2}','{3}')", per_nomer_istorii, comboBox1.SelectedItem, date_global, time_global);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(test, connection);
                int per_dlya_deystviya = command.ExecuteNonQuery();
                MessageBox.Show(string.Format("Назначение добавлено.\nОбновлено объектов: {0}", per_dlya_deystviya));
                connection.Close();
            }

        }
        private void button_add_diagnoz_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAVRHP\SQLEXPRESS;Initial Catalog=СБД;Integrated Security=True";
            string test = string.Format("insert into [{0}] ([номер  истории],[диагноз]) values ({1}, '{2}')", comboBox2.SelectedItem, per_nomer_istorii, comboBox3.SelectedItem);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(test, connection);
                int per_dlya_deystviya = command.ExecuteNonQuery();
                MessageBox.Show(string.Format("Диагноз добавлен.\nОбновлено объектов: {0}", per_dlya_deystviya));
                connection.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ter ter_raspform = new ter(per_nazn_nomer_zapisi, per_nazn_login_sotrudnika_local);
            ter_raspform.Show();
        }

        //OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO

        private void funkciya(DateTime date, int nomer_istorii, string nomer_nazn)
        {
            List<Class1> spisok_istorii = new List<Class1>();
            List<Class1> spisok_nazn = new List<Class1>();
            string connectionString = @"Data Source=LAVRHP\SQLEXPRESS;Initial Catalog=СБД;Integrated Security=True";
            string istoriya = string.Format("select [номер записи],[номер  истории], [название назначения],[дата],[время] from [журнал назначений] where [номер  истории]='2' and [дата]='2020-05-13'");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(istoriya, connection);
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                Class1 class1 = new Class1();
                //OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
                while (reader.Read())
                {
                    class1.nomer_zapisi = int.Parse(reader.GetValue(0).ToString());
                    class1.nomer_istorii = int.Parse(reader.GetValue(1).ToString());
                    class1.nazn = reader.GetValue(2).ToString();
                    class1.date = DateTime.Parse(reader.GetValue(3).ToString());
                    class1.time = DateTime.Parse(reader.GetValue(4).ToString());
                    spisok_istorii.Add(class1);
                }
                reader.Close();
                connection.Close();
            }
            string naznachenie = string.Format("select [номер записи],[номер  истории], [название назначения],[дата],[время] from [журнал назначений] where [название назначения]='осмотр терапевтом 7' and [дата]='2020-05-13'");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(naznachenie, connection);
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                Class1 class1 = new Class1();
                //OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
                while (reader.Read())
                {
                    class1.nomer_zapisi = int.Parse(reader.GetValue(0).ToString());
                    class1.nomer_istorii = int.Parse(reader.GetValue(1).ToString());
                    class1.nazn = reader.GetValue(2).ToString();
                    class1.date = DateTime.Parse(reader.GetValue(3).ToString());
                    class1.time = DateTime.Parse(reader.GetValue(4).ToString());
                    spisok_nazn.Add(class1);
                }
                reader.Close();
                connection.Close();
            }
            DateTime result = peremennay(spisok_istorii, spisok_nazn);
            if (result.TimeOfDay != DateTime.MinValue.TimeOfDay)
            {
                date_global = date.ToString();
                time_global = result.TimeOfDay.ToString();
                return;
            }
        }

        private DateTime peremennay(List<Class1> class1s, List<Class1> class1s2)
        {
            DateTime nachalo_vremeni = new DateTime();
            nachalo_vremeni = nachalo_vremeni.AddHours(9);
            for (int i = 0; i < 8; i++)
            {
                //Есть ли свободное окно на 9:30 у истории
                int result1 = class1s.Where(x => x.time.TimeOfDay == nachalo_vremeni.TimeOfDay).ToList().Count;
                //Есть ли свободное окно на 9:30 у доктора
                int result2 = class1s2.Where(x => x.time.TimeOfDay == nachalo_vremeni.TimeOfDay).ToList().Count;
                if (result1 == 0 && result2 == 0) { return nachalo_vremeni; }
                nachalo_vremeni = nachalo_vremeni.AddMinutes(30);
            }
            return class1s[0].date.AddDays(1);
        }
    }
}
