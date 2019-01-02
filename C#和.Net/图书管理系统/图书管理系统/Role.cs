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
    public partial class Role : Form
    {
        public Role()
        {
            InitializeComponent();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteRecords();
            ViewGrid();
            MessageBox.Show("Delete Ok");
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            AddRecords();
            
            CreateNew();
            ViewGrid();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            UpdaRecords();
            MessageBox.Show("Update success");
            ViewGrid();

        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            ViewGrid();
            CreateNew();
            
        }
        void CreateNew()
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;

            Connection con = new Connection();
            SqlDataAdapter sda = new SqlDataAdapter("Proc_New_Role", con.ActiveCon());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            textBox1.Text = dt.Rows[0][0].ToString();
            textBox2.Focus();
        }
        void AddRecords()
        {
            try
            {
                if (Validate())
                {
                    Connection con = new Connection();
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO [Role_Master]
            ([Role_Id]
            ,[Role]
            ,[Role_Status])
            VALUES
                ('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "')", con.ActiveCon());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Records Inserted SuccessFully..!");
                }
                else
                {
                    MessageBox.Show("Please Check All The Fileds");
                }
            }
            catch(Exception Ex)
            {
                InsertError("AddRecords", "Role",Ex.Message.ToString());
            }
        }

        private void Role_Load(object sender, EventArgs e)
        {
            CreateNew();
            ViewGrid();
            
        }

        void ViewGrid()
        {
            Connection con = new Connection();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From Role_Master",con.ActiveCon());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = (n + 1).ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["Role_Id"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["Role"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["Role_Status"].ToString();  
            }
            label4.Text = "Row Count :" + dataGridView1.Rows.Count.ToString();


        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            int n = dataGridView1.SelectedRows[0].Index;
            textBox1.Text = dataGridView1.Rows[n].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[n].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[n].Cells[3].Value.ToString();
            
        }

        void UpdaRecords()
        {
            if (Validate())
            {
                Connection con = new Connection();
                SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[Role_Master]
   SET [Role] = '" + textBox2.Text + "',[Role_Status] = '" + comboBox1.Text + "'WHERE [Role_Id] = '" + textBox1.Text + "'", con.ActiveCon());
                cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Please Check All The Fileds");
            }
        }

        void DeleteRecords()
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"Delete From [dbo].[Role_Master] where [Role_Id] ='"+textBox1.Text+"'", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }
        bool Validate()
        {
            bool ReturnVal = true;
                if(textBox2.Text.Length==0)
                {
                    ReturnVal=false;
                }
            if(comboBox1.SelectedIndex==-1)
            {
                ReturnVal = false;
            }
            return ReturnVal;
        }

        void InsertError(String Error_Fun,string Error_Page,string Error_Txt)
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand("Proc_Insert_Error", con.ActiveCon());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Error_Fun", SqlDbType.VarChar, 50).Value = Error_Fun;
            cmd.Parameters.Add("@Error_Page", SqlDbType.VarChar, 50).Value = Error_Page;
            cmd.Parameters.Add("@Error_Txt", SqlDbType.VarChar, -1).Value = Error_Txt;//-1 意思是函数takes which what ever the texts is coming
            cmd.ExecuteNonQuery();   
        }
    }
}
