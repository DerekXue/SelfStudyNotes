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

namespace 图书管理系统
{
   
    public partial class Login : Form
    {
        //SqlConnection con = new SqlConnection("Data Source=USER\\SQLEXPRESS;Initial Catalog=LmsDb;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From  Profile_Master Where Pro_User_Id='" + textBox1.Text + "' and Pro_Password='" + textBox2.Text + "'", con.ActiveCon());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count==1)
            {
                LMS obj = new LMS();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("invalid username oR password", "Aleart", MessageBoxButtons.OK, MessageBoxIcon.Error);//改变MessageBox格式
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
