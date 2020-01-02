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
    public partial class Database : Form
    {
        SqlDataAdapter daCourse = new SqlDataAdapter();
        SqlDataAdapter daStudent = new SqlDataAdapter();
        SqlDataAdapter daScore = new SqlDataAdapter();
        SqlDataAdapter daQuery = new SqlDataAdapter();
        DataSet ds = new DataSet("ScoreManagementSystem");

        private void ShowCourses()
        {
            string connString = @"Data Source=.\sqlexpress;initial catalog=ScoreManagementSystem;integrated security=true";
            string sql = "select courseId as 课程编号,courseName as 课程名,type as 类型,point as 学分 from Course";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            daCourse.SelectCommand = comm;//把命令对象绑定数据适配器对象
            SqlCommandBuilder builder = new SqlCommandBuilder(daCourse);
            daCourse.Fill(ds, "Course");//填充数据表/集/源
            course.DataSource = ds.Tables["Course"];//将数据表绑定到DataGridView控件
            conn.Close();
        }

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
            score.DataSource = ds.Tables["Score"];//将数据表绑定到DataGridView控件
            conn.Close();
        }

        private void ShowStudent()
        {
            string connString = @"Data Source=.\sqlexpress;initial catalog=ScoreManagementSystem;integrated security=true";
            string sql = "select stuId as 学号,stuName as 学生姓名,sex as 性别,department as 系别,class as 班级 from Student";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            daStudent.SelectCommand = comm;//把命令对象绑定数据适配器对象
            SqlCommandBuilder builder = new SqlCommandBuilder(daStudent);
            daStudent.Fill(ds, "Student");//填充数据表/集/源
            student.DataSource = ds.Tables["Student"];//将数据表绑定到DataGridView控件
            conn.Close();
        }

        Management management = null;
        public Database(Management management)
        {
            this.management = management;
            InitializeComponent();
        }

        private void Database_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“scoreManagementSystemDataSet1.Course”中。您可以根据需要移动或删除它。
            this.courseTableAdapter.Fill(this.scoreManagementSystemDataSet1.Course);
            // TODO: 这行代码将数据加载到表“scoreManagementSystemDataSet.Student”中。您可以根据需要移动或删除它。
            this.studentTableAdapter.Fill(this.scoreManagementSystemDataSet.Student);

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
        }

        private void Database_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.management.Enabled = true;
        }

        private void choose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (choose.Text == "学生数据")
            {
                ds.Clear();
                ShowStudent();
                student.Refresh();
                student.Visible = true;
                score.Visible = false;
                course.Visible = false;
                query.Visible = false;
                for (int i = 0; i < student.ColumnCount; i++)
                {
                    student.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
            if (choose.Text == "课程数据")
            {
                ds.Clear();
                ShowCourses();
                score.Refresh();
                student.Visible = false;
                score.Visible = false;
                course.Visible = true;
                query.Visible = false;
                for (int i = 0; i < course.ColumnCount; i++)
                {
                    course.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                }
            }
            if (choose.Text == "成绩数据")
            {
                ds.Clear();
                ShowScore();
                score.Refresh();
                student.Visible = false;
                score.Visible = true;
                course.Visible = false;
                query.Visible = false;
                for (int i = 0; i < score.ColumnCount; i++)
                {
                    score.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
        }

        private void student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            if(score.Visible)
            {
                try
                {
                    daScore.Update(ds, "Score");
                    MessageBox.Show("数据更新成功！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("数据更新失败！","注意",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            if (student.Visible)
            {
                try
                {
                    daStudent.Update(ds, "Student");
                    MessageBox.Show("数据更新成功！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("数据更新失败！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (course.Visible)
            {
                try
                {
                    daCourse.Update(ds, "Course");
                    MessageBox.Show("数据更新成功！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("数据更新失败！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确定取消目前添加、修改、删除操作？", "注意", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                ds.Clear();
                ShowCourses();
                ShowScore();
                ShowStudent();
                student.Refresh();
                course.Refresh();
                score.Refresh();
            }
        }

        private void btn_course_Click(object sender, EventArgs e)
        {
            if (choose.Text=="成绩数据"|| choose.Text == "课程数据")
            {
                query.Visible = true;
                string connString = @"Data Source=.\sqlexpress;initial catalog=ScoreManagementSystem;integrated security=true";
                string sql;
                ds.Clear();
                if (choose.Text == "课程数据")
                {
                    course.Visible = false;
                    sql = "select courseId as 课程编号,courseName as 课程名,type as 类型,point as 学分 from Course where courseName='" + courseQuery.Text + "'";
                    SqlConnection conn = new SqlConnection(connString);
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql, conn);
                    daQuery.SelectCommand = comm;//把命令对象绑定数据适配器对象
                    daQuery.Fill(ds, "Course");//填充数据表/集/源
                    query.DataSource = ds.Tables["Course"];//将数据表绑定到DataGridView控件
                    conn.Close();
                }
                else
                {
                    score.Visible = false;
                    sql = "select stuId as 学号,stuName as 学生姓名,courseId as 课程号,courseName as 课程名,term as 学期,score as 成绩 from Score  where courseName='" + courseQuery.Text + "'";
                    SqlConnection conn = new SqlConnection(connString);
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql, conn);
                    daQuery.SelectCommand = comm;//把命令对象绑定数据适配器对象
                    daQuery.Fill(ds, "Score");//填充数据表/集/源
                    query.DataSource = ds.Tables["Score"];//将数据表绑定到DataGridView控件
                    conn.Close();
                }
                for (int i = 0; i < query.ColumnCount; i++)
                {
                    query.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
        }

        private void btn_id_Click(object sender, EventArgs e)
        {
            if (choose.Text == "成绩数据" || choose.Text == "学生数据")
            {
                query.Visible = true;
                string connString = @"Data Source=.\sqlexpress;initial catalog=ScoreManagementSystem;integrated security=true";
                string sql;
                ds.Clear();
                if (choose.Text == "学生数据")
                {
                    student.Visible = false;
                    sql = "select stuId as 学号,stuName as 学生姓名,sex as 性别,department as 系别,class as 班级 from Student where stuId='" + idQuery.Text + "'";
                    SqlConnection conn = new SqlConnection(connString);
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql, conn);
                    daQuery.SelectCommand = comm;//把命令对象绑定数据适配器对象
                    daQuery.Fill(ds, "Student");//填充数据表/集/源
                    query.DataSource = ds.Tables["Student"];//将数据表绑定到DataGridView控件
                    conn.Close();
                }
                else
                {
                    score.Visible = false;
                    sql = "select stuId as 学号,stuName as 学生姓名,courseId as 课程号,courseName as 课程名,term as 学期,score as 成绩 from Score  where stuId='" + idQuery.Text + "'";
                    SqlConnection conn = new SqlConnection(connString);
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql, conn);
                    daQuery.SelectCommand = comm;//把命令对象绑定数据适配器对象
                    daQuery.Fill(ds, "Score");//填充数据表/集/源
                    query.DataSource = ds.Tables["Score"];//将数据表绑定到DataGridView控件
                    conn.Close();
                }
                for (int i = 0; i < query.ColumnCount; i++)
                {
                    query.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
        }

        private void btn_name_Click(object sender, EventArgs e)
        {
            if (choose.Text == "成绩数据" || choose.Text == "学生数据")
            {
                query.Visible = true;
                string connString = @"Data Source=.\sqlexpress;initial catalog=ScoreManagementSystem;integrated security=true";
                string sql;
                ds.Clear();
                if (choose.Text == "学生数据")
                {
                    student.Visible = false;
                    sql = "select stuId as 学号,stuName as 学生姓名,sex as 性别,department as 系别,class as 班级 from Student where stuName='" + nameQuery.Text + "'";
                    SqlConnection conn = new SqlConnection(connString);
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql, conn);
                    daQuery.SelectCommand = comm;//把命令对象绑定数据适配器对象
                    daQuery.Fill(ds, "Student");//填充数据表/集/源
                    query.DataSource = ds.Tables["Student"];//将数据表绑定到DataGridView控件
                    conn.Close();
                }
                else
                {
                    score.Visible = false;
                    sql = "select stuId as 学号,stuName as 学生姓名,courseId as 课程号,courseName as 课程名,term as 学期,score as 成绩 from Score  where stuName='" + nameQuery.Text + "'";
                    SqlConnection conn = new SqlConnection(connString);
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql, conn);
                    daQuery.SelectCommand = comm;//把命令对象绑定数据适配器对象
                    daQuery.Fill(ds, "Score");//填充数据表/集/源
                    query.DataSource = ds.Tables["Score"];//将数据表绑定到DataGridView控件
                    conn.Close();
                }
                for (int i = 0; i < query.ColumnCount; i++)
                {
                    query.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tips:\n按F2或双击\n可编辑选中单元格\n\n注意学号、姓名、\n课程号、课程名\n不可为空\n","Tips",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
