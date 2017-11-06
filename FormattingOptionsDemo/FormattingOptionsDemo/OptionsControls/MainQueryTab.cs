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
        private readonly FormattedSQLBuilder _builder;
        private readonly SQLFormattingOptions _options;

        public MainQueryTab(FormattedSQLBuilder builder)
        {
            _builder = builder;
            _options = (SQLFormattingOptions)builder.Options;
            InitializeComponent();
        }

        private void chBxEnableWordWrap_CheckedChanged(object sender, EventArgs e)
        {
            // ?????
        }

        private void chBxEnableDynamicIndents_CheckedChanged(object sender, EventArgs e)
        {
            _builder.DynamicIndents = chBxEnableDynamicIndents.Checked;
        }

        private void chBxEnableDynamicRightMargin_CheckedChanged(object sender, EventArgs e)
        {
            _builder.DynamicRightMargin = chBxEnableDynamicRightMargin.Checked;
        }

        private void chBxParenthesizeConditionsWithinAndOperators_CheckedChanged(object sender, EventArgs e)
        {
            _options.ParenthesizeANDGroups = chBxParenthesizeConditionsWithinAndOperators.Checked;
        }

        private void chBxParenthesizeEachSingleCondition_CheckedChanged(object sender, EventArgs e)
        {
            _options.ParenthesizeSingleCriterion = chBxParenthesizeEachSingleCondition.Checked;
        }

        private void upDownMaxCharsInLine_ValueChanged(object sender, EventArgs e)
        {
            _options.RightMargin = (int)upDownMaxCharsInLine.Value;
        }

        private void cmbBoxKeyWordsCase_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbBoxKeyWordsCase.SelectedText)
            {
                case "First Upper":
                    _options.KeywordFormat = KeywordFormat.FirstUpper;
                    break;
                case "UpperCase":
                    _options.KeywordFormat = KeywordFormat.UpperCase;
                    break;
                case "LowerCase":
                    _options.KeywordFormat = KeywordFormat.LowerCase;
                    break;
            }
        }
    }
}
