namespace Tetris
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pic_preView = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.t_score = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.游戏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暂停ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.结束ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.背景颜色设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.方块颜色设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.方块速度设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.较慢ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.慢ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.快ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.较快ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.非常快ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.恢复默认设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.msg = new System.Windows.Forms.Label();
            this.picBackGround = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_preView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackGround)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_preView
            // 
            this.pic_preView.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            resources.ApplyResources(this.pic_preView, "pic_preView");
            this.pic_preView.Cursor = System.Windows.Forms.Cursors.Default;
            this.pic_preView.Name = "pic_preView";
            this.pic_preView.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // t_score
            // 
            resources.ApplyResources(this.t_score, "t_score");
            this.t_score.Cursor = System.Windows.Forms.Cursors.Default;
            this.t_score.ForeColor = System.Drawing.Color.SeaGreen;
            this.t_score.Name = "t_score";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.游戏ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // 游戏ToolStripMenuItem
            // 
            this.游戏ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始ToolStripMenuItem,
            this.暂停ToolStripMenuItem1,
            this.结束ToolStripMenuItem,
            this.重新开始ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.退出ToolStripMenuItem});
            this.游戏ToolStripMenuItem.Name = "游戏ToolStripMenuItem";
            resources.ApplyResources(this.游戏ToolStripMenuItem, "游戏ToolStripMenuItem");
            // 
            // 开始ToolStripMenuItem
            // 
            this.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem";
            resources.ApplyResources(this.开始ToolStripMenuItem, "开始ToolStripMenuItem");
            this.开始ToolStripMenuItem.Click += new System.EventHandler(this.开始ToolStripMenuItem1_Click);
            // 
            // 暂停ToolStripMenuItem1
            // 
            resources.ApplyResources(this.暂停ToolStripMenuItem1, "暂停ToolStripMenuItem1");
            this.暂停ToolStripMenuItem1.Name = "暂停ToolStripMenuItem1";
            this.暂停ToolStripMenuItem1.Click += new System.EventHandler(this.暂停ToolStripMenuItem1_Click);
            // 
            // 结束ToolStripMenuItem
            // 
            resources.ApplyResources(this.结束ToolStripMenuItem, "结束ToolStripMenuItem");
            this.结束ToolStripMenuItem.Name = "结束ToolStripMenuItem";
            this.结束ToolStripMenuItem.Click += new System.EventHandler(this.结束ToolStripMenuItem_Click);
            // 
            // 重新开始ToolStripMenuItem
            // 
            this.重新开始ToolStripMenuItem.Name = "重新开始ToolStripMenuItem";
            resources.ApplyResources(this.重新开始ToolStripMenuItem, "重新开始ToolStripMenuItem");
            this.重新开始ToolStripMenuItem.Click += new System.EventHandler(this.重新开始ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            resources.ApplyResources(this.退出ToolStripMenuItem, "退出ToolStripMenuItem");
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.背景颜色设置ToolStripMenuItem,
            this.方块颜色设置ToolStripMenuItem,
            this.方块速度设置ToolStripMenuItem,
            this.恢复默认设置ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            resources.ApplyResources(this.设置ToolStripMenuItem, "设置ToolStripMenuItem");
            // 
            // 背景颜色设置ToolStripMenuItem
            // 
            this.背景颜色设置ToolStripMenuItem.Name = "背景颜色设置ToolStripMenuItem";
            resources.ApplyResources(this.背景颜色设置ToolStripMenuItem, "背景颜色设置ToolStripMenuItem");
            this.背景颜色设置ToolStripMenuItem.Click += new System.EventHandler(this.背景颜色设置ToolStripMenuItem_Click);
            // 
            // 方块颜色设置ToolStripMenuItem
            // 
            this.方块颜色设置ToolStripMenuItem.Name = "方块颜色设置ToolStripMenuItem";
            resources.ApplyResources(this.方块颜色设置ToolStripMenuItem, "方块颜色设置ToolStripMenuItem");
            this.方块颜色设置ToolStripMenuItem.Click += new System.EventHandler(this.方块颜色设置ToolStripMenuItem_Click);
            // 
            // 方块速度设置ToolStripMenuItem
            // 
            this.方块速度设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.较慢ToolStripMenuItem,
            this.慢ToolStripMenuItem,
            this.快ToolStripMenuItem,
            this.较快ToolStripMenuItem,
            this.非常快ToolStripMenuItem});
            this.方块速度设置ToolStripMenuItem.Name = "方块速度设置ToolStripMenuItem";
            resources.ApplyResources(this.方块速度设置ToolStripMenuItem, "方块速度设置ToolStripMenuItem");
            // 
            // 较慢ToolStripMenuItem
            // 
            this.较慢ToolStripMenuItem.Checked = true;
            this.较慢ToolStripMenuItem.CheckOnClick = true;
            this.较慢ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.较慢ToolStripMenuItem.Name = "较慢ToolStripMenuItem";
            resources.ApplyResources(this.较慢ToolStripMenuItem, "较慢ToolStripMenuItem");
            this.较慢ToolStripMenuItem.Click += new System.EventHandler(this.较慢ToolStripMenuItem_Click);
            // 
            // 慢ToolStripMenuItem
            // 
            this.慢ToolStripMenuItem.CheckOnClick = true;
            this.慢ToolStripMenuItem.Name = "慢ToolStripMenuItem";
            resources.ApplyResources(this.慢ToolStripMenuItem, "慢ToolStripMenuItem");
            this.慢ToolStripMenuItem.Click += new System.EventHandler(this.慢ToolStripMenuItem_Click);
            // 
            // 快ToolStripMenuItem
            // 
            this.快ToolStripMenuItem.CheckOnClick = true;
            this.快ToolStripMenuItem.Name = "快ToolStripMenuItem";
            resources.ApplyResources(this.快ToolStripMenuItem, "快ToolStripMenuItem");
            this.快ToolStripMenuItem.Click += new System.EventHandler(this.快ToolStripMenuItem_Click);
            // 
            // 较快ToolStripMenuItem
            // 
            this.较快ToolStripMenuItem.CheckOnClick = true;
            this.较快ToolStripMenuItem.Name = "较快ToolStripMenuItem";
            resources.ApplyResources(this.较快ToolStripMenuItem, "较快ToolStripMenuItem");
            this.较快ToolStripMenuItem.Click += new System.EventHandler(this.较快ToolStripMenuItem_Click);
            // 
            // 非常快ToolStripMenuItem
            // 
            this.非常快ToolStripMenuItem.CheckOnClick = true;
            this.非常快ToolStripMenuItem.Name = "非常快ToolStripMenuItem";
            resources.ApplyResources(this.非常快ToolStripMenuItem, "非常快ToolStripMenuItem");
            this.非常快ToolStripMenuItem.Click += new System.EventHandler(this.非常快ToolStripMenuItem_Click);
            // 
            // 恢复默认设置ToolStripMenuItem
            // 
            this.恢复默认设置ToolStripMenuItem.Name = "恢复默认设置ToolStripMenuItem";
            resources.ApplyResources(this.恢复默认设置ToolStripMenuItem, "恢复默认设置ToolStripMenuItem");
            this.恢复默认设置ToolStripMenuItem.Click += new System.EventHandler(this.恢复默认设置ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.操作说明ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            resources.ApplyResources(this.帮助ToolStripMenuItem, "帮助ToolStripMenuItem");
            // 
            // 操作说明ToolStripMenuItem
            // 
            this.操作说明ToolStripMenuItem.Name = "操作说明ToolStripMenuItem";
            resources.ApplyResources(this.操作说明ToolStripMenuItem, "操作说明ToolStripMenuItem");
            this.操作说明ToolStripMenuItem.Click += new System.EventHandler(this.操作说明ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            resources.ApplyResources(this.关于ToolStripMenuItem, "关于ToolStripMenuItem");
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // msg
            // 
            resources.ApplyResources(this.msg, "msg");
            this.msg.BackColor = System.Drawing.Color.White;
            this.msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.msg.Name = "msg";
            // 
            // picBackGround
            // 
            this.picBackGround.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picBackGround.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.picBackGround, "picBackGround");
            this.picBackGround.Name = "picBackGround";
            this.picBackGround.TabStop = false;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picBackGround);
            this.Controls.Add(this.t_score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_preView);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.msg);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0.9D;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pic_preView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_preView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 方块速度设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 背景颜色设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 游戏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 暂停ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 结束ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label msg;
        private System.Windows.Forms.ToolStripMenuItem 方块颜色设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 较慢ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 慢ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 快ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 较快ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 非常快ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 恢复默认设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新开始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Label t_score;
        private System.Windows.Forms.ToolStripMenuItem 操作说明ToolStripMenuItem;
        private System.Windows.Forms.PictureBox picBackGround;
    }
}