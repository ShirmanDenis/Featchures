using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;

namespace FormattingOptionsDemo
{
    public partial class FormattedOptionsDemo : Form
    {
        private UserControl _currentOptionsControl;
        private readonly FormattedSQLBuilder _builder;

        public FormattedOptionsDemo()
        {
            InitializeComponent();
            _builder = new FormattedSQLBuilder(sqlQuery1.SqlFormattingOptions);

            sqlContext1.MetadataContainer.ImportFromXML("Northwind.xml");

            sqlQuery1.SQL = "SELECT\r\n  customer.first_name,\r\n  customer.last_name,\r\n  rental.return_date\r\nFROM\r\n  customer\r\n  " +
                            "INNER JOIN rental ON rental.customer_id = customer.customer_id\r\n  INNER JOIN (SELECT\r\n      address.*\r\n   " +
                            " FROM\r\n      address\r\n      INNER JOIN city ON address.city_id = city.city_id\r\n    WHERE\r\n      city.country_id = 5)" +
                            " addr ON customer.address_id = addr.address_id\r\nWHERE\r\n  customer.store_id IN (SELECT\r\n      store.store_id\r\n    FROM\r\n     " +
                            " store\r\n    WHERE\r\n      (store.manager_staff_id = 10 AND\r\n      store.store_id < 11) OR\r\n      (((store.manager_staff_id = TRUE) OR\r\n      " +
                            "  (store.manager_staff_id BETWEEN 10 AND 20))))\r\nORDER BY\r\n  rental.return_date";

            sqlQuery1.SqlFormattingOptions.Updated += SqlFormattingOptions_Updated;
            _builder.Updated += _builder_Updated;

            treeView.ExpandAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // MainQuery options
            treeView.Nodes[0].Tag = new MainQueryTab(_builder){Dock = DockStyle.Fill};
            treeView.Nodes[0].Nodes[0].Tag = new CommonTab(_builder, sqlQuery1.SqlFormattingOptions.MainQueryFormat) { Dock = DockStyle.Fill };
            treeView.Nodes[0].Nodes[1].Tag = new ExpressionsTab(sqlQuery1.SqlFormattingOptions.MainQueryFormat) { Dock = DockStyle.Fill };
            // SubQuery in expression options
            treeView.Nodes[1].Tag = new SubQueryTab(sqlQuery1.SqlFormattingOptions) { Dock = DockStyle.Fill };
            treeView.Nodes[1].Nodes[0].Tag = new CommonTab(_builder, sqlQuery1.SqlFormattingOptions.ExpressionSubQueryFormat) { Dock = DockStyle.Fill };
            treeView.Nodes[1].Nodes[1].Tag = new ExpressionsTab(sqlQuery1.SqlFormattingOptions.ExpressionSubQueryFormat) { Dock = DockStyle.Fill };
            // Derived tables options
            treeView.Nodes[2].Tag = new SubQueryTab(sqlQuery1.SqlFormattingOptions, "Derived Tables") { Dock = DockStyle.Fill };
            treeView.Nodes[2].Nodes[0].Tag = new CommonTab(_builder, sqlQuery1.SqlFormattingOptions.DerivedQueryFormat) { Dock = DockStyle.Fill };
            treeView.Nodes[2].Nodes[1].Tag = new ExpressionsTab(sqlQuery1.SqlFormattingOptions.ExpressionSubQueryFormat) { Dock = DockStyle.Fill };
            // Common table expression options
            treeView.Nodes[3].Tag = new SubQueryTab(sqlQuery1.SqlFormattingOptions, "CTE") { Dock = DockStyle.Fill };
            treeView.Nodes[3].Nodes[0].Tag = new CommonTab(_builder, sqlQuery1.SqlFormattingOptions.CTESubQueryFormat) { Dock = DockStyle.Fill };
            treeView.Nodes[3].Nodes[1].Tag = new ExpressionsTab(sqlQuery1.SqlFormattingOptions.ExpressionSubQueryFormat) { Dock = DockStyle.Fill };

            currentTabPanel.Controls.Add((UserControl)treeView.Nodes[0].Tag);        
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

            Invalidate();
        }

        private void sqlQuery1_SQLUpdated(object sender, EventArgs e)
        {
            sqlTextEditor1.Text = _builder.GetSQL(sqlQuery1.QueryRoot);
        }

        private void sqlTextEditor1_Validating(object sender, CancelEventArgs e)
        {
            // Update the query builder with manually edited query text:
            sqlQuery1.SQL = sqlTextEditor1.Text;
        }

        private void SqlFormattingOptions_Updated(object sender, EventArgs e)
        {
            sqlTextEditor1.Text = _builder.GetSQL(sqlQuery1.QueryRoot);
        }

        private void _builder_Updated(object sender, EventArgs e)
        {
            sqlTextEditor1.Text = _builder.GetSQL(sqlQuery1.QueryRoot);
        }
    }
}
