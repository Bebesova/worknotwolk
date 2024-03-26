using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace repair
{
    public partial class Order : Form
    {
        int id_user;
        public Order(int id_u)
        {
            id_u = id_user;
            InitializeComponent();
        }
        static string connString = @"Data Source=MEPHI3-MSSQL;Initial Catalog=Besova_repair;Integrated Security=True";
        SqlConnection sqlConnect = new SqlConnection(connString);
        string num = "";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            User_windows form = new User_windows(id_user);
            form.ShowDialog();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            
            LDate.Text += DateTime.Now.ToLongDateString();
            Random rand = new Random();
            string pool = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            
            int count = 1;
            while(count!=0)
            {
                for (int x = 0; x < 7; x++)
                {
                    num += pool[rand.Next(0, pool.Length)].ToString();
                }
                sqlConnect.Open();
                SqlCommand check = new SqlCommand($"SELECT COUNT(*) as con FROM Order Where Number ={num} ");
                check.Connection = sqlConnect;
                SqlDataReader rd = check.ExecuteReader();
                while (rd.Read())
                {
                    count = Convert.ToInt32(rd["con"]);
                }

                sqlConnect.Close();

            }
            
                
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            SqlCommand regust = new SqlCommand($"insert into Order (Name, desctiption,id_priority,date_registration,Number, User_id)" +
                $"select {RTBproblem.Text},{RTBDist.Text},{CBPriority.SelectedIndex},{DateTime.Now.ToLongDateString()},{num},{id_user}");
            regust.Connection = sqlConnect;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
