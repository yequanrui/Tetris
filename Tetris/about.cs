using System;
using System.Windows.Forms;

namespace Tetris
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
