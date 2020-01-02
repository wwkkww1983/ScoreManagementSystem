namespace ScoreManagementSystem
{
    partial class Enter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enter));
            this.picture = new CCWin.SkinControl.SkinPictureBox();
            this.id = new CCWin.SkinControl.SkinTextBox();
            this.scoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scoreManagementSystemDataSet4 = new ScoreManagementSystem.ScoreManagementSystemDataSet4();
            this.term = new CCWin.SkinControl.SkinComboBox();
            this.next = new CCWin.SkinControl.SkinButton();
            this.exit = new CCWin.SkinControl.SkinButton();
            this.lockCourse = new CCWin.SkinControl.SkinCheckBox();
            this.lockTerm = new CCWin.SkinControl.SkinCheckBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.score = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.scoreManagementSystemDataSet3 = new ScoreManagementSystem.ScoreManagementSystemDataSet3();
            this.scoreTableAdapter = new ScoreManagementSystem.ScoreManagementSystemDataSet4TableAdapters.ScoreTableAdapter();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.courseId = new CCWin.SkinControl.SkinComboBox();
            this.scoreManagementSystemDataSet2 = new ScoreManagementSystem.ScoreManagementSystemDataSet2();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new ScoreManagementSystem.ScoreManagementSystemDataSet2TableAdapters.CourseTableAdapter();
            this.scoreManagementSystemDataSet7 = new ScoreManagementSystem.ScoreManagementSystemDataSet7();
            this.scoreBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.scoreTableAdapter1 = new ScoreManagementSystem.ScoreManagementSystemDataSet7TableAdapters.ScoreTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreManagementSystemDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreManagementSystemDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreManagementSystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreManagementSystemDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.Transparent;
            this.picture.Image = global::ScoreManagementSystem.Properties.Resources.jinnaluo;
            this.picture.Location = new System.Drawing.Point(285, 286);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(133, 152);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.Transparent;
            this.id.DownBack = null;
            this.id.Icon = null;
            this.id.IconIsButton = false;
            this.id.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.id.IsPasswordChat = '\0';
            this.id.IsSystemPasswordChar = false;
            this.id.Lines = new string[0];
            this.id.Location = new System.Drawing.Point(119, 183);
            this.id.Margin = new System.Windows.Forms.Padding(0);
            this.id.MaxLength = 32767;
            this.id.MinimumSize = new System.Drawing.Size(28, 28);
            this.id.MouseBack = null;
            this.id.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.id.Multiline = false;
            this.id.Name = "id";
            this.id.NormlBack = null;
            this.id.Padding = new System.Windows.Forms.Padding(5);
            this.id.ReadOnly = false;
            this.id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.id.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.id.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.id.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.id.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.id.SkinTxt.Name = "BaseText";
            this.id.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.id.SkinTxt.TabIndex = 0;
            this.id.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.id.SkinTxt.WaterText = "";
            this.id.TabIndex = 1;
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.id.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.id.WaterText = "";
            this.id.WordWrap = true;
            // 
            // scoreBindingSource
            // 
            this.scoreBindingSource.DataMember = "Score";
            this.scoreBindingSource.DataSource = this.scoreManagementSystemDataSet4;
            // 
            // scoreManagementSystemDataSet4
            // 
            this.scoreManagementSystemDataSet4.DataSetName = "ScoreManagementSystemDataSet4";
            this.scoreManagementSystemDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // term
            // 
            this.term.DataSource = this.scoreBindingSource1;
            this.term.DisplayMember = "term";
            this.term.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.term.FormattingEnabled = true;
            this.term.Location = new System.Drawing.Point(119, 120);
            this.term.Name = "term";
            this.term.Size = new System.Drawing.Size(185, 22);
            this.term.TabIndex = 4;
            this.term.WaterText = "";
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.Transparent;
            this.next.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.next.DownBack = null;
            this.next.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.next.Location = new System.Drawing.Point(140, 286);
            this.next.MouseBack = null;
            this.next.Name = "next";
            this.next.NormlBack = null;
            this.next.Size = new System.Drawing.Size(139, 46);
            this.next.TabIndex = 5;
            this.next.Text = "继续录入(Enter)";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit.DownBack = null;
            this.exit.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exit.Location = new System.Drawing.Point(140, 360);
            this.exit.MouseBack = null;
            this.exit.Name = "exit";
            this.exit.NormlBack = null;
            this.exit.Size = new System.Drawing.Size(139, 46);
            this.exit.TabIndex = 6;
            this.exit.Text = "完成录入(Esc)";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // lockCourse
            // 
            this.lockCourse.AutoSize = true;
            this.lockCourse.BackColor = System.Drawing.Color.Transparent;
            this.lockCourse.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.lockCourse.DownBack = null;
            this.lockCourse.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lockCourse.Location = new System.Drawing.Point(119, 85);
            this.lockCourse.MouseBack = null;
            this.lockCourse.Name = "lockCourse";
            this.lockCourse.NormlBack = null;
            this.lockCourse.SelectedDownBack = null;
            this.lockCourse.SelectedMouseBack = null;
            this.lockCourse.SelectedNormlBack = null;
            this.lockCourse.Size = new System.Drawing.Size(75, 21);
            this.lockCourse.TabIndex = 7;
            this.lockCourse.Text = "锁定课程";
            this.lockCourse.UseVisualStyleBackColor = false;
            this.lockCourse.CheckedChanged += new System.EventHandler(this.skinCheckBox1_CheckedChanged);
            // 
            // lockTerm
            // 
            this.lockTerm.AutoSize = true;
            this.lockTerm.BackColor = System.Drawing.Color.Transparent;
            this.lockTerm.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.lockTerm.DownBack = null;
            this.lockTerm.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lockTerm.Location = new System.Drawing.Point(119, 148);
            this.lockTerm.MouseBack = null;
            this.lockTerm.Name = "lockTerm";
            this.lockTerm.NormlBack = null;
            this.lockTerm.SelectedDownBack = null;
            this.lockTerm.SelectedMouseBack = null;
            this.lockTerm.SelectedNormlBack = null;
            this.lockTerm.Size = new System.Drawing.Size(75, 21);
            this.lockTerm.TabIndex = 8;
            this.lockTerm.Text = "锁定学期";
            this.lockTerm.UseVisualStyleBackColor = false;
            this.lockTerm.CheckedChanged += new System.EventHandler(this.lockTerm_CheckedChanged);
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(71, 123);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(35, 19);
            this.skinLabel2.TabIndex = 10;
            this.skinLabel2.Text = "学期";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(71, 192);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(35, 19);
            this.skinLabel4.TabIndex = 12;
            this.skinLabel4.Text = "学号";
            // 
            // score
            // 
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.DownBack = null;
            this.score.Icon = null;
            this.score.IconIsButton = false;
            this.score.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.score.IsPasswordChat = '\0';
            this.score.IsSystemPasswordChar = false;
            this.score.Lines = new string[0];
            this.score.Location = new System.Drawing.Point(119, 236);
            this.score.Margin = new System.Windows.Forms.Padding(0);
            this.score.MaxLength = 32767;
            this.score.MinimumSize = new System.Drawing.Size(28, 28);
            this.score.MouseBack = null;
            this.score.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.score.Multiline = false;
            this.score.Name = "score";
            this.score.NormlBack = null;
            this.score.Padding = new System.Windows.Forms.Padding(5);
            this.score.ReadOnly = false;
            this.score.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.score.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.score.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.score.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.score.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.score.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.score.SkinTxt.Name = "BaseText";
            this.score.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.score.SkinTxt.TabIndex = 0;
            this.score.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.score.SkinTxt.WaterText = "";
            this.score.TabIndex = 13;
            this.score.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.score.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.score.WaterText = "";
            this.score.WordWrap = true;
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(71, 245);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(35, 19);
            this.skinLabel5.TabIndex = 14;
            this.skinLabel5.Text = "成绩";
            // 
            // scoreManagementSystemDataSet3
            // 
            this.scoreManagementSystemDataSet3.DataSetName = "ScoreManagementSystemDataSet3";
            this.scoreManagementSystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scoreTableAdapter
            // 
            this.scoreTableAdapter.ClearBeforeFill = true;
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(58, 56);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(48, 19);
            this.skinLabel6.TabIndex = 16;
            this.skinLabel6.Text = "课程号";
            // 
            // courseId
            // 
            this.courseId.DataSource = this.courseBindingSource;
            this.courseId.DisplayMember = "courseId";
            this.courseId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.courseId.FormattingEnabled = true;
            this.courseId.Location = new System.Drawing.Point(119, 53);
            this.courseId.Name = "courseId";
            this.courseId.Size = new System.Drawing.Size(185, 22);
            this.courseId.TabIndex = 15;
            this.courseId.WaterText = "";
            this.courseId.TextUpdate += new System.EventHandler(this.courseId_TextUpdate);
            // 
            // scoreManagementSystemDataSet2
            // 
            this.scoreManagementSystemDataSet2.DataSetName = "ScoreManagementSystemDataSet2";
            this.scoreManagementSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.scoreManagementSystemDataSet2;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // scoreManagementSystemDataSet7
            // 
            this.scoreManagementSystemDataSet7.DataSetName = "ScoreManagementSystemDataSet7";
            this.scoreManagementSystemDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scoreBindingSource1
            // 
            this.scoreBindingSource1.DataMember = "Score";
            this.scoreBindingSource1.DataSource = this.scoreManagementSystemDataSet7;
            // 
            // scoreTableAdapter1
            // 
            this.scoreTableAdapter1.ClearBeforeFill = true;
            // 
            // Enter
            // 
            this.AcceptButton = this.next;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.exit;
            this.ClientSize = new System.Drawing.Size(420, 444);
            this.Controls.Add(this.skinLabel6);
            this.Controls.Add(this.courseId);
            this.Controls.Add(this.skinLabel5);
            this.Controls.Add(this.score);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.lockTerm);
            this.Controls.Add(this.lockCourse);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.next);
            this.Controls.Add(this.term);
            this.Controls.Add(this.id);
            this.Controls.Add(this.picture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Enter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "录入成绩";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Enter_FormClosed);
            this.Load += new System.EventHandler(this.Enter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreManagementSystemDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreManagementSystemDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreManagementSystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreManagementSystemDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinPictureBox picture;
        private CCWin.SkinControl.SkinTextBox id;
        private CCWin.SkinControl.SkinComboBox term;
        private CCWin.SkinControl.SkinButton next;
        private CCWin.SkinControl.SkinButton exit;
        private CCWin.SkinControl.SkinCheckBox lockCourse;
        private CCWin.SkinControl.SkinCheckBox lockTerm;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinTextBox score;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private ScoreManagementSystemDataSet3 scoreManagementSystemDataSet3;
        private ScoreManagementSystemDataSet4 scoreManagementSystemDataSet4;
        private System.Windows.Forms.BindingSource scoreBindingSource;
        private ScoreManagementSystemDataSet4TableAdapters.ScoreTableAdapter scoreTableAdapter;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinComboBox courseId;
        private ScoreManagementSystemDataSet2 scoreManagementSystemDataSet2;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private ScoreManagementSystemDataSet2TableAdapters.CourseTableAdapter courseTableAdapter;
        private ScoreManagementSystemDataSet7 scoreManagementSystemDataSet7;
        private System.Windows.Forms.BindingSource scoreBindingSource1;
        private ScoreManagementSystemDataSet7TableAdapters.ScoreTableAdapter scoreTableAdapter1;
    }
}