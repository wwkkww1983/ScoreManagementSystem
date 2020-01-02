using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreManagementSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Enter enter = new Enter(this);
            enter.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void query_Click(object sender, EventArgs e)
        {
            Management management = new Management(this);
            this.Enabled = false;
            management.Show();
        }
    }
}
