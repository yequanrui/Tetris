using System;
using System.Windows.Forms;

namespace Tetris
{
    public partial class SetGameFieldBgColor : Form
    {
        public SetGameFieldBgColor()
        {
            InitializeComponent();
        }

        private void setGameFieldBgColor_Load(object sender, EventArgs e)
        {
            pic_bgColor.BackColor = GameField.BackColor;
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            GameField.BackColor = pic_bgColor.BackColor;
            GameField.isChanged = true;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pic_bgColor.BackColor = colorDialog1.Color;
            }
        }
    }
}