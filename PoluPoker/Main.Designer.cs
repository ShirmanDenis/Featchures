namespace PoluPoker
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.RollUpPanel = new System.Windows.Forms.Panel();
            this.ClosePanel = new System.Windows.Forms.Panel();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.FunctionalPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.GameTablesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.HeaderPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.FunctionalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.HeaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeaderPanel.Controls.Add(this.flowLayoutPanel1);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1315, 64);
            this.HeaderPanel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.RollUpPanel);
            this.flowLayoutPanel1.Controls.Add(this.ClosePanel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1182, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(131, 62);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // RollUpPanel
            // 
            this.RollUpPanel.BackColor = System.Drawing.Color.Transparent;
            this.RollUpPanel.BackgroundImage = global::PoluPoker.Properties.Resources.icons8_вычитание_96;
            this.RollUpPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RollUpPanel.Location = new System.Drawing.Point(3, 4);
            this.RollUpPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RollUpPanel.Name = "RollUpPanel";
            this.RollUpPanel.Size = new System.Drawing.Size(59, 37);
            this.RollUpPanel.TabIndex = 1;
            this.RollUpPanel.Click += new System.EventHandler(this.panel1_Click);
            this.RollUpPanel.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.RollUpPanel.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // ClosePanel
            // 
            this.ClosePanel.BackColor = System.Drawing.Color.Transparent;
            this.ClosePanel.BackgroundImage = global::PoluPoker.Properties.Resources.This_is_my_close_button_for_this_image__e08deb6b87983b314d88a24c09f4d13f;
            this.ClosePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClosePanel.Location = new System.Drawing.Point(68, 3);
            this.ClosePanel.Name = "ClosePanel";
            this.ClosePanel.Size = new System.Drawing.Size(59, 55);
            this.ClosePanel.TabIndex = 0;
            this.ClosePanel.Click += new System.EventHandler(this.ClosePanel_Click);
            this.ClosePanel.MouseEnter += new System.EventHandler(this.ClosePanel_MouseEnter);
            this.ClosePanel.MouseLeave += new System.EventHandler(this.ClosePanel_MouseLeave);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.FunctionalPanel);
            this.ContentPanel.Controls.Add(this.GameTablesPanel);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 64);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1315, 772);
            this.ContentPanel.TabIndex = 1;
            // 
            // FunctionalPanel
            // 
            this.FunctionalPanel.BackColor = System.Drawing.Color.LightGreen;
            this.FunctionalPanel.Controls.Add(this.button1);
            this.FunctionalPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.FunctionalPanel.Location = new System.Drawing.Point(1144, 0);
            this.FunctionalPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FunctionalPanel.Name = "FunctionalPanel";
            this.FunctionalPanel.Size = new System.Drawing.Size(171, 772);
            this.FunctionalPanel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GameTablesPanel
            // 
            this.GameTablesPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.GameTablesPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.GameTablesPanel.Location = new System.Drawing.Point(0, 0);
            this.GameTablesPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GameTablesPanel.Name = "GameTablesPanel";
            this.GameTablesPanel.Size = new System.Drawing.Size(666, 772);
            this.GameTablesPanel.TabIndex = 0;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "PoluPoker";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 836);
            this.ControlBox = false;
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.HeaderPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.FunctionalPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel ClosePanel;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.FlowLayoutPanel GameTablesPanel;
        private System.Windows.Forms.Panel FunctionalPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel RollUpPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

