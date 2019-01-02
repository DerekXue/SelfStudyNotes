using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class LMS : Form
    {

        public LMS()
        {
            InitializeComponent();
        }

        private void LMS_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void roleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Role obj = new Role();
            
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile obj = new Profile();
            
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void memebrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Member obj = new Member();
            
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void planToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plan obj = new Plan();
            
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void rackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rack obj = new Rack();
            
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void sectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Section obj = new Section();
            
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void sectionRackMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Section_Rack_Map obj = new Section_Rack_Map();
            
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void changePassWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Password obj = new Change_Password();
            
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }
    }
}
