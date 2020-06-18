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
    public partial class medsestra : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=LAVRHP\SQLEXPRESS;Initial Catalog=СБД;Integrated Security=True");
        SqlCommand cmd_nazn = new SqlCommand();
        SqlDataAdapter da_nazn;
        DataSet ds_nazn = new DataSet();
        SqlCommandBuilder bild_nazn;
        string per_nazn;
        DateTime per_nazn_date;
        public medsestra(string per)
        {
            InitializeComponent();
            this.per_nazn = per;
        }

        private void Medsestra_Load(object sender, EventArgs e)
        {
            comboBox_add.Items.AddRange(new string[] { "Пройдено", "Не явился" });
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            string zamena_table = "[журнал назначений]";
            string zamena_colum = "[заключение]";
            string zamena_row = "[номер записи]";
            string connectionString = @"Data Source=LAVRHP\SQLEXPRESS;Initial Catalog=СБД;Integrated Security=True";
            string test = string.Format("update {0} set {1} = '{2}' where {3} = '{4}'", zamena_table, zamena_colum, comboBox_add.SelectedItem, zamena_row, textBox_choice.Text);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(test, connection);
                int per_dlya_deystviya = command.ExecuteNonQuery();
                textBox_status.Text = string.Format("Обновлено объектов: {0}", per_dlya_deystviya);
                connection.Close();
            }
            cnn.Open();
            cmd_nazn = new SqlCommand("select * from [журнал назначений] where [название назначения] = (select [название назначения] from [назначения] where [номер спецсот] = (select [номер спецсот] from [специальности сотрудников] where [логин] = @login)) and [дата]=@date", cnn);
            da_nazn = new SqlDataAdapter(cmd_nazn.CommandText, cnn);
            da_nazn.SelectCommand.Parameters.Add("@login", SqlDbType.VarChar);
            da_nazn.SelectCommand.Parameters["@login"].Value = this.per_nazn;
            da_nazn.SelectCommand.Parameters.Add("@date", SqlDbType.Date);
            da_nazn.SelectCommand.Parameters["@date"].Value = per_nazn_date;
            ds_nazn.Clear();
            da_nazn.Fill(ds_nazn, "[журнал назначений]");
            dataGridView_nazn.DataSource = ds_nazn.Tables["[журнал назначений]"];
            bild_nazn = new SqlCommandBuilder(da_nazn);
            cnn.Close();
        }
        //Вот тут есть баг
        private void Batton_choice_Click(object sender, EventArgs e)
        {
            string sqlExpression = "proc_vizov_otd";
            cnn.Open();
            SqlCommand cmd_nazn = new SqlCommand(sqlExpression, cnn)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = "@vizov_otd",
                Value = textBox_choice.Text
            };
            cmd_nazn.Parameters.Add(sqlParameter);

            
            SqlDataReader reader = cmd_nazn.ExecuteReader();
            while (reader.Read())
            {
                richTextBox1.Text = string.Format("Фамилия: {0}\n Имя: {1}\n Отчество: {2}\n", reader[0], reader[1], reader[2]);
            }
            reader.Close();
            cnn.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            per_nazn_date = Convert.ToDateTime(dateTimePicker1.Value);
            cnn.Open();
            cmd_nazn = new SqlCommand("select * from [журнал назначений] where [название назначения] = (select [название назначения] from [назначения] where [номер спецсот] = (select [номер спецсот] from [специальности сотрудников] where [логин] = @login)) and [дата]=@date", cnn);
            da_nazn = new SqlDataAdapter(cmd_nazn.CommandText, cnn);
            da_nazn.SelectCommand.Parameters.Add("@login", SqlDbType.VarChar);
            da_nazn.SelectCommand.Parameters["@login"].Value = this.per_nazn;
            da_nazn.SelectCommand.Parameters.Add("@date", SqlDbType.Date);
            da_nazn.SelectCommand.Parameters["@date"].Value = per_nazn_date;
            ds_nazn.Clear();
            da_nazn.Fill(ds_nazn, "[журнал назначений]");
            dataGridView_nazn.DataSource = ds_nazn.Tables["[журнал назначений]"];
            bild_nazn = new SqlCommandBuilder(da_nazn);
            cnn.Close();
        }
    }
}
