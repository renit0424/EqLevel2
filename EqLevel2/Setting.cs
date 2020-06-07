using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EQLevel2
{
    public partial class Setting : Form
    {
        public Main Main;
        public Setting()
        {
            InitializeComponent();
        }
        private void Setting_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = Properties.Settings.Default.check;
            checkBox2.Checked = Properties.Settings.Default.check2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.check = checkBox1.Checked;
            Properties.Settings.Default.check2 = checkBox2.Checked;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void Setting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.check = checkBox1.Checked;
            Properties.Settings.Default.check2 = checkBox2.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
