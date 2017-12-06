namespace Balls
{
    partial class AddBallDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.upDownLocationX = new System.Windows.Forms.NumericUpDown();
            this.upDownLoacationY = new System.Windows.Forms.NumericUpDown();
            this.upDownSpeedX = new System.Windows.Forms.NumericUpDown();
            this.upDownSpeedY = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.upDownRadius = new System.Windows.Forms.NumericUpDown();
            this.upDownMass = new System.Windows.Forms.NumericUpDown();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.upDownLocationX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownLoacationY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownSpeedX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownSpeedY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownMass)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Radius:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Location:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Speed:";
            // 
            // upDownLocationX
            // 
            this.upDownLocationX.Location = new System.Drawing.Point(69, 74);
            this.upDownLocationX.Name = "upDownLocationX";
            this.upDownLocationX.Size = new System.Drawing.Size(39, 20);
            this.upDownLocationX.TabIndex = 4;
            // 
            // upDownLoacationY
            // 
            this.upDownLoacationY.Location = new System.Drawing.Point(114, 74);
            this.upDownLoacationY.Name = "upDownLoacationY";
            this.upDownLoacationY.Size = new System.Drawing.Size(39, 20);
            this.upDownLoacationY.TabIndex = 5;
            // 
            // upDownSpeedX
            // 
            this.upDownSpeedX.Location = new System.Drawing.Point(69, 105);
            this.upDownSpeedX.Name = "upDownSpeedX";
            this.upDownSpeedX.Size = new System.Drawing.Size(39, 20);
            this.upDownSpeedX.TabIndex = 6;
            // 
            // upDownSpeedY
            // 
            this.upDownSpeedY.Location = new System.Drawing.Point(114, 105);
            this.upDownSpeedY.Name = "upDownSpeedY";
            this.upDownSpeedY.Size = new System.Drawing.Size(39, 20);
            this.upDownSpeedY.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mass:";
            // 
            // upDownRadius
            // 
            this.upDownRadius.Location = new System.Drawing.Point(69, 7);
            this.upDownRadius.Name = "upDownRadius";
            this.upDownRadius.Size = new System.Drawing.Size(39, 20);
            this.upDownRadius.TabIndex = 9;
            // 
            // upDownMass
            // 
            this.upDownMass.Location = new System.Drawing.Point(69, 37);
            this.upDownMass.Name = "upDownMass";
            this.upDownMass.Size = new System.Drawing.Size(39, 20);
            this.upDownMass.TabIndex = 10;
            this.upDownMass.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(15, 131);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(138, 41);
            this.buttonOk.TabIndex = 11;
            this.buttonOk.Text = "Okay";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(159, 131);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(130, 41);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // AddBallDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 182);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.upDownMass);
            this.Controls.Add(this.upDownRadius);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.upDownSpeedY);
            this.Controls.Add(this.upDownSpeedX);
            this.Controls.Add(this.upDownLoacationY);
            this.Controls.Add(this.upDownLocationX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBallDialog";
            this.Text = "AddBallDialog";
            this.Load += new System.EventHandler(this.AddBallDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.upDownLocationX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownLoacationY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownSpeedX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownSpeedY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownMass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown upDownLocationX;
        private System.Windows.Forms.NumericUpDown upDownLoacationY;
        private System.Windows.Forms.NumericUpDown upDownSpeedX;
        private System.Windows.Forms.NumericUpDown upDownSpeedY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown upDownRadius;
        private System.Windows.Forms.NumericUpDown upDownMass;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}