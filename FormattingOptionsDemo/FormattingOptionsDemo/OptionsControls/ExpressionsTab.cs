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
    public partial class ExpressionsTab : UserControl
    {
        private SQLBuilderSelectFormat _options;

        public ExpressionsTab(SQLBuilderSelectFormat options)
        {
            InitializeComponent();
            _options = options;
        }

        private void chBxUpperLvlLogicExprFromNewLines_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chBxStartAllLogicExprFromNewLines_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radButStartLines_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radButEndLines_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UpDownIndentForNestedConditions_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chBxBranchConditionKeyWrdsFromNewLinesWhen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chBxBranchConditionExprFromNewLines_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chBxResultKwrdsFromNewLinesThen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chBxBranchResultExprsFromNewLines_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UpDownBranchKeyWrdsIndent_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UpDownExprsIndent_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
