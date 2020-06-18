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
    public partial class registratura : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=LAVRHP\SQLEXPRESS;Initial Catalog=СБД;Integrated Security=True");
        SqlCommand cmd_otd = new SqlCommand();
        SqlDataAdapter da_otd;
        DataSet ds_otd = new DataSet();
        SqlCommandBuilder bild_otd;
       
        public registratura()
        {
            InitializeComponent();
        }

        private void registratura_Load(object sender, EventArgs e)
        {
            cnn.Open();
            da_otd = new SqlDataAdapter("select * from [отдыхающий]", cnn);
            //da_otd = new SqlDataAdapter("select [фамилия отд], [имя отд], [отчество отд], [дата рождения], [пол], [адрес] from [отдыхающий]", cnn);
            ds_otd.Clear();
            da_otd.Fill(ds_otd, "[отдыхающий]");
            dataGridView_otd.DataSource = ds_otd.Tables["[отдыхающий]"];
            bild_otd = new SqlCommandBuilder(da_otd);
            cnn.Close();
        }

        private void button_add_otd_Click(object sender, EventArgs e)
        {
            cnn.Open();
            DataRow row = ds_otd.Tables["[отдыхающий]"].NewRow();
            row[1] = textBox1.Text;
            row[2] = textBox2.Text;
            row[3] = textBox3.Text;
            row[4] = Convert.ToDateTime(dateTimePicker1.Value);
            row[5] = textBox4.Text;
            row[6] = textBox5.Text;
            ds_otd.Tables["[отдыхающий]"].Rows.Add(row);
            da_otd.Update(ds_otd.Tables["[отдыхающий]"]);
            cnn.Close();
            cnn.Open();
            da_otd = new SqlDataAdapter("select * from [отдыхающий]", cnn);
            //da_otd = new SqlDataAdapter("select [фамилия отд], [имя отд], [отчество отд], [дата рождения], [пол], [адрес] from [отдыхающий]", cnn);
            ds_otd.Clear();
            da_otd.Fill(ds_otd, "[отдыхающий]");
            dataGridView_otd.DataSource = ds_otd.Tables["[отдыхающий]"];
            bild_otd = new SqlCommandBuilder(da_otd);
            cnn.Close();
        }
                
        private void button_fam_update_Click(object sender, EventArgs e)
        {
            string zamena_table = "[отдыхающий]";
            string zamena_colum = "[фамилия отд]";
            string zamena_row = "[номер отдыхающего]";
            string connectionString = @"Data Source=LAVRHP\SQLEXPRESS;Initial Catalog=СБД;Integrated Security=True";
            string test = string.Format("update {0} set {1} = '{2}' where {3} = '{4}'", zamena_table, zamena_colum, textBox1_update.Text, zamena_row, textBox_nomer_otd.Text);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(test, connection);
                int per_dlya_deystviya = command.ExecuteNonQuery();
                MessageBox.Show(string.Format("Обновлено объектов: {0}", per_dlya_deystviya));
                connection.Close();
            }
            cnn.Open();
            da_otd = new SqlDataAdapter("select * from [отдыхающий]", cnn);
            //da_otd = new SqlDataAdapter("select [фамилия отд], [имя отд], [отчество отд], [дата рождения], [пол], [адрес] from [отдыхающий]", cnn);
            ds_otd.Clear();
            da_otd.Fill(ds_otd, "[отдыхающий]");
            dataGridView_otd.DataSource = ds_otd.Tables["[отдыхающий]"];
            bild_otd = new SqlCommandBuilder(da_otd);
            cnn.Close();
        }

        private void button_im_update_Click(object sender, EventArgs e)
        {
            string zamena_table = "[отдыхающий]";
            string zamena_colum = "[имя отд]";
            string zamena_row = "[номер отдыхающего]";
            string connectionString = @"Data Source=LAVRHP\SQLEXPRESS;Initial Catalog=СБД;Integrated Security=True";
            string test = string.Format("update {0} set {1} = '{2}' where {3} = '{4}'", zamena_table, zamena_colum, textBox2_update.Text, zamena_row, textBox_nomer_otd.Text);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(test, connection);
                int per_dlya_deystviya = command.ExecuteNonQuery();
                MessageBox.Show(string.Format("Обновлено объектов: {0}", per_dlya_deystviya));
                connection.Close();
            }
            cnn.Open();
            da_otd = new SqlDataAdapter("select * from [отдыхающий]", cnn);
            //da_otd = new SqlDataAdapter("select [фамилия отд], [имя отд], [отчество отд], [дата рождения], [пол], [адрес] from [отдыхающий]", cnn);
            ds_otd.Clear();
            da_otd.Fill(ds_otd, "[отдыхающий]");
            dataGridView_otd.DataSource = ds_otd.Tables["[отдыхающий]"];
            bild_otd = new SqlCommandBuilder(da_otd);
            cnn.Close();
        }

        private void button_ot_update_Click(object sender, EventArgs e)
        {
            string zamena_table = "[отдыхающий]";
            string zamena_colum = "[отчество отд]";
            string zamena_row = "[номер отдыхающего]";
            string connectionString = @"Data Source=LAVRHP\SQLEXPRESS;Initial Catalog=СБД;Integrated Security=True";
            string test = string.Format("update {0} set {1} = '{2}' where {3} = '{4}'", zamena_table, zamena_colum, textBox3_update.Text, zamena_row, textBox_nomer_otd.Text);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(test, connection);
                int per_dlya_deystviya = command.ExecuteNonQuery();
                MessageBox.Show(string.Format("Обновлено объектов: {0}", per_dlya_deystviya));
                connection.Close();
            }
            cnn.Open();
            da_otd = new SqlDataAdapter("select * from [отдыхающий]", cnn);
            //da_otd = new SqlDataAdapter("select [фамилия отд], [имя отд], [отчество отд], [дата рождения], [пол], [адрес] from [отдыхающий]", cnn);
            ds_otd.Clear();
            da_otd.Fill(ds_otd, "[отдыхающий]");
            dataGridView_otd.DataSource = ds_otd.Tables["[отдыхающий]"];
            bild_otd = new SqlCommandBuilder(da_otd);
            cnn.Close();
        }

        private void button_pol_update_Click(object sender, EventArgs e)
        {
            string zamena_table = "[отдыхающий]";
            string zamena_colum = "[пол отд]";
            string zamena_row = "[номер отдыхающего]";
            string connectionString = @"Data Source=LAVRHP\SQLEXPRESS;Initial Catalog=СБД;Integrated Security=True";
            string test = string.Format("update {0} set {1} = '{2}' where {3} = '{4}'", zamena_table, zamena_colum, textBox4_update.Text, zamena_row, textBox_nomer_otd.Text);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(test, connection);
                int per_dlya_deystviya = command.ExecuteNonQuery();
                MessageBox.Show(string.Format("Обновлено объектов: {0}", per_dlya_deystviya));
                connection.Close();
            }
            cnn.Open();
            da_otd = new SqlDataAdapter("select * from [отдыхающий]", cnn);
            //da_otd = new SqlDataAdapter("select [фамилия отд], [имя отд], [отчество отд], [дата рождения], [пол], [адрес] from [отдыхающий]", cnn);
            ds_otd.Clear();
            da_otd.Fill(ds_otd, "[отдыхающий]");
            dataGridView_otd.DataSource = ds_otd.Tables["[отдыхающий]"];
            bild_otd = new SqlCommandBuilder(da_otd);
            cnn.Close();
        }

        private void button_date_update_Click(object sender, EventArgs e)
        {
            string zamena_table = "[отдыхающий]";
            string zamena_colum = "[дата рождения]";
            string zamena_row = "[номер отдыхающего]";
            string connectionString = @"Data Source=LAVRHP\SQLEXPRESS;Initial Catalog=СБД;Integrated Security=True";
            string test = string.Format("update {0} set {1} = '{2}' where {3} = '{4}'", zamena_table, zamena_colum, Convert.ToDateTime(dateTimePicker1__update), zamena_row, textBox_nomer_otd.Text);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(test, connection);
                int per_dlya_deystviya = command.ExecuteNonQuery();
                MessageBox.Show(string.Format("Обновлено объектов: {0}", per_dlya_deystviya));
                connection.Close();
            }
            cnn.Open();
            da_otd = new SqlDataAdapter("select * from [отдыхающий]", cnn);
            //da_otd = new SqlDataAdapter("select [фамилия отд], [имя отд], [отчество отд], [дата рождения], [пол], [адрес] from [отдыхающий]", cnn);
            ds_otd.Clear();
            da_otd.Fill(ds_otd, "[отдыхающий]");
            dataGridView_otd.DataSource = ds_otd.Tables["[отдыхающий]"];
            bild_otd = new SqlCommandBuilder(da_otd);
            cnn.Close();
        }

        private void button_adres_update_Click(object sender, EventArgs e)
        {
            string zamena_table = "[отдыхающий]";
            string zamena_colum = "[адрес]";
            string zamena_row = "[номер отдыхающего]";
            string connectionString = @"Data Source=LAVRHP\SQLEXPRESS;Initial Catalog=СБД;Integrated Security=True";
            string test = string.Format("update {0} set {1} = '{2}' where {3} = '{4}'", zamena_table, zamena_colum, textBox5_update.Text, zamena_row, textBox_nomer_otd.Text);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(test, connection);
                int per_dlya_deystviya = command.ExecuteNonQuery();
                MessageBox.Show(string.Format("Обновлено объектов: {0}", per_dlya_deystviya));
                connection.Close();
            }
            cnn.Open();
            da_otd = new SqlDataAdapter("select * from [отдыхающий]", cnn);
            //da_otd = new SqlDataAdapter("select [фамилия отд], [имя отд], [отчество отд], [дата рождения], [пол], [адрес] from [отдыхающий]", cnn);
            ds_otd.Clear();
            da_otd.Fill(ds_otd, "[отдыхающий]");
            dataGridView_otd.DataSource = ds_otd.Tables["[отдыхающий]"];
            bild_otd = new SqlCommandBuilder(da_otd);
            cnn.Close();
        }

        private void button_delete_otd_Click(object sender, EventArgs e)
        {
            string zamena_table = "[отдыхающий]";
            //string zamena_colum = "[фамилия отд]";
            string zamena_row = "[номер отдыхающего]";
            string connectionString = @"Data Source=LAVRHP\SQLEXPRESS;Initial Catalog=СБД;Integrated Security=True";
            string test = string.Format("delete from {0} where {1} = '{2}'", zamena_table, zamena_row, textBox_nomer_otd.Text);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(test, connection);
                int per_dlya_deystviya = command.ExecuteNonQuery();
                MessageBox.Show(string.Format("Обновлено объектов: {0}", per_dlya_deystviya));
                connection.Close();
            }
            cnn.Open();
            da_otd = new SqlDataAdapter("select * from [отдыхающий]", cnn);
            //da_otd = new SqlDataAdapter("select [фамилия отд], [имя отд], [отчество отд], [дата рождения], [пол], [адрес] from [отдыхающий]", cnn);
            ds_otd.Clear();
            da_otd.Fill(ds_otd, "[отдыхающий]");
            dataGridView_otd.DataSource = ds_otd.Tables["[отдыхающий]"];
            bild_otd = new SqlCommandBuilder(da_otd);
            cnn.Close();
        }
    }
}
