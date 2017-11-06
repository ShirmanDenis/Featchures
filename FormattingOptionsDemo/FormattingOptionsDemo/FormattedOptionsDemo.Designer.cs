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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Common");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Expressions");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("MainQuery", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26});
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Common");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Expressions");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Sub-Queries in expressions", new System.Windows.Forms.TreeNode[] {
            treeNode28,
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Common");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Expressions");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Derived tables", new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode32});
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Common");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Expressions");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Common table expressions", new System.Windows.Forms.TreeNode[] {
            treeNode34,
            treeNode35});
            ActiveQueryBuilder.Core.BehaviorOptions behaviorOptions1 = new ActiveQueryBuilder.Core.BehaviorOptions();
            ActiveQueryBuilder.Core.SQLParsingOptions sqlParsingOptions1 = new ActiveQueryBuilder.Core.SQLParsingOptions();
            ActiveQueryBuilder.Core.MetadataStructure metadataStructure1 = new ActiveQueryBuilder.Core.MetadataStructure();
            ActiveQueryBuilder.Core.MetadataFilter metadataFilter1 = new ActiveQueryBuilder.Core.MetadataFilter();
            ActiveQueryBuilder.Core.MetadataStructureOptions metadataStructureOptions1 = new ActiveQueryBuilder.Core.MetadataStructureOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormattedOptionsDemo));
            this.treeView = new System.Windows.Forms.TreeView();
            this.currentTabPanel = new System.Windows.Forms.Panel();
            this.sqlTextEditor1 = new ActiveQueryBuilder.View.WinForms.ExpressionEditor.SqlTextEditor();
            this.sqlQuery1 = new ActiveQueryBuilder.Core.SQLQuery(this.components);
            this.sqlContext1 = new ActiveQueryBuilder.Core.SQLContext(this.components);
            this.mssqlSyntaxProvider1 = new ActiveQueryBuilder.Core.MSSQLSyntaxProvider(this.components);
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView.Location = new System.Drawing.Point(12, 12);
            this.treeView.Name = "treeView";
            treeNode25.Name = "common";
            treeNode25.Text = "Common";
            treeNode26.Name = "expression";
            treeNode26.Text = "Expressions";
            treeNode27.Name = "mainQuery";
            treeNode27.Text = "MainQuery";
            treeNode28.Name = "common";
            treeNode28.Text = "Common";
            treeNode29.Name = "expressions";
            treeNode29.Text = "Expressions";
            treeNode30.Name = "subQueryiesInExpressions";
            treeNode30.Text = "Sub-Queries in expressions";
            treeNode31.Name = "common";
            treeNode31.Text = "Common";
            treeNode32.Name = "expressions";
            treeNode32.Text = "Expressions";
            treeNode33.Name = "derivedTables";
            treeNode33.Text = "Derived tables";
            treeNode34.Name = "common";
            treeNode34.Text = "Common";
            treeNode35.Name = "expressions";
            treeNode35.Text = "Expressions";
            treeNode36.Name = "commonTableExpressions";
            treeNode36.Text = "Common table expressions";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode30,
            treeNode33,
            treeNode36});
            this.treeView.Size = new System.Drawing.Size(187, 665);
            this.treeView.TabIndex = 0;
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // currentTabPanel
            // 
            this.currentTabPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentTabPanel.Location = new System.Drawing.Point(205, 12);
            this.currentTabPanel.Name = "currentTabPanel";
            this.currentTabPanel.Size = new System.Drawing.Size(902, 340);
            this.currentTabPanel.TabIndex = 1;
            // 
            // sqlTextEditor1
            // 
            this.sqlTextEditor1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sqlTextEditor1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sqlTextEditor1.KeywordColor = System.Drawing.Color.DodgerBlue;
            this.sqlTextEditor1.Location = new System.Drawing.Point(205, 358);
            this.sqlTextEditor1.Name = "sqlTextEditor1";
            this.sqlTextEditor1.Query = null;
            this.sqlTextEditor1.QueryProvider = null;
            this.sqlTextEditor1.Size = new System.Drawing.Size(902, 319);
            this.sqlTextEditor1.SuggestionWindowSize = new System.Drawing.Size(200, 200);
            this.sqlTextEditor1.TabIndex = 2;
            this.sqlTextEditor1.Text = "sqlTextEditor1";
            this.sqlTextEditor1.Validating += new System.ComponentModel.CancelEventHandler(this.sqlTextEditor1_Validating);
            // 
            // sqlQuery1
            // 
            this.sqlQuery1.BehaviorOptions = behaviorOptions1;
            this.sqlQuery1.SleepModeText = null;
            this.sqlQuery1.SQLChanging = false;
            this.sqlQuery1.SQLContext = this.sqlContext1;
            sqlParsingOptions1.AllowSleepMode = false;
            sqlParsingOptions1.ParsingErrorOnUnknownObjects = false;
            this.sqlQuery1.SqlParsingOptions = sqlParsingOptions1;
            this.sqlQuery1.SQLUpdated += new System.EventHandler(this.sqlQuery1_SQLUpdated);
            // 
            // sqlContext1
            // 
            this.sqlContext1.LoadingOptions.ExcludeFilter.Types = ActiveQueryBuilder.Core.MetadataType.None;
            this.sqlContext1.MetadataProvider = null;
            // 
            // 
            // 
            this.sqlContext1.SQLGenerationOptionsForServer.ExpandVirtualFields = true;
            this.sqlContext1.SQLGenerationOptionsForServer.ExpandVirtualObjects = true;
            this.sqlContext1.SQLGenerationOptionsForServer.UseAltNames = false;
            this.sqlContext1.SyntaxProvider = this.mssqlSyntaxProvider1;
            metadataStructure1.AllowChildAutoItems = true;
            metadataStructure1.Caption = null;
            metadataStructure1.ImageIndex = -1;
            metadataStructure1.IsDynamic = false;
            metadataFilter1.OwnObjects = true;
            metadataStructure1.MetadataFilter = metadataFilter1;
            metadataStructure1.MetadataName = null;
            metadataStructureOptions1.ProceduresFolderText = "Procedures";
            metadataStructureOptions1.SynonymsFolderText = "Synonyms";
            metadataStructureOptions1.TablesFolderText = "Tables";
            metadataStructureOptions1.ViewsFolderText = "Views";
            metadataStructure1.Options = metadataStructureOptions1;
            metadataStructure1.XML = resources.GetString("metadataStructure1.XML");
            this.sqlContext1.UserQueriesStructure = metadataStructure1;
            // 
            // mssqlSyntaxProvider1
            // 
            this.mssqlSyntaxProvider1.OnCalcExpressionType = null;
            // 
            // FormattedOptionsDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 689);
            this.Controls.Add(this.sqlTextEditor1);
            this.Controls.Add(this.currentTabPanel);
            this.Controls.Add(this.treeView);
            this.Name = "FormattedOptionsDemo";
            this.Text = "FormattedOptions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Panel currentTabPanel;
        private ActiveQueryBuilder.View.WinForms.ExpressionEditor.SqlTextEditor sqlTextEditor1;
        private ActiveQueryBuilder.Core.SQLQuery sqlQuery1;
        private ActiveQueryBuilder.Core.SQLContext sqlContext1;
        private ActiveQueryBuilder.Core.MSSQLSyntaxProvider mssqlSyntaxProvider1;
    }
}

