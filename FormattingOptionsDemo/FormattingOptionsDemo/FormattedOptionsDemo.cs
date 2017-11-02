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
    public partial class FormattedOptionsDemo : Form
    {
        private UserControl _currentOptionsControl;

        public FormattedOptionsDemo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // MainQuery options
            treeView.Nodes[0].Tag = new MainQueryTab();
            treeView.Nodes[0].Nodes[0].Tag = new CommonTab();
            treeView.Nodes[0].Nodes[1].Tag = new ExpressionsTab();
            // SubQuery in expression options
            treeView.Nodes[1].Tag = new SubQueryTab();
            treeView.Nodes[1].Nodes[0].Tag = new CommonTab();
            treeView.Nodes[1].Nodes[1].Tag = new ExpressionsTab();
            // Derived tables options
            treeView.Nodes[2].Tag = new SubQueryTab();
            treeView.Nodes[2].Nodes[0].Tag = new CommonTab();
            treeView.Nodes[2].Nodes[1].Tag = new ExpressionsTab();
            // Common table expression options
            treeView.Nodes[3].Tag = new SubQueryTab();
            treeView.Nodes[3].Nodes[0].Tag = new CommonTab();
            treeView.Nodes[3].Nodes[1].Tag = new ExpressionsTab();
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            SetCurrentOptionsControl((UserControl)e.Node.Tag);
        }

        private void SetCurrentOptionsControl(UserControl control)
        {
            _currentOptionsControl = control;

            currentTabPanel.Controls.Clear();

            currentTabPanel.Controls.Add(_currentOptionsControl);
            _currentOptionsControl.Dock = DockStyle.Fill;
            Invalidate();
        }
    }
}
