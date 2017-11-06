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
        private SQLFormattingOptions _formattingOptions;

        public SubQueryTab(SQLFormattingOptions formattingOptions, string prefix = "Sub-Query")
        {
            InitializeComponent();

            _formattingOptions = formattingOptions;

            if (prefix == "Derived Tables")
            {
                groupBox1.Text = "Derived tables format options";
                label1.Text = "Derived tables indent:";
                chBxSubQueriesFromNewlInes.Text = "Start derived tables from new lines";
                label2.Text = "Derived Tables format options\n"+
                              "determine the layout of sub-queries\n"+ 
                              "used as data sources in the query.";

            }
            if (prefix == "CTE")
            {
                groupBox1.Text = "Common table expressions format options";
                label1.Text = "CTE indent:";
                chBxSubQueriesFromNewlInes.Text = "Start derived tables from new lines";
                label2.Text = "Derived Tables format options\n" +
                              "determine the layout of sub-queries\n" +
                              "used above the main query in the with clause.";

            }
        }
    }
}
