using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace repair
{
    public partial class NewProblem : Form
    {
        public NewProblem()
        {
            InitializeComponent();
        }
        static string connString = @"Data Source=MEPHI3-MSSQL;Initial Catalog=Besova_repair;Integrated Security=True";
        SqlConnection sqlConnect = new SqlConnection(connString);

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        class Executor 
            {
            public int IDEx { get; set; }
            public string NameEx { get; set; }
        }
      
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();

            SqlCommand logRequst = new SqlCommand();
            logRequst.Connection = sqlConnect;
            logRequst.CommandType = CommandType.StoredProcedure;
            logRequst.CommandText = "NewProblem";


            logRequst.Parameters.AddWithValue("@Name", RTProblem.Text);
            logRequst.Parameters.AddWithValue("@Executor", CBEx.ValueMember);
            logRequst.Parameters.AddWithValue("@priority", CBPriority.SelectedIndex);

            try
            {
                logRequst.ExecuteNonQuery();
                MessageBox.Show("Заявка добавлена");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка! : " + ex.Message);
            }
            finally
            {
                sqlConnect.Close();

            }
        }

        private void NewProblem_Load(object sender, EventArgs e)
        {
            if (sqlConnect.State == ConnectionState.Closed)
                sqlConnect.Open();


            List<Executor> execut = new List<Executor>();
            SqlCommand logRequstspel = new SqlCommand("Select Surname +' '+ Name + ' '+ Patronymic from User", sqlConnect);
            logRequstspel.Connection = sqlConnect;
            SqlDataReader rdr = logRequstspel.ExecuteReader();
            while (rdr.Read())
            {
                execut.Add(new Executor { IDEx = rdr.GetInt32(0), NameEx = rdr.GetString(1) });

            }
            CBEx.DataSource = execut;
            CBEx.ValueMember = "IDspel";
            CBEx.DisplayMember = "Namespel";
            sqlConnect.Close();


        }
    }
}
