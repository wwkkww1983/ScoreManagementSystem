using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreManagementSystem
{
    public partial class Management : Form
    {
        Main main = null;
        public Management(Main main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void skinPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Management_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.main.Enabled = true;
            this.Close();
        }

        private void Management_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.main.Enabled = true;
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("学生成绩管理信息系统^_^\n" +
                "支持快速录入成绩\n" +
                "学生、课程、成绩信息管理\n" +
                "以及学生成绩综合查询","帮助",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void database_Click(object sender, EventArgs e)
        {
            Database database = new Database(this);
            this.Enabled = false;
            database.Show();
        }

        private void query_Click(object sender, EventArgs e)
        {
            Score score = new Score(this);
            this.Enabled = false;
            score.Show();
        }
    }
}
