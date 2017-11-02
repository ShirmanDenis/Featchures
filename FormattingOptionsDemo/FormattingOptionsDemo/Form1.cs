using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormattingOptionsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var mainQueryCommon = new MainQueryCommon();
            mainQueryCommon.Dock = DockStyle.Fill;;
            currentTabPanel.Controls.Add(mainQueryCommon);
            //currentTabPanel.ResumeLayout(false);
        }
    }
}
