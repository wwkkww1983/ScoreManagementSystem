namespace ScoreManagementSystem
{
    partial class Database
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Database));
            this.course = new CCWin.SkinControl.SkinDataGridView();
            this.choose = new CCWin.SkinControl.SkinComboBox();
            this.student = new CCWin.SkinControl.SkinDataGridView();
            this.score = new CCWin.SkinControl.SkinDataGridView();
            this.background = new CCWin.SkinControl.SkinPictureBox();
            this.label = new CCWin.SkinControl.SkinLabel();
            this.idLabel = new CCWin.SkinControl.SkinLabel();
            this.courseLabel = new CCWin.SkinControl.SkinLabel();
            this.nameLabel = new CCWin.SkinControl.SkinLabel();
            this.btn_id = new CCWin.SkinControl.SkinButton();
            this.btn_name = new CCWin.SkinControl.SkinButton();
            this.btn_course = new CCWin.SkinControl.SkinButton();
            this.idQuery = new CCWin.SkinControl.SkinComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scoreManagementSystemDataSet = new ScoreManagementSystem.ScoreManagementSystemDataSet();
            this.nameQuery = new CCWin.SkinControl.SkinComboBox();
            this.courseQuery = new CCWin.SkinControl.SkinComboBox();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scoreManagementSystemDataSet1 = new ScoreManagementSystem.ScoreManagementSystemDataSet1();
            this.save = new CCWin.SkinControl.SkinButton();
            this.cancel = new CCWin.SkinControl.SkinButton();
            this.studentTableAdapter = new ScoreManagementSystem.ScoreManagementSystemDataSetTableAdapters.StudentTableAdapter();
            this.scoreManagementSystemDataSet3 = new ScoreManagementSystem.ScoreManagementSystemDataSet3();
            this.scoreManagementSystemDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new ScoreManagementSystem.ScoreManagementSystemDataSet1TableAdapters.CourseTableAdapter();
            this.query = new CCWin.SkinControl.SkinDataGridView();
            this.help = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.course)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreManagementSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreManagementSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreManagementSystemDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreManagementSystemDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.query)).BeginInit();
            this.SuspendLayout();
            // 
            // course
            // 
            this.course.AllowDrop = true;
            this.course.AllowUserToOrderColumns = true;
            this.course.AllowUserToResizeColumns = false;
            this.course.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.course.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.course.BackgroundColor = System.Drawing.SystemColors.Window;
            this.course.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.course.ColumnFont = new System.Drawing.Font("仿宋", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.course.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("仿宋", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.course.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.course.ColumnHeadersHeight = 30;
            this.course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.course.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.course.DefaultCellStyle = dataGridViewCellStyle3;
            this.course.EnableHeadersVisualStyles = false;
            this.course.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.course.HeadFont = new System.Drawing.Font("仿宋", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.course.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.course.Location = new System.Drawing.Point(0, 78);
            this.course.Name = "course";
            this.course.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.course.RowHeadersWidth = 50;
            this.course.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("仿宋", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.course.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.course.RowTemplate.Height = 23;
            this.course.Size = new System.Drawing.Size(786, 352);
            this.course.TabIndex = 0;
            this.course.TitleBack = null;
            this.course.TitleBackColorBegin = System.Drawing.Color.White;
            this.course.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            this.course.Visible = false;
            // 
            // choose
            // 
            this.choose.CausesValidation = false;
            this.choose.Cursor = System.Windows.Forms.Cursors.Default;
            this.choose.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.choose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.choose.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.choose.FormattingEnabled = true;
            this.choose.ItemBorderColor = System.Drawing.Color.White;
            this.choose.ItemHoverForeColor = System.Drawing.Color.Black;
            this.choose.Items.AddRange(new object[] {
            "学生数据",
            "课程数据",
            "成绩数据"});
            this.choose.Location = new System.Drawing.Point(1, -2);
            this.choose.MaxDropDownItems = 3;
            this.choose.MouseColor = System.Drawing.Color.White;
            this.choose.MouseGradientColor = System.Drawing.Color.White;
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(176, 30);
            this.choose.TabIndex = 5;
            this.choose.TabStop = false;
            this.choose.WaterText = "请选择待管理数据";
            this.choose.SelectedIndexChanged += new System.EventHandler(this.choose_SelectedIndexChanged);
            // 
            // student
            // 
            this.student.AllowDrop = true;
            this.student.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.student.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.student.BackgroundColor = System.Drawing.SystemColors.Window;
            this.student.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.student.ColumnFont = new System.Drawing.Font("仿宋", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.student.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("仿宋", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.student.ColumnHeadersHeight = 30;
            this.student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.student.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.student.DefaultCellStyle = dataGridViewCellStyle7;
            this.student.EnableHeadersVisualStyles = false;
            this.student.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.student.HeadFont = new System.Drawing.Font("仿宋", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.student.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.student.Location = new System.Drawing.Point(0, 78);
            this.student.Name = "student";
            this.student.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.student.RowHeadersWidth = 50;
            this.student.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("仿宋", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.student.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.student.RowTemplate.Height = 23;
            this.student.Size = new System.Drawing.Size(786, 352);
            this.student.TabIndex = 2;
            this.student.TitleBack = null;
            this.student.TitleBackColorBegin = System.Drawing.Color.White;
            this.student.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            this.student.Visible = false;
            this.student.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.student_CellContentClick);
            // 
            // score
            // 
            this.score.AllowDrop = true;
            this.score.AllowUserToOrderColumns = true;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.score.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.score.BackgroundColor = System.Drawing.SystemColors.Window;
            this.score.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.score.ColumnFont = new System.Drawing.Font("仿宋", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.score.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("仿宋", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.score.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.score.ColumnHeadersHeight = 30;
            this.score.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.score.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.score.DefaultCellStyle = dataGridViewCellStyle11;
            this.score.EnableHeadersVisualStyles = false;
            this.score.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.score.HeadFont = new System.Drawing.Font("仿宋", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.score.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.score.Location = new System.Drawing.Point(0, 78);
            this.score.Name = "score";
            this.score.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.score.RowHeadersWidth = 50;
            this.score.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("仿宋", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.score.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.score.RowTemplate.Height = 23;
            this.score.Size = new System.Drawing.Size(786, 352);
            this.score.TabIndex = 3;
            this.score.TitleBack = null;
            this.score.TitleBackColorBegin = System.Drawing.Color.White;
            this.score.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            this.score.Visible = false;
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Transparent;
            this.background.Image = global::ScoreManagementSystem.Properties.Resources.luffy;
            this.background.Location = new System.Drawing.Point(290, 124);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(189, 253);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 6;
            this.background.TabStop = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.BorderColor = System.Drawing.Color.White;
            this.label.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label.Location = new System.Drawing.Point(183, 5);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(118, 17);
            this.label.TabIndex = 1;
            this.label.Text = "<-请选择待管理数据";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.BackColor = System.Drawing.Color.Transparent;
            this.idLabel.BorderColor = System.Drawing.Color.White;
            this.idLabel.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.idLabel.Location = new System.Drawing.Point(-3, 44);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(80, 16);
            this.idLabel.TabIndex = 8;
            this.idLabel.Text = "搜索学号:";
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.BackColor = System.Drawing.Color.Transparent;
            this.courseLabel.BorderColor = System.Drawing.Color.White;
            this.courseLabel.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.courseLabel.Location = new System.Drawing.Point(521, 43);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(80, 16);
            this.courseLabel.TabIndex = 10;
            this.courseLabel.Text = "搜索课程:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.BorderColor = System.Drawing.Color.White;
            this.nameLabel.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameLabel.Location = new System.Drawing.Point(262, 43);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(80, 16);
            this.nameLabel.TabIndex = 12;
            this.nameLabel.Text = "搜索姓名:";
            // 
            // btn_id
            // 
            this.btn_id.BackColor = System.Drawing.Color.Transparent;
            this.btn_id.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_id.DownBack = null;
            this.btn_id.Location = new System.Drawing.Point(220, 43);
            this.btn_id.MouseBack = null;
            this.btn_id.Name = "btn_id";
            this.btn_id.NormlBack = null;
            this.btn_id.Size = new System.Drawing.Size(30, 23);
            this.btn_id.TabIndex = 13;
            this.btn_id.Text = "√";
            this.btn_id.UseVisualStyleBackColor = false;
            this.btn_id.Click += new System.EventHandler(this.btn_id_Click);
            // 
            // btn_name
            // 
            this.btn_name.BackColor = System.Drawing.Color.Transparent;
            this.btn_name.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_name.DownBack = null;
            this.btn_name.Location = new System.Drawing.Point(485, 42);
            this.btn_name.MouseBack = null;
            this.btn_name.Name = "btn_name";
            this.btn_name.NormlBack = null;
            this.btn_name.Size = new System.Drawing.Size(30, 23);
            this.btn_name.TabIndex = 14;
            this.btn_name.Text = "√";
            this.btn_name.UseVisualStyleBackColor = false;
            this.btn_name.Click += new System.EventHandler(this.btn_name_Click);
            // 
            // btn_course
            // 
            this.btn_course.BackColor = System.Drawing.Color.Transparent;
            this.btn_course.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_course.DownBack = null;
            this.btn_course.Location = new System.Drawing.Point(744, 43);
            this.btn_course.MouseBack = null;
            this.btn_course.Name = "btn_course";
            this.btn_course.NormlBack = null;
            this.btn_course.Size = new System.Drawing.Size(30, 23);
            this.btn_course.TabIndex = 15;
            this.btn_course.Text = "√";
            this.btn_course.UseVisualStyleBackColor = false;
            this.btn_course.Click += new System.EventHandler(this.btn_course_Click);
            // 
            // idQuery
            // 
            this.idQuery.DataSource = this.studentBindingSource;
            this.idQuery.DisplayMember = "stuId";
            this.idQuery.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.idQuery.FormattingEnabled = true;
            this.idQuery.Location = new System.Drawing.Point(83, 42);
            this.idQuery.Name = "idQuery";
            this.idQuery.Size = new System.Drawing.Size(131, 22);
            this.idQuery.TabIndex = 16;
            this.idQuery.WaterText = "";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.scoreManagementSystemDataSet;
            // 
            // scoreManagementSystemDataSet
            // 
            this.scoreManagementSystemDataSet.DataSetName = "ScoreManagementSystemDataSet";
            this.scoreManagementSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nameQuery
            // 
            this.nameQuery.DataSource = this.studentBindingSource;
            this.nameQuery.DisplayMember = "stuName";
            this.nameQuery.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.nameQuery.FormattingEnabled = true;
            this.nameQuery.Location = new System.Drawing.Point(348, 43);
            this.nameQuery.Name = "nameQuery";
            this.nameQuery.Size = new System.Drawing.Size(131, 22);
            this.nameQuery.TabIndex = 17;
            this.nameQuery.WaterText = "";
            // 
            // courseQuery
            // 
            this.courseQuery.DataSource = this.courseBindingSource;
            this.courseQuery.DisplayMember = "courseName";
            this.courseQuery.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.courseQuery.FormattingEnabled = true;
            this.courseQuery.Location = new System.Drawing.Point(607, 43);
            this.courseQuery.Name = "courseQuery";
            this.courseQuery.Size = new System.Drawing.Size(131, 22);
            this.courseQuery.TabIndex = 18;
            this.courseQuery.WaterText = "";
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.scoreManagementSystemDataSet1;
            // 
            // scoreManagementSystemDataSet1
            // 
            this.scoreManagementSystemDataSet1.DataSetName = "ScoreManagementSystemDataSet1";
            this.scoreManagementSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Transparent;
            this.save.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.save.DownBack = null;
            this.save.Font = new System.Drawing.Font("仿宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.save.Location = new System.Drawing.Point(378, 5);
            this.save.MouseBack = null;
            this.save.Name = "save";
            this.save.NormlBack = null;
            this.save.Size = new System.Drawing.Size(111, 32);
            this.save.TabIndex = 19;
            this.save.Text = "保存更新";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Transparent;
            this.cancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cancel.DownBack = null;
            this.cancel.Font = new System.Drawing.Font("仿宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel.Location = new System.Drawing.Point(508, 5);
            this.cancel.MouseBack = null;
            this.cancel.Name = "cancel";
            this.cancel.NormlBack = null;
            this.cancel.Size = new System.Drawing.Size(111, 32);
            this.cancel.TabIndex = 20;
            this.cancel.Text = "取消更新";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // scoreManagementSystemDataSet3
            // 
            this.scoreManagementSystemDataSet3.DataSetName = "ScoreManagementSystemDataSet3";
            this.scoreManagementSystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scoreManagementSystemDataSet3BindingSource
            // 
            this.scoreManagementSystemDataSet3BindingSource.DataSource = this.scoreManagementSystemDataSet3;
            this.scoreManagementSystemDataSet3BindingSource.Position = 0;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // query
            // 
            this.query.AllowDrop = true;
            this.query.AllowUserToOrderColumns = true;
            this.query.AllowUserToResizeColumns = false;
            this.query.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.query.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.query.BackgroundColor = System.Drawing.SystemColors.Window;
            this.query.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.query.ColumnFont = new System.Drawing.Font("仿宋", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.query.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("仿宋", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.query.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.query.ColumnHeadersHeight = 30;
            this.query.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.query.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.query.DefaultCellStyle = dataGridViewCellStyle15;
            this.query.EnableHeadersVisualStyles = false;
            this.query.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.query.HeadFont = new System.Drawing.Font("仿宋", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.query.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.query.Location = new System.Drawing.Point(0, 78);
            this.query.Name = "query";
            this.query.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.query.RowHeadersWidth = 50;
            this.query.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("仿宋", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.query.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.query.RowTemplate.Height = 23;
            this.query.Size = new System.Drawing.Size(786, 352);
            this.query.TabIndex = 22;
            this.query.TitleBack = null;
            this.query.TitleBackColorBegin = System.Drawing.Color.White;
            this.query.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            this.query.Visible = false;
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.Transparent;
            this.help.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.help.DownBack = null;
            this.help.Location = new System.Drawing.Point(642, 5);
            this.help.MouseBack = null;
            this.help.Name = "help";
            this.help.NormlBack = null;
            this.help.Size = new System.Drawing.Size(33, 32);
            this.help.TabIndex = 23;
            this.help.Text = "？";
            this.help.UseVisualStyleBackColor = false;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // Database
            // 
            this.AcceptButton = this.save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(786, 431);
            this.Controls.Add(this.help);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.courseQuery);
            this.Controls.Add(this.nameQuery);
            this.Controls.Add(this.idQuery);
            this.Controls.Add(this.btn_course);
            this.Controls.Add(this.btn_name);
            this.Controls.Add(this.btn_id);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.courseLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.label);
            this.Controls.Add(this.choose);
            this.Controls.Add(this.course);
            this.Controls.Add(this.score);
            this.Controls.Add(this.student);
            this.Controls.Add(this.background);
            this.Controls.Add(this.query);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Database";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Database_FormClosing);
            this.Load += new System.EventHandler(this.Database_Load);
            ((System.ComponentModel.ISupportInitialize)(this.course)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreManagementSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreManagementSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreManagementSystemDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreManagementSystemDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.query)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinDataGridView course;
        private CCWin.SkinControl.SkinComboBox choose;
        private CCWin.SkinControl.SkinDataGridView student;
        private CCWin.SkinControl.SkinDataGridView score;
        private CCWin.SkinControl.SkinPictureBox background;
        private CCWin.SkinControl.SkinLabel label;
        private CCWin.SkinControl.SkinLabel idLabel;
        private CCWin.SkinControl.SkinLabel courseLabel;
        private CCWin.SkinControl.SkinLabel nameLabel;
        private CCWin.SkinControl.SkinButton btn_id;
        private CCWin.SkinControl.SkinButton btn_name;
        private CCWin.SkinControl.SkinButton btn_course;
        private CCWin.SkinControl.SkinComboBox idQuery;
        private CCWin.SkinControl.SkinComboBox nameQuery;
        private CCWin.SkinControl.SkinComboBox courseQuery;
        private CCWin.SkinControl.SkinButton save;
        private CCWin.SkinControl.SkinButton cancel;
        private ScoreManagementSystemDataSet scoreManagementSystemDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private ScoreManagementSystemDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private ScoreManagementSystemDataSet3 scoreManagementSystemDataSet3;
        private System.Windows.Forms.BindingSource scoreManagementSystemDataSet3BindingSource;
        private ScoreManagementSystemDataSet1 scoreManagementSystemDataSet1;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private ScoreManagementSystemDataSet1TableAdapters.CourseTableAdapter courseTableAdapter;
        private CCWin.SkinControl.SkinDataGridView query;
        private CCWin.SkinControl.SkinButton help;
    }
}