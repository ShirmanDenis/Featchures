using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;

namespace FormattingOptionsDemo
{
    public partial class MainQueryTab : UserControl
    {
        private SQLFormattingOptions _formattingOptions;

        public MainQueryTab(SQLFormattingOptions formattingOptions)
        {
            _formattingOptions = formattingOptions;

            InitializeComponent();
        }

        private void chBxEnableWordWrap_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
