namespace FormattingOptionsDemo
{
    partial class CommonTab
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chBxStartPartsFromNewLines = new System.Windows.Forms.CheckBox();
            this.chBxInsertNewLineAfterPartKeywords = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.upDownPartIndent = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.chBxStartSelectListItemsOnNewLines = new System.Windows.Forms.CheckBox();
            this.radButNewLineBeforeComma = new System.Windows.Forms.RadioButton();
            this.radButNewLineAfterComma = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radButStartDataSourcesFromNewLines = new System.Windows.Forms.RadioButton();
            this.radButStartJoinKeywordsFromNewLines = new System.Windows.Forms.RadioButton();
            this.chBxStartJoinConditionsOnNewLines = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownPartIndent)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.upDownPartIndent);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chBxInsertNewLineAfterPartKeywords);
            this.groupBox1.Controls.Add(this.chBxStartPartsFromNewLines);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Common SQL format options";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.radButNewLineAfterComma);
            this.groupBox2.Controls.Add(this.radButNewLineBeforeComma);
            this.groupBox2.Controls.Add(this.chBxStartSelectListItemsOnNewLines);
            this.groupBox2.Location = new System.Drawing.Point(3, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 99);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Comma-separated lists";
            // 
            // chBxStartPartsFromNewLines
            // 
            this.chBxStartPartsFromNewLines.AutoSize = true;
            this.chBxStartPartsFromNewLines.Location = new System.Drawing.Point(11, 19);
            this.chBxStartPartsFromNewLines.Name = "chBxStartPartsFromNewLines";
            this.chBxStartPartsFromNewLines.Size = new System.Drawing.Size(144, 17);
            this.chBxStartPartsFromNewLines.TabIndex = 0;
            this.chBxStartPartsFromNewLines.Text = "Start parts from new lines";
            this.chBxStartPartsFromNewLines.UseVisualStyleBackColor = true;
            // 
            // chBxInsertNewLineAfterPartKeywords
            // 
            this.chBxInsertNewLineAfterPartKeywords.AutoSize = true;
            this.chBxInsertNewLineAfterPartKeywords.Location = new System.Drawing.Point(11, 51);
            this.chBxInsertNewLineAfterPartKeywords.Name = "chBxInsertNewLineAfterPartKeywords";
            this.chBxInsertNewLineAfterPartKeywords.Size = new System.Drawing.Size(187, 17);
            this.chBxInsertNewLineAfterPartKeywords.TabIndex = 1;
            this.chBxInsertNewLineAfterPartKeywords.Text = "Insert new line after part keywords";
            this.chBxInsertNewLineAfterPartKeywords.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Part Indent:";
            // 
            // upDownPartIndent
            // 
            this.upDownPartIndent.Location = new System.Drawing.Point(211, 91);
            this.upDownPartIndent.Name = "upDownPartIndent";
            this.upDownPartIndent.Size = new System.Drawing.Size(85, 20);
            this.upDownPartIndent.TabIndex = 3;
            this.upDownPartIndent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.upDownPartIndent.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(431, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 52);
            this.label2.TabIndex = 4;
            this.label2.Text = "These options determine layout of \r\ngeneral parts of the SELECT \r\nstatement (SELE" +
    "CT, FROM, WHERE, \r\nHAVING, etc.)";
            // 
            // chBxStartSelectListItemsOnNewLines
            // 
            this.chBxStartSelectListItemsOnNewLines.AutoSize = true;
            this.chBxStartSelectListItemsOnNewLines.Location = new System.Drawing.Point(11, 28);
            this.chBxStartSelectListItemsOnNewLines.Name = "chBxStartSelectListItemsOnNewLines";
            this.chBxStartSelectListItemsOnNewLines.Size = new System.Drawing.Size(183, 17);
            this.chBxStartSelectListItemsOnNewLines.TabIndex = 0;
            this.chBxStartSelectListItemsOnNewLines.Text = "Start select list items on new lines";
            this.chBxStartSelectListItemsOnNewLines.UseVisualStyleBackColor = true;
            // 
            // radButNewLineBeforeComma
            // 
            this.radButNewLineBeforeComma.AutoSize = true;
            this.radButNewLineBeforeComma.Location = new System.Drawing.Point(11, 60);
            this.radButNewLineBeforeComma.Name = "radButNewLineBeforeComma";
            this.radButNewLineBeforeComma.Size = new System.Drawing.Size(136, 17);
            this.radButNewLineBeforeComma.TabIndex = 1;
            this.radButNewLineBeforeComma.TabStop = true;
            this.radButNewLineBeforeComma.Text = "New line before comma";
            this.radButNewLineBeforeComma.UseVisualStyleBackColor = true;
            // 
            // radButNewLineAfterComma
            // 
            this.radButNewLineAfterComma.AutoSize = true;
            this.radButNewLineAfterComma.Location = new System.Drawing.Point(211, 60);
            this.radButNewLineAfterComma.Name = "radButNewLineAfterComma";
            this.radButNewLineAfterComma.Size = new System.Drawing.Size(127, 17);
            this.radButNewLineAfterComma.TabIndex = 2;
            this.radButNewLineAfterComma.TabStop = true;
            this.radButNewLineAfterComma.Text = "New line after comma";
            this.radButNewLineAfterComma.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(426, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Layout of items in SELECT, ORDER BY\r\nand GROUP BY lists.\r\n";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.chBxStartJoinConditionsOnNewLines);
            this.groupBox3.Controls.Add(this.radButStartJoinKeywordsFromNewLines);
            this.groupBox3.Controls.Add(this.radButStartDataSourcesFromNewLines);
            this.groupBox3.Location = new System.Drawing.Point(3, 252);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(624, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "From clause";
            // 
            // radButStartDataSourcesFromNewLines
            // 
            this.radButStartDataSourcesFromNewLines.AutoSize = true;
            this.radButStartDataSourcesFromNewLines.Location = new System.Drawing.Point(11, 19);
            this.radButStartDataSourcesFromNewLines.Name = "radButStartDataSourcesFromNewLines";
            this.radButStartDataSourcesFromNewLines.Size = new System.Drawing.Size(178, 17);
            this.radButStartDataSourcesFromNewLines.TabIndex = 0;
            this.radButStartDataSourcesFromNewLines.TabStop = true;
            this.radButStartDataSourcesFromNewLines.Text = "Start datasources from new lines";
            this.radButStartDataSourcesFromNewLines.UseVisualStyleBackColor = true;
            // 
            // radButStartJoinKeywordsFromNewLines
            // 
            this.radButStartJoinKeywordsFromNewLines.AutoSize = true;
            this.radButStartJoinKeywordsFromNewLines.Location = new System.Drawing.Point(11, 42);
            this.radButStartJoinKeywordsFromNewLines.Name = "radButStartJoinKeywordsFromNewLines";
            this.radButStartJoinKeywordsFromNewLines.Size = new System.Drawing.Size(202, 17);
            this.radButStartJoinKeywordsFromNewLines.TabIndex = 1;
            this.radButStartJoinKeywordsFromNewLines.TabStop = true;
            this.radButStartJoinKeywordsFromNewLines.Text = "Start \"JOIN\" keywords from new lines";
            this.radButStartJoinKeywordsFromNewLines.UseVisualStyleBackColor = true;
            // 
            // chBxStartJoinConditionsOnNewLines
            // 
            this.chBxStartJoinConditionsOnNewLines.AutoSize = true;
            this.chBxStartJoinConditionsOnNewLines.Location = new System.Drawing.Point(11, 66);
            this.chBxStartJoinConditionsOnNewLines.Name = "chBxStartJoinConditionsOnNewLines";
            this.chBxStartJoinConditionsOnNewLines.Size = new System.Drawing.Size(180, 17);
            this.chBxStartJoinConditionsOnNewLines.TabIndex = 2;
            this.chBxStartJoinConditionsOnNewLines.Text = "Start join conditions on new lines";
            this.chBxStartJoinConditionsOnNewLines.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Location = new System.Drawing.Point(447, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Layout of the FROM part the query.\r\n";
            // 
            // MainQueryCommon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainQueryCommon";
            this.Size = new System.Drawing.Size(633, 364);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownPartIndent)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown upDownPartIndent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chBxInsertNewLineAfterPartKeywords;
        private System.Windows.Forms.CheckBox chBxStartPartsFromNewLines;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radButNewLineAfterComma;
        private System.Windows.Forms.RadioButton radButNewLineBeforeComma;
        private System.Windows.Forms.CheckBox chBxStartSelectListItemsOnNewLines;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chBxStartJoinConditionsOnNewLines;
        private System.Windows.Forms.RadioButton radButStartJoinKeywordsFromNewLines;
        private System.Windows.Forms.RadioButton radButStartDataSourcesFromNewLines;
    }
}
