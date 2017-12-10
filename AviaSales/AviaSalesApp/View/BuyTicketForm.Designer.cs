namespace AviaSalesApp.View
{
    partial class BuyTicketForm
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
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.splitContainerLeft = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.labelFlightInfoHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.flightInfo1 = new AviaSalesApp.View.FlightInfo();
            this.passangerInfoView1 = new AviaSalesApp.View.PassangerInfoView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).BeginInit();
            this.splitContainerLeft.Panel1.SuspendLayout();
            this.splitContainerLeft.Panel2.SuspendLayout();
            this.splitContainerLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.splitContainerLeft);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.BackColor = System.Drawing.Color.LightCyan;
            this.splitContainerMain.Panel2.Controls.Add(this.panel1);
            this.splitContainerMain.Panel2.Controls.Add(this.label1);
            this.splitContainerMain.Size = new System.Drawing.Size(901, 360);
            this.splitContainerMain.SplitterDistance = 295;
            this.splitContainerMain.TabIndex = 0;
            // 
            // splitContainerLeft
            // 
            this.splitContainerLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLeft.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLeft.Name = "splitContainerLeft";
            this.splitContainerLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerLeft.Panel1
            // 
            this.splitContainerLeft.Panel1.BackColor = System.Drawing.Color.LightCyan;
            this.splitContainerLeft.Panel1.Controls.Add(this.button1);
            // 
            // splitContainerLeft.Panel2
            // 
            this.splitContainerLeft.Panel2.BackColor = System.Drawing.Color.LightCyan;
            this.splitContainerLeft.Panel2.Controls.Add(this.flightInfo1);
            this.splitContainerLeft.Panel2.Controls.Add(this.labelFlightInfoHeader);
            this.splitContainerLeft.Size = new System.Drawing.Size(295, 360);
            this.splitContainerLeft.SplitterDistance = 29;
            this.splitContainerLeft.SplitterWidth = 3;
            this.splitContainerLeft.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelFlightInfoHeader
            // 
            this.labelFlightInfoHeader.BackColor = System.Drawing.Color.SkyBlue;
            this.labelFlightInfoHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFlightInfoHeader.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFlightInfoHeader.Location = new System.Drawing.Point(0, 0);
            this.labelFlightInfoHeader.Name = "labelFlightInfoHeader";
            this.labelFlightInfoHeader.Size = new System.Drawing.Size(293, 29);
            this.labelFlightInfoHeader.TabIndex = 0;
            this.labelFlightInfoHeader.Text = "Selected flight info:";
            this.labelFlightInfoHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(602, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buy ticket:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.passangerInfoView1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 142);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Courier New", 13F);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Passanger info:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flightInfo1
            // 
            this.flightInfo1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flightInfo1.Location = new System.Drawing.Point(3, 32);
            this.flightInfo1.Name = "flightInfo1";
            this.flightInfo1.Size = new System.Drawing.Size(287, 189);
            this.flightInfo1.TabIndex = 1;
            // 
            // passangerInfoView1
            // 
            this.passangerInfoView1.AutoSize = true;
            this.passangerInfoView1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.passangerInfoView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.passangerInfoView1.Location = new System.Drawing.Point(0, 29);
            this.passangerInfoView1.Name = "passangerInfoView1";
            this.passangerInfoView1.Size = new System.Drawing.Size(376, 113);
            this.passangerInfoView1.TabIndex = 5;
            // 
            // BuyTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 360);
            this.Controls.Add(this.splitContainerMain);
            this.Name = "BuyTicketForm";
            this.Text = "BuyTicketForm";
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerLeft.Panel1.ResumeLayout(false);
            this.splitContainerLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).EndInit();
            this.splitContainerLeft.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.SplitContainer splitContainerLeft;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelFlightInfoHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private FlightInfo flightInfo1;
        private PassangerInfoView passangerInfoView1;
    }
}