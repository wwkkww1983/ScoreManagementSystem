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
    public partial class Score : Form
    {
        Management management = null;
        public Score(Management management)
        {
            this.management = management;
            InitializeComponent();
        }

        SqlDataAdapter daScore = new SqlDataAdapter();
        SqlDataAdapter daQuery = new SqlDataAdapter();
        DataSet ds = new DataSet("ScoreManagementSystem");

        private void ShowScore()
        {
            string connString = @"Data Source=.\sqlexpress;initial catalog=ScoreManagementSystem;integrated security=true";
            string sql = "select stuId as 学号,stuName as 学生姓名,courseId as 课程号,courseName as 课程名,term as 学期,score as 成绩 from Score";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            daScore.SelectCommand = comm;//把命令对象绑定数据适配器对象
            SqlCommandBuilder builder = new SqlCommandBuilder(daScore);
            daScore.Fill(ds, "Score");//填充数据表/集/源
            table.DataSource = ds.Tables["Score"];//将数据表绑定到DataGridView控件
            conn.Close();
        }

        private void Score_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“scoreManagementSystemDataSet6.Score”中。您可以根据需要移动或删除它。
            this.scoreTableAdapter1.Fill(this.scoreManagementSystemDataSet6.Score);
            // TODO: 这行代码将数据加载到表“scoreManagementSystemDataSet5.Score”中。您可以根据需要移动或删除它。
            //this.scoreTableAdapter.Fill(this.scoreManagementSystemDataSet5.Score);

            //列表去重
            DataTable dtCourse = new DataTable();
            dtCourse.Columns.Add("name", System.Type.GetType("System.String"));
            for (int t = 0; t < courseQuery.Items.Count; t++)
            {
                DataRow row = dtCourse.NewRow();
                row["name"] = ((System.Data.DataRowView)(courseQuery.Items[t])).Row.ItemArray[0].ToString();
                dtCourse.Rows.Add(row);
            }
            if (dtCourse.Rows.Count > 1)
            {
                for (int i = dtCourse.Rows.Count - 1; i >= 0; i--)
                {
                    for (int s = i - 1; s >= 0; s--)
                    {
                        if (dtCourse.Rows[i]["name"].ToString() == dtCourse.Rows[s]["name"].ToString())
                        {
                            dtCourse.Rows.RemoveAt(i);
                            break;
                        }
                    }
                }
            }
            courseQuery.DataSource = dtCourse;
            courseQuery.DisplayMember = "name";

            DataTable dtName = new DataTable();
            dtName.Columns.Add("name", System.Type.GetType("System.String"));
            for (int t = 0; t < nameQuery.Items.Count; t++)
            {
                DataRow row = dtName.NewRow();
                row["name"] = ((System.Data.DataRowView)(nameQuery.Items[t])).Row.ItemArray[1].ToString();
                dtName.Rows.Add(row);
            }
            if (dtName.Rows.Count > 1)
            {
                for (int i = dtName.Rows.Count - 1; i >= 0; i--)
                {
                    for (int s = i - 1; s >= 0; s--)
                    {
                        if (dtName.Rows[i]["name"].ToString() == dtName.Rows[s]["name"].ToString())
                        {
                            dtName.Rows.RemoveAt(i);
                            break;
                        }
                    }
                }
            }
            nameQuery.DataSource = dtName;
            nameQuery.DisplayMember = "name";

            DataTable dtId = new DataTable();
            dtId.Columns.Add("name", System.Type.GetType("System.String"));
            for (int t = 0; t < idQuery.Items.Count; t++)
            {
                DataRow row = dtId.NewRow();
                row["name"] = ((System.Data.DataRowView)(idQuery.Items[t])).Row.ItemArray[0].ToString();
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
            idQuery.DataSource = dtId;
            idQuery.DisplayMember = "name";

            this.idQuery.SelectedIndex = -1;
            this.courseQuery.SelectedIndex = -1;
            this.nameQuery.SelectedIndex = -1;

            ShowScore();
            for (int i = 0; i < table.ColumnCount; i++)
            {
                table.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void Score_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.management.Enabled = true;
        }

        private void btn_id_Click(object sender, EventArgs e)
        {
            query.Visible = true;
            string connString = @"Data Source=.\sqlexpress;initial catalog=ScoreManagementSystem;integrated security=true";
            string sql;
            ds.Clear();
            table.Visible = false;
            sql = "select stuId as 学号,stuName as 学生姓名,courseId as 课程号,courseName as 课程名,term as 学期,score as 成绩 from Score  where stuId = '" + idQuery.Text + "'";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            daQuery.SelectCommand = comm;//把命令对象绑定数据适配器对象
            SqlCommandBuilder builder = new SqlCommandBuilder(daQuery);
            daQuery.Fill(ds, "Score");//填充数据表/集/源
            query.DataSource = ds.Tables["Score"];//将数据表绑定到DataGridView控件
            conn.Close();
            for (int i = 0; i < table.ColumnCount; i++)
            {
                query.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void btn_name_Click(object sender, EventArgs e)
        {
            query.Visible = true;
            string connString = @"Data Source=.\sqlexpress;initial catalog=ScoreManagementSystem;integrated security=true";
            string sql;
            ds.Clear();
            table.Visible = false;
            sql = "select stuId as 学号,stuName as 学生姓名,courseId as 课程号,courseName as 课程名,term as 学期,score as 成绩 from Score  where stuName='" + nameQuery.Text + "'";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            daQuery.SelectCommand = comm;//把命令对象绑定数据适配器对象
            SqlCommandBuilder builder = new SqlCommandBuilder(daScore);
            daQuery.Fill(ds, "Course");//填充数据表/集/源
            query.DataSource = ds.Tables["Course"];//将数据表绑定到DataGridView控件
            conn.Close();
            for (int i = 0; i < table.ColumnCount; i++)
            {
                query.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void btn_course_Click(object sender, EventArgs e)
        {
            query.Visible = true;
            string connString = @"Data Source=.\sqlexpress;initial catalog=ScoreManagementSystem;integrated security=true";
            string sql;
            ds.Clear();
            table.Visible = false;
            sql = "select stuId as 学号,stuName as 学生姓名,courseId as 课程号,courseName as 课程名,term as 学期,score as 成绩 from Score  where  courseName='" + courseQuery.Text + "'";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            daQuery.SelectCommand = comm;//把命令对象绑定数据适配器对象
            SqlCommandBuilder builder = new SqlCommandBuilder(daScore);
            daQuery.Fill(ds, "Course");//填充数据表/集/源
            query.DataSource = ds.Tables["Course"];//将数据表绑定到DataGridView控件
            conn.Close();
            for (int i = 0; i < table.ColumnCount; i++)
            {
                query.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            ds.Clear();
            ShowScore();
            query.Visible = false;
            table.Visible = true;
        }

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_high_Click(object sender, EventArgs e)
        {
            if (highQuery.Text == "不及格成绩")
            {
                query.Visible = true;
                string connString = @"Data Source=.\sqlexpress;initial catalog=ScoreManagementSystem;integrated security=true";
                string sql;
                ds.Clear();
                table.Visible = false;
                sql = "select stuId as 学号,stuName as 学生姓名,courseId as 课程号,courseName as 课程名,term as 学期,score as 成绩 from Score  where score<60";
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                daQuery.SelectCommand = comm;//把命令对象绑定数据适配器对象
                SqlCommandBuilder builder = new SqlCommandBuilder(daScore);
                daQuery.Fill(ds, "Course");//填充数据表/集/源
                query.DataSource = ds.Tables["Course"];//将数据表绑定到DataGridView控件
                conn.Close();
                for (int i = 0; i < table.ColumnCount; i++)
                {
                    query.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
            if (highQuery.Text == "及格成绩")
            {
                query.Visible = true;
                string connString = @"Data Source=.\sqlexpress;initial catalog=ScoreManagementSystem;integrated security=true";
                string sql;
                ds.Clear();
                table.Visible = false;
                sql = "select stuId as 学号,stuName as 学生姓名,courseId as 课程号,courseName as 课程名,term as 学期,score as 成绩 from Score  where score>=60";
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                daQuery.SelectCommand = comm;//把命令对象绑定数据适配器对象
                SqlCommandBuilder builder = new SqlCommandBuilder(daScore);
                daQuery.Fill(ds, "Course");//填充数据表/集/源
                query.DataSource = ds.Tables["Course"];//将数据表绑定到DataGridView控件
                conn.Close();
                for (int i = 0; i < table.ColumnCount; i++)
                {
                    query.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
        }
    }
}
