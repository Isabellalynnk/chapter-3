using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloVisualWorld
{
    public partial class hellolabel : Form
    {
        public hellolabel()
        {
            InitializeComponent();
        }

        private void btn_results_Click(object sender, EventArgs e)
        {
            HelloVisualWorld.Text = "Goodbye";
        }
        private void btn_goodBye_Click(object sender, EventArgs e)
        {
            HelloVisualWorld.Visible = false;
        }

    }
}
