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
    public partial class vrach : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=LAVRHP\SQLEXPRESS;Initial Catalog=СБД;Integrated Security=True");
        SqlCommand cmd_nazn = new SqlCommand();
        SqlDataAdapter da_nazn;
        DataSet ds_nazn = new DataSet();
        SqlCommandBuilder bild_nazn;
        string per_nazn_login_sotrudnika;
        DateTime per_nazn_date;
        public vrach(string per)
        {
            InitializeComponent();
            this.per_nazn_login_sotrudnika = per;
        }

        private void vrach_Load(object sender, EventArgs e)
        {

        }

        private void button_open_jurnal_Click(object sender, EventArgs e)
        {
            per_nazn_date = Convert.ToDateTime(dateTimePicker_jurnal.Value);
            cnn.Open();
            cmd_nazn = new SqlCommand("select * from [журнал назначений] where [название назначения] = (select [название назначения] from [назначения] where [номер спецсот] = (select [номер спецсот] from [специальности сотрудников] where [логин] = @login)) and [дата]=@date", cnn);
            da_nazn = new SqlDataAdapter(cmd_nazn.CommandText, cnn);
            da_nazn.SelectCommand.Parameters.Add("@login", SqlDbType.VarChar);
            da_nazn.SelectCommand.Parameters["@login"].Value = this.per_nazn_login_sotrudnika;
            da_nazn.SelectCommand.Parameters.Add("@date", SqlDbType.Date);
            da_nazn.SelectCommand.Parameters["@date"].Value = per_nazn_date;
            ds_nazn.Clear();
            da_nazn.Fill(ds_nazn, "[журнал назначений]");
            dataGridView_nazn.DataSource = ds_nazn.Tables["[журнал назначений]"];
            bild_nazn = new SqlCommandBuilder(da_nazn);
            cnn.Close();
        }

        private void button_open_nazn_Click(object sender, EventArgs e)
        {
            this.Hide();
            otdelnoe_nazn vrachform = new otdelnoe_nazn(textBox_enter_nazn.Text, per_nazn_login_sotrudnika);
            vrachform.Show();
        }
    }
}
