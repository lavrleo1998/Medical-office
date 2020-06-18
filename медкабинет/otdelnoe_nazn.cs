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
    public partial class otdelnoe_nazn : Form
    {
        string per_nazn_nomer_zapisi;
        string per_nomer_specialnosti_sotrudnika;
        string per_nomer_istorii;
        string per_nazn_login_sotrudnika_local;
        string mesbox;
        string connectionString = @"Data Source=LAVRHP\SQLEXPRESS;Initial Catalog=СБД;Integrated Security=True";
        public otdelnoe_nazn(string per, string per_nazn_login_sotrudnika)
        {
            InitializeComponent();
            this.per_nazn_nomer_zapisi = per;
            this.per_nazn_login_sotrudnika_local = per_nazn_login_sotrudnika;
        }

        private void otdelnoe_nazn_Load(object sender, EventArgs e)
        {
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
            vrach form = new vrach(per_nazn_login_sotrudnika_local);
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
    }
}
