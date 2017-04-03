using System;
using System.Windows.Forms;

namespace Tetris
{
    public partial class help : Form
    {
        public help()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
