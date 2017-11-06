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
    public partial class CommonTab : UserControl
    {
        private SQLFormattingOptions _sqlFormattingOptions;

        public CommonTab(SQLFormattingOptions sqlFormattingOptions)
        {
            InitializeComponent();

            _sqlFormattingOptions = sqlFormattingOptions;
        }
    }
}
