namespace AviaSalesApp.View
{
    partial class ScheduleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.filterPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSwap = new System.Windows.Forms.Button();
            this.cmBxFrom = new System.Windows.Forms.ComboBox();
            this.labelFrom = new System.Windows.Forms.Label();
            this.cmBxTo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.schedulePanel = new System.Windows.Forms.Panel();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.additionalDataControls = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.filterPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.schedulePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.additionalDataControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // filterPanel
            // 
            this.filterPanel.AutoSize = true;
            this.filterPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.filterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterPanel.Controls.Add(this.tableLayoutPanel2);
            this.filterPanel.Controls.Add(this.tableLayoutPanel1);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterPanel.Location = new System.Drawing.Point(0, 0);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(1130, 54);
            this.filterPanel.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTimeTo, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.dateTimeFrom, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(767, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.88889F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.11111F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(358, 45);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "To:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 1);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "From:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeTo.Location = new System.Drawing.Point(64, 22);
            this.dateTimeTo.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(294, 20);
            this.dateTimeTo.TabIndex = 6;
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimeFrom.Location = new System.Drawing.Point(64, 0);
            this.dateTimeFrom.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(294, 20);
            this.dateTimeFrom.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonSwap, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmBxFrom, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelFrom, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmBxTo, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(761, 27);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // buttonSwap
            // 
            this.buttonSwap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSwap.Location = new System.Drawing.Point(354, 3);
            this.buttonSwap.Name = "buttonSwap";
            this.buttonSwap.Size = new System.Drawing.Size(75, 21);
            this.buttonSwap.TabIndex = 5;
            this.buttonSwap.Text = "button1";
            this.buttonSwap.UseVisualStyleBackColor = true;
            // 
            // cmBxFrom
            // 
            this.cmBxFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmBxFrom.FormattingEnabled = true;
            this.cmBxFrom.Location = new System.Drawing.Point(74, 3);
            this.cmBxFrom.Name = "cmBxFrom";
            this.cmBxFrom.Size = new System.Drawing.Size(274, 21);
            this.cmBxFrom.TabIndex = 2;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFrom.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFrom.Location = new System.Drawing.Point(3, 1);
            this.labelFrom.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(65, 25);
            this.labelFrom.TabIndex = 0;
            this.labelFrom.Text = "From:";
            // 
            // cmBxTo
            // 
            this.cmBxTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmBxTo.FormattingEnabled = true;
            this.cmBxTo.Location = new System.Drawing.Point(484, 3);
            this.cmBxTo.Name = "cmBxTo";
            this.cmBxTo.Size = new System.Drawing.Size(274, 21);
            this.cmBxTo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(435, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "To:";
            // 
            // schedulePanel
            // 
            this.schedulePanel.AutoSize = true;
            this.schedulePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.schedulePanel.Controls.Add(this.dataView);
            this.schedulePanel.Controls.Add(this.additionalDataControls);
            this.schedulePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulePanel.Location = new System.Drawing.Point(0, 54);
            this.schedulePanel.Name = "schedulePanel";
            this.schedulePanel.Size = new System.Drawing.Size(1130, 576);
            this.schedulePanel.TabIndex = 1;
            // 
            // dataView
            // 
            this.dataView.AllowUserToAddRows = false;
            this.dataView.AllowUserToDeleteRows = false;
            this.dataView.AllowUserToOrderColumns = true;
            this.dataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataView.Location = new System.Drawing.Point(0, 0);
            this.dataView.Name = "dataView";
            this.dataView.ReadOnly = true;
            this.dataView.Size = new System.Drawing.Size(906, 576);
            this.dataView.TabIndex = 1;
            // 
            // additionalDataControls
            // 
            this.additionalDataControls.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.additionalDataControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.additionalDataControls.Controls.Add(this.button2);
            this.additionalDataControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.additionalDataControls.Location = new System.Drawing.Point(906, 0);
            this.additionalDataControls.Name = "additionalDataControls";
            this.additionalDataControls.Size = new System.Drawing.Size(224, 576);
            this.additionalDataControls.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Buy ticket";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 630);
            this.Controls.Add(this.schedulePanel);
            this.Controls.Add(this.filterPanel);
            this.Name = "ScheduleForm";
            this.Text = "ScheduleForm";
            this.filterPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.schedulePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.additionalDataControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Panel schedulePanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonSwap;
        private System.Windows.Forms.ComboBox cmBxFrom;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.ComboBox cmBxTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel additionalDataControls;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeTo;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.Button button2;
    }
}