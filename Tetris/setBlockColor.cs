﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tetris
{
    public partial class setBlockColor : Form
    {
        public setBlockColor()
        {
            InitializeComponent();
        }
        private Block someBlock;
        private int currentBlock = 0;   //0代表没选择，1，2，3……代表选择的图形框号
        private Color gameFieldBgC = GameField.BackColor;
        private void setBlockColor_Load(object sender, EventArgs e)
        {
            this.Refresh();
        }
        private void setBlockColor_Paint(object sender, PaintEventArgs e)
        {
            initalit();
        }
        public void initalit()
        {
            pic_square.BackColor = gameFieldBgC;
            pic_line.BackColor = gameFieldBgC;
            pic_J.BackColor = gameFieldBgC;
            pic_L.BackColor = gameFieldBgC;
            pic_T.BackColor = gameFieldBgC;
            ipc_Z.BackColor = gameFieldBgC;
            pic_S.BackColor = gameFieldBgC;
            Application.DoEvents();
            //图片框1号：方块
            someBlock = new Block(new Point(35, 27), Block.BlockTypes.square);
            someBlock.Draw(pic_square.Handle);
            //图片框2号：直线
            someBlock = new Block(new Point(20, 35), Block.BlockTypes.line);
            someBlock.Draw(pic_line.Handle);
            //图片框3号：J
            someBlock = new Block(new Point(42, 20), Block.BlockTypes.J);
            someBlock.Draw(pic_J.Handle);
            //图片框4号：L
            someBlock = new Block(new Point(42, 20), Block.BlockTypes.L);
            someBlock.Draw(pic_L.Handle);
            //图片框5号：T
            someBlock = new Block(new Point(27, 27), Block.BlockTypes.T);
            someBlock.Draw(pic_T.Handle);
            //图片框6号：Z
            someBlock = new Block(new Point(27, 27), Block.BlockTypes.Z);
            someBlock.Draw(ipc_Z.Handle);
            //图片框7号：S
            someBlock = new Block(new Point(27, 27), Block.BlockTypes.S);
            someBlock.Draw(pic_S.Handle);
            Application.DoEvents();
        }
        /*单击某个图片框*/
        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox send = (PictureBox)sender;
            currentBlock = int.Parse(send.Name.Substring(send.Name.Length - 1, 1));
            pic_preView.Refresh();
            pic_preView.BackColor = gameFieldBgC;
            Application.DoEvents();
            someBlock = new Block(new Point(45, 40), (Block.BlockTypes)currentBlock);
            someBlock.Draw(pic_preView.Handle);
            pic_fgColor.BackColor = GameField.BlockForeColor[currentBlock - 1];
            pic_bgColor.BackColor = GameField.BlockBackColor[currentBlock - 1];
        }
        /*选择前景色*/
        private void p_foreColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pic_fgColor.BackColor = colorDialog1.Color;
            }
            pic_preView.Refresh();
            someBlock = new Block(new Point(45, 40), (Block.BlockTypes)currentBlock, pic_fgColor.BackColor, pic_bgColor.BackColor);
            someBlock.Draw(pic_preView.Handle);
        }
        /*选择背景色*/
        private void p_backColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pic_bgColor.BackColor = colorDialog1.Color;
            }
            pic_preView.Refresh();
            someBlock = new Block(new Point(45, 40), (Block.BlockTypes)currentBlock, pic_fgColor.BackColor, pic_bgColor.BackColor);
            someBlock.Draw(pic_preView.Handle);
        }
        /*保存*/
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (currentBlock != 0)
            {
                GameField.BlockForeColor[currentBlock - 1] = pic_fgColor.BackColor;
                GameField.BlockBackColor[currentBlock - 1] = pic_bgColor.BackColor;
                //重画预览框的图片
                someBlock = new Block(new Point(45, 40), (Block.BlockTypes)currentBlock);
                someBlock.Draw(pic_preView.Handle);
                //游戏设置改变
                GameField.isChanged = true;
            }
        }
        /*关闭*/
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}