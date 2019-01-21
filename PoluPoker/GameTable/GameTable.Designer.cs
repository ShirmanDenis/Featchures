namespace PoluPoker.GameTable
{
    partial class GameTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.panelStartStop = new System.Windows.Forms.Panel();
            this.panelForTime = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelForTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label.Font = new System.Drawing.Font("Malgun Gothic Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(0, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(559, 324);
            this.label.TabIndex = 0;
            this.label.Text = "label1";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label.Click += new System.EventHandler(this.label_Click);
            this.label.DoubleClick += new System.EventHandler(this.label_DoubleClick);
            this.label.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.label.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Font = new System.Drawing.Font("Malgun Gothic Semilight", 18F);
            this.textBox1.Location = new System.Drawing.Point(233, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 47);
            this.textBox1.TabIndex = 1;
            this.textBox1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelEdit);
            this.panel1.Controls.Add(this.panelStartStop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(517, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(42, 324);
            this.panel1.TabIndex = 2;
            // 
            // panelEdit
            // 
            this.panelEdit.BackgroundImage = global::PoluPoker.Properties.Resources.edit;
            this.panelEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEdit.Location = new System.Drawing.Point(0, 42);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(42, 42);
            this.panelEdit.TabIndex = 1;
            this.panelEdit.MouseEnter += new System.EventHandler(this.panelEdit_MouseEnter);
            this.panelEdit.MouseLeave += new System.EventHandler(this.panelEdit_MouseLeave);
            // 
            // panelStartStop
            // 
            this.panelStartStop.BackgroundImage = global::PoluPoker.Properties.Resources.play;
            this.panelStartStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelStartStop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStartStop.Location = new System.Drawing.Point(0, 0);
            this.panelStartStop.Name = "panelStartStop";
            this.panelStartStop.Size = new System.Drawing.Size(42, 42);
            this.panelStartStop.TabIndex = 0;
            this.panelStartStop.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panelForTime
            // 
            this.panelForTime.Controls.Add(this.labelTime);
            this.panelForTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelForTime.Location = new System.Drawing.Point(0, 289);
            this.panelForTime.Name = "panelForTime";
            this.panelForTime.Size = new System.Drawing.Size(517, 35);
            this.panelForTime.TabIndex = 3;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTime.Font = new System.Drawing.Font("Malgun Gothic Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(0, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(63, 20);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "00:05:00";
            // 
            // GameTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panelForTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label);
            this.Name = "GameTable";
            this.Size = new System.Drawing.Size(559, 324);
            this.panel1.ResumeLayout(false);
            this.panelForTime.ResumeLayout(false);
            this.panelForTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelStartStop;
        private System.Windows.Forms.Panel panelForTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel panelEdit;
    }
}
