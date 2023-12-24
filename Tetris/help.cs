using System;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
