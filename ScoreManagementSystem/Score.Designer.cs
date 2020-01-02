namespace ScoreManagementSystem
{
    partial class Score
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Score));
            this.nameQuery = new CCWin.SkinControl.SkinComboBox();
            this.idQuery = new CCWin.SkinControl.SkinComboBox();
            this.btn_course = new CCWin.SkinControl.SkinButton();
            this.btn_name = new CCWin.SkinControl.SkinButton();
            this.btn_id = new CCWin.SkinControl.SkinButton();
            this.nameLabel = new CCWin.SkinControl.SkinLabel();
            this.courseLabel = new CCWin.SkinControl.SkinLabel();
            this.idLabel = new CCWin.SkinControl.SkinLabel();
            this.highQuery = new CCWin.SkinControl.SkinComboBox();
            this.btn_high = new CCWin.SkinControl.SkinButton();
            this.highLabel = new CCWin.SkinControl.SkinLabel();
            this.table = new CCWin.SkinControl.SkinDataGridView();
            this.query = new CCWin.SkinControl.SkinDataGridView();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.scoreManagementSystemDataSet6 = new ScoreManagementSystem.ScoreManagementSystemDataSet6();
            this.scoreBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.scoreTableAdapter1 = new ScoreManagementSystem.ScoreManagementSystemDataSet6TableAdapters.ScoreTableAdapter();
            this.scoreTableAdapter = new ScoreManagementSystem.ScoreManagementSystemDataSet5TableAdapters.ScoreTableAdapter();
            this.scoreManagementSystemDataSet5 = new ScoreManagementSystem.ScoreManagementSystemDataSet5();
            this.scoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseQuery = new CCWin.SkinControl.SkinComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.query)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreManagementSystemDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreManagementSystemDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameQuery
            // 
            this.nameQuery.DataSource = this.scoreBindingSource1;
            this.nameQuery.DisplayMember = "stuName";
            this.nameQuery.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.nameQuery.FormattingEnabled = true;
            this.nameQuery.Location = new System.Drawing.Point(360, 12);
            this.nameQuery.Name = "nameQuery";
            this.nameQuery.Size = new System.Drawing.Size(131, 22);
            this.nameQuery.TabIndex = 26;
            this.nameQuery.WaterText = "";
            // 
            // idQuery
            // 
            this.idQuery.DataSource = this.scoreBindingSource1;
            this.idQuery.DisplayMember = "stuId";
            this.idQuery.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.idQuery.FormattingEnabled = true;
            this.idQuery.Location = new System.Drawing.Point(95, 11);
            this.idQuery.Name = "idQuery";
            this.idQuery.Size = new System.Drawing.Size(131, 22);
            this.idQuery.TabIndex = 25;
            this.idQuery.WaterText = "";
            // 
            // btn_course
            // 
            this.btn_course.BackColor = System.Drawing.Color.Transparent;
            this.btn_course.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_course.DownBack = null;
            this.btn_course.Location = new System.Drawing.Point(756, 12);
            this.btn_course.MouseBack = null;
            this.btn_course.Name = "btn_course";
            this.btn_course.NormlBack = null;
            this.btn_course.Size = new System.Drawing.Size(30, 23);
            this.btn_course.TabIndex = 24;
            this.btn_course.Text = "√";
            this.btn_course.UseVisualStyleBackColor = false;
            this.btn_course.Click += new System.EventHandler(this.btn_course_Click);
            // 
            // btn_name
            // 
            this.btn_name.BackColor = System.Drawing.Color.Transparent;
            this.btn_name.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_name.DownBack = null;
            this.btn_name.Location = new System.Drawing.Point(497, 11);
            this.btn_name.MouseBack = null;
            this.btn_name.Name = "btn_name";
            this.btn_name.NormlBack = null;
            this.btn_name.Size = new System.Drawing.Size(30, 23);
            this.btn_name.TabIndex = 23;
            this.btn_name.Text = "√";
            this.btn_name.UseVisualStyleBackColor = false;
            this.btn_name.Click += new System.EventHandler(this.btn_name_Click);
            // 
            // btn_id
            // 
            this.btn_id.BackColor = System.Drawing.Color.Transparent;
            this.btn_id.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_id.DownBack = null;
            this.btn_id.Location = new System.Drawing.Point(232, 12);
            this.btn_id.MouseBack = null;
            this.btn_id.Name = "btn_id";
            this.btn_id.NormlBack = null;
            this.btn_id.Size = new System.Drawing.Size(30, 23);
            this.btn_id.TabIndex = 22;
            this.btn_id.Text = "√";
            this.btn_id.UseVisualStyleBackColor = false;
            this.btn_id.Click += new System.EventHandler(this.btn_id_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.BorderColor = System.Drawing.Color.White;
            this.nameLabel.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameLabel.Location = new System.Drawing.Point(274, 12);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(80, 16);
            this.nameLabel.TabIndex = 21;
            this.nameLabel.Text = "搜索姓名:";
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.BackColor = System.Drawing.Color.Transparent;
            this.courseLabel.BorderColor = System.Drawing.Color.White;
            this.courseLabel.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.courseLabel.Location = new System.Drawing.Point(533, 12);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(80, 16);
            this.courseLabel.TabIndex = 20;
            this.courseLabel.Text = "搜索课程:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.BackColor = System.Drawing.Color.Transparent;
            this.idLabel.BorderColor = System.Drawing.Color.White;
            this.idLabel.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.idLabel.Location = new System.Drawing.Point(9, 13);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(80, 16);
            this.idLabel.TabIndex = 19;
            this.idLabel.Text = "搜索学号:";
            // 
            // highQuery
            // 
            this.highQuery.DisplayMember = "stuId";
            this.highQuery.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.highQuery.FormattingEnabled = true;
            this.highQuery.Items.AddRange(new object[] {
            "",
            "不及格成绩",
            "及格成绩"});
            this.highQuery.Location = new System.Drawing.Point(95, 63);
            this.highQuery.Name = "highQuery";
            this.highQuery.Size = new System.Drawing.Size(131, 22);
            this.highQuery.TabIndex = 34;
            this.highQuery.WaterText = "";
            // 
            // btn_high
            // 
            this.btn_high.BackColor = System.Drawing.Color.Transparent;
            this.btn_high.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_high.DownBack = null;
            this.btn_high.Location = new System.Drawing.Point(232, 64);
            this.btn_high.MouseBack = null;
            this.btn_high.Name = "btn_high";
            this.btn_high.NormlBack = null;
            this.btn_high.Size = new System.Drawing.Size(30, 23);
            this.btn_high.TabIndex = 31;
            this.btn_high.Text = "√";
            this.btn_high.UseVisualStyleBackColor = false;
            this.btn_high.Click += new System.EventHandler(this.btn_high_Click);
            // 
            // highLabel
            // 
            this.highLabel.AutoSize = true;
            this.highLabel.BackColor = System.Drawing.Color.Transparent;
            this.highLabel.BorderColor = System.Drawing.Color.White;
            this.highLabel.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.highLabel.Location = new System.Drawing.Point(9, 65);
            this.highLabel.Name = "highLabel";
            this.highLabel.Size = new System.Drawing.Size(80, 16);
            this.highLabel.TabIndex = 28;
            this.highLabel.Text = "高级搜索:";
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.table.BackgroundColor = System.Drawing.SystemColors.Window;
            this.table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.table.ColumnFont = new System.Drawing.Font("仿宋", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("仿宋", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.table.ColumnHeadersHeight = 30;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.table.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table.DefaultCellStyle = dataGridViewCellStyle3;
            this.table.EnableHeadersVisualStyles = false;
            this.table.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.table.HeadFont = new System.Drawing.Font("仿宋", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.table.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.table.Location = new System.Drawing.Point(0, 91);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.table.RowHeadersWidth = 50;
            this.table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("仿宋", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.table.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.table.RowTemplate.Height = 23;
            this.table.Size = new System.Drawing.Size(808, 352);
            this.table.TabIndex = 35;
            this.table.TitleBack = null;
            this.table.TitleBackColorBegin = System.Drawing.Color.White;
            this.table.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            this.table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellContentClick);
            // 
            // query
            // 
            this.query.AllowUserToAddRows = false;
            this.query.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.query.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.query.BackgroundColor = System.Drawing.SystemColors.Window;
            this.query.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.query.ColumnFont = new System.Drawing.Font("仿宋", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.query.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("仿宋", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.query.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.query.ColumnHeadersHeight = 30;
            this.query.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.query.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.query.DefaultCellStyle = dataGridViewCellStyle7;
            this.query.EnableHeadersVisualStyles = false;
            this.query.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.query.HeadFont = new System.Drawing.Font("仿宋", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.query.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.query.Location = new System.Drawing.Point(1, 94);
            this.query.Name = "query";
            this.query.ReadOnly = true;
            this.query.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.query.RowHeadersWidth = 50;
            this.query.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("仿宋", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.query.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.query.RowTemplate.Height = 23;
            this.query.Size = new System.Drawing.Size(808, 352);
            this.query.TabIndex = 36;
            this.query.TitleBack = null;
            this.query.TitleBackColorBegin = System.Drawing.Color.White;
            this.query.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            this.query.Visible = false;
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Font = new System.Drawing.Font("仿宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton1.Location = new System.Drawing.Point(360, 42);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(131, 46);
            this.skinButton1.TabIndex = 37;
            this.skinButton1.Text = "显示初始表";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // scoreManagementSystemDataSet6
            // 
            this.scoreManagementSystemDataSet6.DataSetName = "ScoreManagementSystemDataSet6";
            this.scoreManagementSystemDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scoreBindingSource1
            // 
            this.scoreBindingSource1.DataMember = "Score";
            this.scoreBindingSource1.DataSource = this.scoreManagementSystemDataSet6;
            // 
            // scoreTableAdapter1
            // 
            this.scoreTableAdapter1.ClearBeforeFill = true;
            // 
            // scoreTableAdapter
            // 
            this.scoreTableAdapter.ClearBeforeFill = true;
            // 
            // scoreManagementSystemDataSet5
            // 
            this.scoreManagementSystemDataSet5.DataSetName = "ScoreManagementSystemDataSet5";
            this.scoreManagementSystemDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scoreBindingSource
            // 
            this.scoreBindingSource.DataMember = "Score";
            this.scoreBindingSource.DataSource = this.scoreManagementSystemDataSet5;
            // 
            // courseQuery
            // 
            this.courseQuery.DataSource = this.scoreBindingSource1;
            this.courseQuery.DisplayMember = "courseName";
            this.courseQuery.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.courseQuery.FormattingEnabled = true;
            this.courseQuery.Location = new System.Drawing.Point(619, 12);
            this.courseQuery.Name = "courseQuery";
            this.courseQuery.Size = new System.Drawing.Size(131, 22);
            this.courseQuery.TabIndex = 27;
            this.courseQuery.WaterText = "";
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.table);
            this.Controls.Add(this.highQuery);
            this.Controls.Add(this.btn_high);
            this.Controls.Add(this.highLabel);
            this.Controls.Add(this.courseQuery);
            this.Controls.Add(this.nameQuery);
            this.Controls.Add(this.idQuery);
            this.Controls.Add(this.btn_course);
            this.Controls.Add(this.btn_name);
            this.Controls.Add(this.btn_id);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.courseLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.query);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Score";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "成绩查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Score_FormClosing);
            this.Load += new System.EventHandler(this.Score_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.query)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreManagementSystemDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreManagementSystemDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinComboBox nameQuery;
        private CCWin.SkinControl.SkinComboBox idQuery;
        private CCWin.SkinControl.SkinButton btn_course;
        private CCWin.SkinControl.SkinButton btn_name;
        private CCWin.SkinControl.SkinButton btn_id;
        private CCWin.SkinControl.SkinLabel nameLabel;
        private CCWin.SkinControl.SkinLabel courseLabel;
        private CCWin.SkinControl.SkinLabel idLabel;
        private CCWin.SkinControl.SkinComboBox highQuery;
        private CCWin.SkinControl.SkinButton btn_high;
        private CCWin.SkinControl.SkinLabel highLabel;
        private CCWin.SkinControl.SkinDataGridView table;
        private CCWin.SkinControl.SkinDataGridView query;
        private CCWin.SkinControl.SkinButton skinButton1;
        private ScoreManagementSystemDataSet6 scoreManagementSystemDataSet6;
        private System.Windows.Forms.BindingSource scoreBindingSource1;
        private ScoreManagementSystemDataSet6TableAdapters.ScoreTableAdapter scoreTableAdapter1;
        private ScoreManagementSystemDataSet5TableAdapters.ScoreTableAdapter scoreTableAdapter;
        private ScoreManagementSystemDataSet5 scoreManagementSystemDataSet5;
        private System.Windows.Forms.BindingSource scoreBindingSource;
        private CCWin.SkinControl.SkinComboBox courseQuery;
    }
}