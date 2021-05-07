using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reboot_Prompt
{
    public partial class RebootPrompt : Form
    {
        public RebootPrompt()
        {
            InitializeComponent();
        }

        private void LaterBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RebootBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown.exe", "-r -t 0");
        }
    }
}
