namespace Tetris
{
    partial class SetGameFieldBgColor
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
            this.lbl_bgColor = new System.Windows.Forms.Label();
            this.btn_change = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pic_bgColor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_bgColor)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_bgColor
            // 
            this.lbl_bgColor.AutoSize = true;
            this.lbl_bgColor.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_bgColor.Location = new System.Drawing.Point(8, 7);
            this.lbl_bgColor.Name = "lbl_bgColor";
            this.lbl_bgColor.Size = new System.Drawing.Size(92, 17);
            this.lbl_bgColor.TabIndex = 0;
            this.lbl_bgColor.Text = "场景背景颜色：";
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(100, 18);
            this.btn_change.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(60, 30);
            this.btn_change.TabIndex = 1;
            this.btn_change.Text = "修 改";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // pic_bgColor
            // 
            this.pic_bgColor.BackColor = System.Drawing.Color.Black;
            this.pic_bgColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_bgColor.Location = new System.Drawing.Point(11, 28);
            this.pic_bgColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pic_bgColor.Name = "pic_bgColor";
            this.pic_bgColor.Size = new System.Drawing.Size(80, 30);
            this.pic_bgColor.TabIndex = 3;
            this.pic_bgColor.TabStop = false;
            this.pic_bgColor.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // setGameFieldBgColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(168, 64);
            this.Controls.Add(this.pic_bgColor);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.lbl_bgColor);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "setGameFieldBgColor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "背景颜色设置";
            this.Load += new System.EventHandler(this.setGameFieldBgColor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_bgColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_bgColor;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pic_bgColor;
    }
}