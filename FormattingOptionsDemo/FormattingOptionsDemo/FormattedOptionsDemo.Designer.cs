namespace FormattingOptionsDemo
{
    partial class FormattedOptionsDemo
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Common");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Expressions");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("MainQuery", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Common");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Expressions");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Sub-Queries in expressions", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Common");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Expressions");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Derived tables", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Common");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Expressions");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Common table expressions", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            this.treeView = new System.Windows.Forms.TreeView();
            this.currentTabPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView.Location = new System.Drawing.Point(12, 12);
            this.treeView.Name = "treeView";
            treeNode1.Name = "common";
            treeNode1.Text = "Common";
            treeNode2.Name = "expression";
            treeNode2.Text = "Expressions";
            treeNode3.Name = "mainQuery";
            treeNode3.Text = "MainQuery";
            treeNode4.Name = "common";
            treeNode4.Text = "Common";
            treeNode5.Name = "expressions";
            treeNode5.Text = "Expressions";
            treeNode6.Name = "subQueryiesInExpressions";
            treeNode6.Text = "Sub-Queries in expressions";
            treeNode7.Name = "common";
            treeNode7.Text = "Common";
            treeNode8.Name = "expressions";
            treeNode8.Text = "Expressions";
            treeNode9.Name = "derivedTables";
            treeNode9.Text = "Derived tables";
            treeNode10.Name = "common";
            treeNode10.Text = "Common";
            treeNode11.Name = "expressions";
            treeNode11.Text = "Expressions";
            treeNode12.Name = "commonTableExpressions";
            treeNode12.Text = "Common table expressions";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode9,
            treeNode12});
            this.treeView.Size = new System.Drawing.Size(187, 640);
            this.treeView.TabIndex = 0;
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // currentTabPanel
            // 
            this.currentTabPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentTabPanel.Location = new System.Drawing.Point(205, 12);
            this.currentTabPanel.Name = "currentTabPanel";
            this.currentTabPanel.Size = new System.Drawing.Size(754, 377);
            this.currentTabPanel.TabIndex = 1;
            // 
            // FormattedOptionsDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 664);
            this.Controls.Add(this.currentTabPanel);
            this.Controls.Add(this.treeView);
            this.Name = "FormattedOptionsDemo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Panel currentTabPanel;
    }
}

