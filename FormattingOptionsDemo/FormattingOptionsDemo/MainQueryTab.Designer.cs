﻿namespace FormattingOptionsDemo
{
    partial class MainQueryTab
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
            this.chBxEnableWordWrap = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chBxEnableDynamicIndents = new System.Windows.Forms.CheckBox();
            this.chBxEnableDynamicRightMargin = new System.Windows.Forms.CheckBox();
            this.chBxParenthesizeConditionsWithinAndOperators = new System.Windows.Forms.CheckBox();
            this.chBxParenthesizeEachSingleCondition = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chBxParenthesizeEachSingleCondition);
            this.groupBox1.Controls.Add(this.chBxParenthesizeConditionsWithinAndOperators);
            this.groupBox1.Controls.Add(this.chBxEnableDynamicRightMargin);
            this.groupBox1.Controls.Add(this.chBxEnableDynamicIndents);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chBxEnableWordWrap);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 390);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General SQL Formatting options";
            // 
            // chBxEnableWordWrap
            // 
            this.chBxEnableWordWrap.AutoSize = true;
            this.chBxEnableWordWrap.Location = new System.Drawing.Point(6, 19);
            this.chBxEnableWordWrap.Name = "chBxEnableWordWrap";
            this.chBxEnableWordWrap.Size = new System.Drawing.Size(111, 17);
            this.chBxEnableWordWrap.TabIndex = 0;
            this.chBxEnableWordWrap.Text = "Enable word wrap";
            this.chBxEnableWordWrap.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Maximum characters in line:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Keywords case:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(171, 45);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "First Upper",
            "UpperCase",
            "LowerCase"});
            this.comboBox1.Location = new System.Drawing.Point(171, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "UpperCase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(351, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "These options affect on whole SQL query text (main query and sub-queries)";
            // 
            // chBxEnableDynamicIndents
            // 
            this.chBxEnableDynamicIndents.AutoSize = true;
            this.chBxEnableDynamicIndents.Location = new System.Drawing.Point(6, 125);
            this.chBxEnableDynamicIndents.Name = "chBxEnableDynamicIndents";
            this.chBxEnableDynamicIndents.Size = new System.Drawing.Size(138, 17);
            this.chBxEnableDynamicIndents.TabIndex = 6;
            this.chBxEnableDynamicIndents.Text = "Enable dynamic indents";
            this.chBxEnableDynamicIndents.UseVisualStyleBackColor = true;
            // 
            // chBxEnableDynamicRightMargin
            // 
            this.chBxEnableDynamicRightMargin.AutoSize = true;
            this.chBxEnableDynamicRightMargin.Location = new System.Drawing.Point(6, 159);
            this.chBxEnableDynamicRightMargin.Name = "chBxEnableDynamicRightMargin";
            this.chBxEnableDynamicRightMargin.Size = new System.Drawing.Size(158, 17);
            this.chBxEnableDynamicRightMargin.TabIndex = 7;
            this.chBxEnableDynamicRightMargin.Text = "Enable dynamic right margin";
            this.chBxEnableDynamicRightMargin.UseVisualStyleBackColor = true;
            // 
            // chBxParenthesizeConditionsWithinAndOperators
            // 
            this.chBxParenthesizeConditionsWithinAndOperators.AutoSize = true;
            this.chBxParenthesizeConditionsWithinAndOperators.Location = new System.Drawing.Point(6, 194);
            this.chBxParenthesizeConditionsWithinAndOperators.Name = "chBxParenthesizeConditionsWithinAndOperators";
            this.chBxParenthesizeConditionsWithinAndOperators.Size = new System.Drawing.Size(241, 17);
            this.chBxParenthesizeConditionsWithinAndOperators.TabIndex = 8;
            this.chBxParenthesizeConditionsWithinAndOperators.Text = "Parenthesize conditions within AND operators";
            this.chBxParenthesizeConditionsWithinAndOperators.UseVisualStyleBackColor = true;
            // 
            // chBxParenthesizeEachSingleCondition
            // 
            this.chBxParenthesizeEachSingleCondition.AutoSize = true;
            this.chBxParenthesizeEachSingleCondition.Location = new System.Drawing.Point(6, 236);
            this.chBxParenthesizeEachSingleCondition.Name = "chBxParenthesizeEachSingleCondition";
            this.chBxParenthesizeEachSingleCondition.Size = new System.Drawing.Size(190, 17);
            this.chBxParenthesizeEachSingleCondition.TabIndex = 9;
            this.chBxParenthesizeEachSingleCondition.Text = "Parenthesize each single condition";
            this.chBxParenthesizeEachSingleCondition.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Example:\r\n(Condition1 AND condition2) OR (Condition3 AND Condition4)\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 39);
            this.label5.TabIndex = 11;
            this.label5.Text = "Example:\r\n(Condition1) AND (condition2) OR (Condition3) AND (Condition4)\r\n\r\n";
            // 
            // MainQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.groupBox1);
            this.Name = "MainQuery";
            this.Size = new System.Drawing.Size(728, 400);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chBxParenthesizeEachSingleCondition;
        private System.Windows.Forms.CheckBox chBxParenthesizeConditionsWithinAndOperators;
        private System.Windows.Forms.CheckBox chBxEnableDynamicRightMargin;
        private System.Windows.Forms.CheckBox chBxEnableDynamicIndents;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chBxEnableWordWrap;
    }
}