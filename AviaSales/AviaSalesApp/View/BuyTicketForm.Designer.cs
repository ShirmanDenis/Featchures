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
            this.components = new System.ComponentModel.Container();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.splitContainerLeft = new System.Windows.Forms.SplitContainer();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelFlightInfoHeader = new System.Windows.Forms.Label();
            this.buttonBuyTicket = new System.Windows.Forms.Button();
            this.panelPassangerInfo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmBxSeatClass = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txBxCost = new System.Windows.Forms.TextBox();
            this.flightInfo1 = new AviaSalesApp.View.FlightInfo();
            this.passangerInfoView1 = new AviaSalesApp.View.PassangerInfoView();
            this.seatClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).BeginInit();
            this.splitContainerLeft.Panel1.SuspendLayout();
            this.splitContainerLeft.Panel2.SuspendLayout();
            this.splitContainerLeft.SuspendLayout();
            this.panelPassangerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seatClassBindingSource)).BeginInit();
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
            this.splitContainerMain.Panel2.Controls.Add(this.txBxCost);
            this.splitContainerMain.Panel2.Controls.Add(this.label4);
            this.splitContainerMain.Panel2.Controls.Add(this.cmBxSeatClass);
            this.splitContainerMain.Panel2.Controls.Add(this.label3);
            this.splitContainerMain.Panel2.Controls.Add(this.buttonBuyTicket);
            this.splitContainerMain.Panel2.Controls.Add(this.panelPassangerInfo);
            this.splitContainerMain.Panel2.Controls.Add(this.label1);
            this.splitContainerMain.Size = new System.Drawing.Size(884, 360);
            this.splitContainerMain.SplitterDistance = 324;
            this.splitContainerMain.TabIndex = 0;
            // 
            // splitContainerLeft
            // 
            this.splitContainerLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLeft.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerLeft.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLeft.Name = "splitContainerLeft";
            this.splitContainerLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerLeft.Panel1
            // 
            this.splitContainerLeft.Panel1.BackColor = System.Drawing.Color.LightCyan;
            this.splitContainerLeft.Panel1.Controls.Add(this.buttonBack);
            this.splitContainerLeft.Panel1MinSize = 27;
            // 
            // splitContainerLeft.Panel2
            // 
            this.splitContainerLeft.Panel2.BackColor = System.Drawing.Color.LightCyan;
            this.splitContainerLeft.Panel2.Controls.Add(this.flightInfo1);
            this.splitContainerLeft.Panel2.Controls.Add(this.labelFlightInfoHeader);
            this.splitContainerLeft.Panel2MinSize = 218;
            this.splitContainerLeft.Size = new System.Drawing.Size(324, 360);
            this.splitContainerLeft.SplitterDistance = 29;
            this.splitContainerLeft.SplitterWidth = 1;
            this.splitContainerLeft.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonBack.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(0, 0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 27);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelFlightInfoHeader
            // 
            this.labelFlightInfoHeader.BackColor = System.Drawing.Color.SkyBlue;
            this.labelFlightInfoHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFlightInfoHeader.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFlightInfoHeader.Location = new System.Drawing.Point(0, 0);
            this.labelFlightInfoHeader.Name = "labelFlightInfoHeader";
            this.labelFlightInfoHeader.Size = new System.Drawing.Size(322, 29);
            this.labelFlightInfoHeader.TabIndex = 0;
            this.labelFlightInfoHeader.Text = "Selected flight info:";
            this.labelFlightInfoHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBuyTicket
            // 
            this.buttonBuyTicket.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBuyTicket.Location = new System.Drawing.Point(6, 231);
            this.buttonBuyTicket.Name = "buttonBuyTicket";
            this.buttonBuyTicket.Size = new System.Drawing.Size(104, 30);
            this.buttonBuyTicket.TabIndex = 5;
            this.buttonBuyTicket.Text = "Buy";
            this.buttonBuyTicket.UseVisualStyleBackColor = true;
            this.buttonBuyTicket.Click += new System.EventHandler(this.buttonBuyTicket_Click);
            // 
            // panelPassangerInfo
            // 
            this.panelPassangerInfo.Controls.Add(this.passangerInfoView1);
            this.panelPassangerInfo.Controls.Add(this.label2);
            this.panelPassangerInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPassangerInfo.Location = new System.Drawing.Point(0, 30);
            this.panelPassangerInfo.Name = "panelPassangerInfo";
            this.panelPassangerInfo.Padding = new System.Windows.Forms.Padding(2, 4, 2, 0);
            this.panelPassangerInfo.Size = new System.Drawing.Size(556, 142);
            this.panelPassangerInfo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Courier New", 13F);
            this.label2.Location = new System.Drawing.Point(2, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(552, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Passanger info:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buy ticket";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 11F);
            this.label3.Location = new System.Drawing.Point(3, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seat class:";
            // 
            // cmBxSeatClass
            // 
            this.cmBxSeatClass.DataSource = this.seatClassBindingSource;
            this.cmBxSeatClass.DisplayMember = "SeatClassName";
            this.cmBxSeatClass.FormattingEnabled = true;
            this.cmBxSeatClass.Location = new System.Drawing.Point(116, 178);
            this.cmBxSeatClass.Name = "cmBxSeatClass";
            this.cmBxSeatClass.Size = new System.Drawing.Size(121, 21);
            this.cmBxSeatClass.TabIndex = 7;
            this.cmBxSeatClass.SelectedIndexChanged += new System.EventHandler(this.cmBxSeatClass_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cost:";
            // 
            // txBxCost
            // 
            this.txBxCost.Location = new System.Drawing.Point(116, 205);
            this.txBxCost.Name = "txBxCost";
            this.txBxCost.ReadOnly = true;
            this.txBxCost.Size = new System.Drawing.Size(121, 20);
            this.txBxCost.TabIndex = 9;
            // 
            // flightInfo1
            // 
            this.flightInfo1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flightInfo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flightInfo1.Location = new System.Drawing.Point(0, 29);
            this.flightInfo1.Name = "flightInfo1";
            this.flightInfo1.Size = new System.Drawing.Size(322, 189);
            this.flightInfo1.TabIndex = 1;
            // 
            // passangerInfoView1
            // 
            this.passangerInfoView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passangerInfoView1.AutoSize = true;
            this.passangerInfoView1.Location = new System.Drawing.Point(2, 36);
            this.passangerInfoView1.Name = "passangerInfoView1";
            this.passangerInfoView1.Size = new System.Drawing.Size(552, 106);
            this.passangerInfoView1.TabIndex = 5;
            // 
            // seatClassBindingSource
            // 
            this.seatClassBindingSource.DataSource = typeof(AviaSalesApp.SeatClass);
            // 
            // BuyTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 360);
            this.Controls.Add(this.splitContainerMain);
            this.Name = "BuyTicketForm";
            this.Text = "BuyTicketForm";
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerLeft.Panel1.ResumeLayout(false);
            this.splitContainerLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).EndInit();
            this.splitContainerLeft.ResumeLayout(false);
            this.panelPassangerInfo.ResumeLayout(false);
            this.panelPassangerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seatClassBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.SplitContainer splitContainerLeft;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelFlightInfoHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPassangerInfo;
        private PassangerInfoView passangerInfoView1;
        private System.Windows.Forms.Button buttonBuyTicket;
        private FlightInfo flightInfo1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmBxSeatClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txBxCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource seatClassBindingSource;
    }
}