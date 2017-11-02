namespace FormattingOptionsDemo
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Common");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Expressions");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("MainQuery", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Common");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Expressions");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Sub-Queries in expressions", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Common");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Expressions");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Derived tables", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Common");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Expressions");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Common table expressions", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23});
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
            treeNode13.Name = "common";
            treeNode13.Text = "Common";
            treeNode14.Name = "expression";
            treeNode14.Text = "Expressions";
            treeNode15.Name = "mainQuery";
            treeNode15.Text = "MainQuery";
            treeNode16.Name = "common";
            treeNode16.Text = "Common";
            treeNode17.Name = "expressions";
            treeNode17.Text = "Expressions";
            treeNode18.Name = "subQueryiesInExpressions";
            treeNode18.Text = "Sub-Queries in expressions";
            treeNode19.Name = "common";
            treeNode19.Text = "Common";
            treeNode20.Name = "expressions";
            treeNode20.Text = "Expressions";
            treeNode21.Name = "derivedTables";
            treeNode21.Text = "Derived tables";
            treeNode22.Name = "common";
            treeNode22.Text = "Common";
            treeNode23.Name = "expressions";
            treeNode23.Text = "Expressions";
            treeNode24.Name = "commonTableExpressions";
            treeNode24.Text = "Common table expressions";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode18,
            treeNode21,
            treeNode24});
            this.treeView.Size = new System.Drawing.Size(187, 640);
            this.treeView.TabIndex = 0;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 664);
            this.Controls.Add(this.currentTabPanel);
            this.Controls.Add(this.treeView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Panel currentTabPanel;
    }
}

