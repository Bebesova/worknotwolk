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
    public partial class EditProblem : Form
    {
        public EditProblem(int id_prob)
        {
            id_prob = problem_id;
            InitializeComponent();
        }
        int problem_id;
        static string connString = @"Data Source=MEPHI3-MSSQL;Initial Catalog=Besova_repair;Integrated Security=True";
        SqlConnection sqlConnect = new SqlConnection(connString);
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void EditProblem_Load(object sender, EventArgs e)
        {
           


           
        }
    }
}
