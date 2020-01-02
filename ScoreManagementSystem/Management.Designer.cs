namespace ScoreManagementSystem
{
    partial class Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Management));
            this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            this.database = new CCWin.SkinControl.SkinButton();
            this.query = new CCWin.SkinControl.SkinButton();
            this.help = new CCWin.SkinControl.SkinButton();
            this.exit = new CCWin.SkinControl.SkinButton();
            this.label = new CCWin.SkinControl.SkinLabel();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // skinPictureBox1
            // 
            this.skinPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox1.Image = global::ScoreManagementSystem.Properties.Resources.mingge;
            this.skinPictureBox1.Location = new System.Drawing.Point(0, 1);
            this.skinPictureBox1.Name = "skinPictureBox1";
            this.skinPictureBox1.Size = new System.Drawing.Size(582, 362);
            this.skinPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.skinPictureBox1.TabIndex = 0;
            this.skinPictureBox1.TabStop = false;
            this.skinPictureBox1.Click += new System.EventHandler(this.skinPictureBox1_Click);
            // 
            // database
            // 
            this.database.BackColor = System.Drawing.Color.Transparent;
            this.database.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.database.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.database.DownBack = null;
            this.database.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.database.Location = new System.Drawing.Point(283, 241);
            this.database.MouseBack = null;
            this.database.Name = "database";
            this.database.NormlBack = null;
            this.database.Size = new System.Drawing.Size(98, 42);
            this.database.TabIndex = 1;
            this.database.Text = "数据库管理";
            this.database.UseVisualStyleBackColor = false;
            this.database.Click += new System.EventHandler(this.database_Click);
            // 
            // query
            // 
            this.query.BackColor = System.Drawing.Color.Transparent;
            this.query.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.query.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.query.DownBack = null;
            this.query.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.query.Location = new System.Drawing.Point(215, 321);
            this.query.MouseBack = null;
            this.query.Name = "query";
            this.query.NormlBack = null;
            this.query.Size = new System.Drawing.Size(113, 42);
            this.query.TabIndex = 2;
            this.query.Text = "学生成绩查询";
            this.query.UseVisualStyleBackColor = false;
            this.query.Click += new System.EventHandler(this.query_Click);
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.Transparent;
            this.help.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.help.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.help.DownBack = null;
            this.help.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.help.Location = new System.Drawing.Point(364, 304);
            this.help.MouseBack = null;
            this.help.Name = "help";
            this.help.NormlBack = null;
            this.help.Size = new System.Drawing.Size(98, 42);
            this.help.TabIndex = 3;
            this.help.Text = "帮助";
            this.help.UseVisualStyleBackColor = false;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.exit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.exit.DownBack = null;
            this.exit.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exit.Location = new System.Drawing.Point(468, 293);
            this.exit.MouseBack = null;
            this.exit.Name = "exit";
            this.exit.NormlBack = null;
            this.exit.Size = new System.Drawing.Size(98, 42);
            this.exit.TabIndex = 4;
            this.exit.Text = "返回";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.White;
            this.label.BorderColor = System.Drawing.Color.White;
            this.label.Font = new System.Drawing.Font("华文彩云", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label.Location = new System.Drawing.Point(12, 19);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(147, 33);
            this.label.TabIndex = 5;
            this.label.Text = "信息管理";
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(583, 358);
            this.Controls.Add(this.label);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.help);
            this.Controls.Add(this.query);
            this.Controls.Add(this.database);
            this.Controls.Add(this.skinPictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "信息管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Management_FormClosing);
            this.Load += new System.EventHandler(this.Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
        private CCWin.SkinControl.SkinButton database;
        private CCWin.SkinControl.SkinButton query;
        private CCWin.SkinControl.SkinButton help;
        private CCWin.SkinControl.SkinButton exit;
        private CCWin.SkinControl.SkinLabel label;
    }
}