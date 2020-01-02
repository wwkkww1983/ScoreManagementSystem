namespace ScoreManagementSystem
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.background = new CCWin.SkinControl.SkinPictureBox();
            this.greeting = new CCWin.SkinControl.SkinLabel();
            this.enter = new CCWin.SkinControl.SkinButton();
            this.query = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Transparent;
            this.background.Image = global::ScoreManagementSystem.Properties.Resources.lufei;
            this.background.Location = new System.Drawing.Point(-1, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(715, 439);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            // 
            // greeting
            // 
            this.greeting.AutoSize = true;
            this.greeting.BackColor = System.Drawing.Color.Transparent;
            this.greeting.BorderColor = System.Drawing.Color.White;
            this.greeting.Font = new System.Drawing.Font("华文琥珀", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.greeting.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.greeting.Location = new System.Drawing.Point(12, 9);
            this.greeting.Name = "greeting";
            this.greeting.Size = new System.Drawing.Size(187, 30);
            this.greeting.TabIndex = 1;
            this.greeting.Text = "成绩管理系统";
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.Transparent;
            this.enter.BaseColor = System.Drawing.Color.Silver;
            this.enter.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.enter.DownBack = null;
            this.enter.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.enter.Location = new System.Drawing.Point(194, 154);
            this.enter.MouseBack = null;
            this.enter.Name = "enter";
            this.enter.NormlBack = null;
            this.enter.Size = new System.Drawing.Size(90, 35);
            this.enter.TabIndex = 2;
            this.enter.Text = "快速录入";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // query
            // 
            this.query.BackColor = System.Drawing.Color.Transparent;
            this.query.BaseColor = System.Drawing.Color.Silver;
            this.query.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.query.DownBack = null;
            this.query.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.query.Location = new System.Drawing.Point(401, 154);
            this.query.MouseBack = null;
            this.query.Name = "query";
            this.query.NormlBack = null;
            this.query.Size = new System.Drawing.Size(90, 35);
            this.query.TabIndex = 3;
            this.query.Text = "信息管理";
            this.query.UseVisualStyleBackColor = false;
            this.query.Click += new System.EventHandler(this.query_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(715, 439);
            this.Controls.Add(this.query);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.greeting);
            this.Controls.Add(this.background);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dao_成绩管理系统";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinPictureBox background;
        private CCWin.SkinControl.SkinLabel greeting;
        private CCWin.SkinControl.SkinButton enter;
        private CCWin.SkinControl.SkinButton query;
    }
}

