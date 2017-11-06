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
    public partial class SubQueryTab : UserControl
    {
        private readonly SQLFormattingOptions _formattingOptions;
        private readonly SQLBuilderSelectFormat _selectFormat;
        public SubQueryTab(SQLFormattingOptions formattingOptions, string prefix = "Sub-Query")
        {
            InitializeComponent();

            _formattingOptions = formattingOptions;

            if (prefix == "Sub-Query")
            {
                _selectFormat = formattingOptions.ExpressionSubQueryFormat;
            }

            if (prefix == "Derived Tables")
            {
                groupBox1.Text = "Derived tables format options";
                label1.Text = "Derived tables indent:";
                chBxSubQueriesFromNewLines.Text = "Start derived tables from new lines";
                label2.Text = "Derived Tables format options\n"+
                              "determine the layout of sub-queries\n"+ 
                              "used as data sources in the query.";

                _selectFormat = formattingOptions.DerivedQueryFormat;
            }
            if (prefix == "CTE")
            {
                groupBox1.Text = "Common table expressions format options";
                label1.Text = "CTE indent:";
                chBxSubQueriesFromNewLines.Text = "Start derived tables from new lines";
                label2.Text = "Derived Tables format options\n" +
                              "determine the layout of sub-queries\n" +
                              "used above the main query in the with clause.";

                _selectFormat = formattingOptions.CTESubQueryFormat;
            }
        }

        private void UpDownSubQueryIndent_ValueChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(_formattingOptions))
                _selectFormat.IndentInPart = (int)UpDownSubQueryIndent.Value;
        }

        private void chBxSubQueriesFromNewLines_CheckedChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(_formattingOptions))
                _selectFormat.NewLineAfterPartKeywords = chBxSubQueriesFromNewLines.Checked;
        }

        private void chBxSameFormatAsMainQuery_CheckedChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(_formattingOptions))
                _selectFormat.Assign(_formattingOptions.MainQueryFormat);
        }
    }
}
