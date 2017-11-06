namespace FormattingOptionsDemo
{
    partial class SubQueryTab
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
            this.label1 = new System.Windows.Forms.Label();
            this.UpDownSubQueryIndent = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.chBxSubQueriesFromNewlInes = new System.Windows.Forms.CheckBox();
            this.chBxSameFormatAsMainQuery = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownSubQueryIndent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chBxSameFormatAsMainQuery);
            this.groupBox1.Controls.Add(this.chBxSubQueriesFromNewlInes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.UpDownSubQueryIndent);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sub-queries format options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sub-query indent:";
            // 
            // UpDownSubQueryIndent
            // 
            this.UpDownSubQueryIndent.Location = new System.Drawing.Point(143, 21);
            this.UpDownSubQueryIndent.Name = "UpDownSubQueryIndent";
            this.UpDownSubQueryIndent.Size = new System.Drawing.Size(80, 20);
            this.UpDownSubQueryIndent.TabIndex = 1;
            this.UpDownSubQueryIndent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(311, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(440, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sub-Queries format options determine the layout of sub-queries used in expression" +
    "s of query.";
            // 
            // chBxSubQueriesFromNewlInes
            // 
            this.chBxSubQueriesFromNewlInes.AutoSize = true;
            this.chBxSubQueriesFromNewlInes.Location = new System.Drawing.Point(9, 76);
            this.chBxSubQueriesFromNewlInes.Name = "chBxSubQueriesFromNewlInes";
            this.chBxSubQueriesFromNewlInes.Size = new System.Drawing.Size(172, 17);
            this.chBxSubQueriesFromNewlInes.TabIndex = 3;
            this.chBxSubQueriesFromNewlInes.Text = "Start subqueries from new lines";
            this.chBxSubQueriesFromNewlInes.UseVisualStyleBackColor = true;
            // 
            // chBxSameFormatAsMainQuery
            // 
            this.chBxSameFormatAsMainQuery.AutoSize = true;
            this.chBxSameFormatAsMainQuery.Location = new System.Drawing.Point(9, 109);
            this.chBxSameFormatAsMainQuery.Name = "chBxSameFormatAsMainQuery";
            this.chBxSameFormatAsMainQuery.Size = new System.Drawing.Size(241, 17);
            this.chBxSameFormatAsMainQuery.TabIndex = 4;
            this.chBxSameFormatAsMainQuery.Text = "Use the same formatting as for the main query";
            this.chBxSameFormatAsMainQuery.UseVisualStyleBackColor = true;
            // 
            // SubQueriesInExpr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.groupBox1);
            this.Name = "SubQueriesInExpr";
            this.Size = new System.Drawing.Size(763, 180);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownSubQueryIndent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chBxSameFormatAsMainQuery;
        private System.Windows.Forms.CheckBox chBxSubQueriesFromNewlInes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown UpDownSubQueryIndent;
        private System.Windows.Forms.Label label1;
    }
}
