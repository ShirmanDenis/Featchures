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
        private SQLBuilderSelectFormat _selectFormat;
        private FormattedSQLBuilder _builder;
        private SQLFormattingOptions _formattingOptions;

        public CommonTab(FormattedSQLBuilder builder, SQLBuilderSelectFormat selectFormat)
        {
            InitializeComponent();
            _builder = builder;
            _formattingOptions = (SQLFormattingOptions) _builder.Options;
            _selectFormat = selectFormat;
        }

        private void chBxStartPartsFromNewLines_CheckedChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(_formattingOptions))
                _selectFormat.MainPartsFromNewLine = chBxStartPartsFromNewLines.Checked;
        }

        private void chBxInsertNewLineAfterPartKeywords_CheckedChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(_formattingOptions))
                _selectFormat.NewLineAfterPartKeywords = chBxInsertNewLineAfterPartKeywords.Checked;
        }

        private void upDownPartIndent_ValueChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(_formattingOptions))
                _selectFormat.IndentInPart = (int)upDownPartIndent.Value;
        }

        private void chBxStartSelectListItemsOnNewLines_CheckedChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(_formattingOptions))
                _selectFormat.SelectListFormat.NewLineAfterItem = chBxStartSelectListItemsOnNewLines.Checked;
        }

        private void radButNewLineBeforeComma_CheckedChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(_formattingOptions))
            {
                _selectFormat.SelectListFormat.NewLineBeforeComma = radButNewLineBeforeComma.Checked;
                _selectFormat.OrderByFormat.NewLineBeforeComma = radButNewLineBeforeComma.Checked;
                _selectFormat.GroupByFormat.NewLineBeforeComma = radButNewLineBeforeComma.Checked;
                _selectFormat.FromClauseFormat.NewLineBeforeComma = radButNewLineBeforeComma.Checked;
            }
        }

        private void radButNewLineAfterComma_CheckedChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(_formattingOptions))
            {
                _selectFormat.SelectListFormat.NewLineAfterItem = radButNewLineAfterComma.Checked;
                _selectFormat.OrderByFormat.NewLineAfterItem = radButNewLineAfterComma.Checked;
                _selectFormat.GroupByFormat.NewLineAfterItem = radButNewLineAfterComma.Checked;
            }
        }

        private void radButStartDataSourcesFromNewLines_CheckedChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(_formattingOptions))
                _selectFormat.FromClauseFormat.NewLineAfterDatasource = radButStartDataSourcesFromNewLines.Checked;
        }

        private void radButStartJoinKeywordsFromNewLines_CheckedChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(_formattingOptions))
                _selectFormat.FromClauseFormat.NewLineAfterJoin = radButStartJoinKeywordsFromNewLines.Checked;
        }

        private void chBxStartJoinConditionsOnNewLines_CheckedChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(_formattingOptions))
                _selectFormat.FromClauseFormat.NewLineBeforeJoinExpression = chBxStartJoinConditionsOnNewLines.Checked;
        }
    }
}
