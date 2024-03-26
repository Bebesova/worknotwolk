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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace repair
{
    public partial class Manager_menu : Form
    {
        int id_us;
        public Manager_menu(int id_user)
        {
            id_us = id_user;
            InitializeComponent();
        }
        static string connString = @"Data Source=MEPHI3-MSSQL;Initial Catalog=Besova_repair;Integrated Security=True";
        SqlConnection sqlConnect = new SqlConnection(connString);
        int Order_id = 1;
        int Problem_id;
        private void Manager_menu_Load(object sender, EventArgs e)
        {
            SqlCommand Order= new SqlCommand();
            Order.CommandText = $"SELECT * FROM Order ";
            Order.Connection = sqlConnect;
            SqlDataAdapter adapter = new SqlDataAdapter(Order);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            employeesDG.DataSource = dataSet.Tables[0];
            employeesDG.Columns[0].Visible = false;
            

            SqlCommand Problem = new SqlCommand();
            Problem.CommandText = $"Select* from Order_problem Where id_order ={Order_id}";
            Problem.Connection = sqlConnect;
            SqlDataAdapter Opopop = new SqlDataAdapter(Problem);
            DataSet dataSetp = new DataSet();
            Opopop.Fill(dataSetp);
            DGProblem.DataSource = dataSetp.Tables[0];
            DGProblem.Columns[0].Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CBfilterStatus.SelectedIndex)
            {
                case 0:
                    (employeesDG.DataSource as DataTable).DefaultView.RowFilter = $"[Status] = 'Не начато ";
                    break;
                case 1:
                    (employeesDG.DataSource as DataTable).DefaultView.RowFilter = $"[Status] = 'В работе' ";
                    break;
                case 2:
                    (employeesDG.DataSource as DataTable).DefaultView.RowFilter = $"[Status] >= 'Выполнен'";
                    break;
                case 3:
                    (employeesDG.DataSource as DataTable).DefaultView.RowFilter = "";
                    break;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void employeesDG_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Order_id = Convert.ToInt32(employeesDG.Rows[e.RowIndex].Cells[0].Value);
        }

        

        private void BEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Problem_id = Convert.ToInt32(employeesDG.Rows[e.RowIndex].Cells[0].Value);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            NewExecutor fr = new NewExecutor(Problem_id);
            fr.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditProblem edform = new EditProblem(Problem_id);
                edform.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Аuth form = new Аuth();
            this.Hide();
            form.ShowDialog();
        }
    }
}
