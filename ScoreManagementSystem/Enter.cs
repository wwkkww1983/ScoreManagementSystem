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

namespace ScoreManagementSystem
{
    public partial class Enter : Form
    {
        Main main = null;
        public Enter(Main main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void skinCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (lockCourse.Checked)
            {
                courseId.Enabled = false;
            }
            else
            {
                courseId.Enabled = true;
            }
        }

        DataSet ds = new DataSet("ScoreManagementSystem");

        private void Enter_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“scoreManagementSystemDataSet7.Score”中。您可以根据需要移动或删除它。
            this.scoreTableAdapter1.Fill(this.scoreManagementSystemDataSet7.Score);
            // TODO: 这行代码将数据加载到表“scoreManagementSystemDataSet2.Course”中。您可以根据需要移动或删除它。
            this.courseTableAdapter.Fill(this.scoreManagementSystemDataSet2.Course);
            // TODO: 这行代码将数据加载到表“scoreManagementSystemDataSet3.Course”中。您可以根据需要移动或删除它。

            //列表去重
            DataTable dtId = new DataTable();
            dtId.Columns.Add("name", System.Type.GetType("System.String"));
            for (int t = 0; t < courseId.Items.Count; t++)
            {
                DataRow row = dtId.NewRow();
                row["name"] = ((System.Data.DataRowView)(courseId.Items[t])).Row.ItemArray[0].ToString();
                dtId.Rows.Add(row);
            }
            if (dtId.Rows.Count > 1)
            {
                for (int i = dtId.Rows.Count - 1; i >= 0; i--)
                {
                    for (int s = i - 1; s >= 0; s--)
                    {
                        if (dtId.Rows[i]["name"].ToString() == dtId.Rows[s]["name"].ToString())
                        {
                            dtId.Rows.RemoveAt(i);
                            break;
                        }
                    }
                }
            }
            courseId.DataSource = dtId;
            courseId.DisplayMember = "name";

            this.courseId.SelectedIndex = -1;
            this.term.SelectedIndex = -1;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            go();
            this.main.Enabled = true;
            this.Close();
        }

        void go()
        {
            string connString = @"Data Source=.\sqlexpress;initial catalog=ScoreManagementSystem;integrated security=true";
            SqlConnection con = new SqlConnection(connString);
            if (id.Text == "" || term.Text == "" || courseId.Text == "")
            {
                MessageBox.Show("必填项不能为空！", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            con.Open();
            //写入数据库
            // and stuName = (select stuName from Student where stuId='" + id.Text + "')
            string sqlAdd = "insert into Score values('" + id.Text + "',(select stuName from Student where stuId='" + id.Text + "'),'" + courseId.Text + "',(select courseName from Course where courseId='" + courseId.Text + "'),'" + score.Text + "','" + term.Text + "')";
            SqlCommand commandAdd = new SqlCommand(sqlAdd, con);
            int count = commandAdd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("登记成功！", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("登记失败！", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }

        private void Enter_FormClosed(object sender, FormClosingEventArgs e)
        {
            this.main.Enabled = true;
        }

        private void lockTerm_CheckedChanged(object sender, EventArgs e)
        {
            if (lockTerm.Checked)
            {
                term.Enabled = false;
            }
            else
            {
                term.Enabled = true;
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            go();
            id.Text = "";
            score.Text = "";
        }

        private void courseId_TextUpdate(object sender, EventArgs e)
        {
        }
    }
}
