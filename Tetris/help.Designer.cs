namespace Tetris
{
    partial class Help
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
            this.lbl_operation = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_operation
            // 
            this.lbl_operation.AutoSize = true;
            this.lbl_operation.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_operation.Location = new System.Drawing.Point(3, 7);
            this.lbl_operation.Name = "lbl_operation";
            this.lbl_operation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_operation.Size = new System.Drawing.Size(204, 133);
            this.lbl_operation.TabIndex = 0;
            this.lbl_operation.Text = "操作键：\r\n     “回车”：开始游戏；\r\n     “空格”：暂停游戏；\r\n     “←”：向左移动方块；\r\n     “→”：向右移动方块；\r\n     " +
    "“↓”：向下加速移动方块；\r\n     “↑”：旋转方块。";
            this.lbl_operation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.CancelBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CancelBtn.Location = new System.Drawing.Point(68, 148);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 25);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "关 闭";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(210, 180);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.lbl_operation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Help";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "操作说明";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_operation;
        private System.Windows.Forms.Button CancelBtn;
    }
}