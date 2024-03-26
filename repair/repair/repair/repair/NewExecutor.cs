using Microsoft.SqlServer.Server;
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

namespace repair
{
    public partial class NewExecutor : Form
    {
        int Problem_id;
        public NewExecutor(int pr_id)
        {
            InitializeComponent();
            Problem_id = pr_id;
        }
        int User_id;
        static string connString = @"Data Source=MEPHI3-MSSQL;Initial Catalog=Besova_repair;Integrated Security=True";
        SqlConnection sqlConnect = new SqlConnection(connString);
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NewExecutor_Load(object sender, EventArgs e)
        {
            SqlCommand logRequst = new SqlCommand();



            logRequst.CommandText = $"SELECT * FROM Order Where id_role = 2";
            logRequst.Connection = sqlConnect;
            SqlDataAdapter adapter = new SqlDataAdapter(logRequst);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            DGExecutor.DataSource = dataSet.Tables[0];
            DGExecutor.Columns[10].Visible = false;
        }

        private void DGExecutor_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            User_id = Convert.ToInt32(DGExecutor.Rows[e.RowIndex].Cells[0].Value);
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
