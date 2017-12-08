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
            this.panelFlightInfo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelFlightInfo
            // 
            this.panelFlightInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFlightInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFlightInfo.Location = new System.Drawing.Point(0, 0);
            this.panelFlightInfo.Name = "panelFlightInfo";
            this.panelFlightInfo.Size = new System.Drawing.Size(877, 100);
            this.panelFlightInfo.TabIndex = 0;
            // 
            // BuyTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 524);
            this.Controls.Add(this.panelFlightInfo);
            this.Name = "BuyTicketForm";
            this.Text = "BuyTicketForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFlightInfo;
    }
}