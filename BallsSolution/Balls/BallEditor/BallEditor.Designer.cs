namespace Balls.BallEditor
{
    partial class BallEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmBxColor = new System.Windows.Forms.ComboBox();
            this.upDownWidth = new System.Windows.Forms.NumericUpDown();
            this.upDownLocationX = new System.Windows.Forms.NumericUpDown();
            this.upDownLocationY = new System.Windows.Forms.NumericUpDown();
            this.upDownSpeedX = new System.Windows.Forms.NumericUpDown();
            this.upDownSpeedY = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.upDownMass = new System.Windows.Forms.NumericUpDown();
            this.upDownRadius = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.upDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownLocationX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownLocationY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownSpeedX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownSpeedY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownMass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "LineWidth:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Speed";
            // 
            // cmBxColor
            // 
            this.cmBxColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmBxColor.FormattingEnabled = true;
            this.cmBxColor.Location = new System.Drawing.Point(43, 48);
            this.cmBxColor.Name = "cmBxColor";
            this.cmBxColor.Size = new System.Drawing.Size(94, 21);
            this.cmBxColor.TabIndex = 4;
            this.cmBxColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmBxColor_DrawItem);
            this.cmBxColor.SelectedIndexChanged += new System.EventHandler(this.cmBxColor_SelectedIndexChanged);
            // 
            // upDownWidth
            // 
            this.upDownWidth.Location = new System.Drawing.Point(70, 9);
            this.upDownWidth.Name = "upDownWidth";
            this.upDownWidth.Size = new System.Drawing.Size(67, 20);
            this.upDownWidth.TabIndex = 5;
            this.upDownWidth.ValueChanged += new System.EventHandler(this.upDownWidth_ValueChanged);
            // 
            // upDownLocationX
            // 
            this.upDownLocationX.Location = new System.Drawing.Point(223, 9);
            this.upDownLocationX.Name = "upDownLocationX";
            this.upDownLocationX.Size = new System.Drawing.Size(41, 20);
            this.upDownLocationX.TabIndex = 6;
            this.upDownLocationX.ValueChanged += new System.EventHandler(this.upDownLocationX_ValueChanged);
            // 
            // upDownLocationY
            // 
            this.upDownLocationY.Location = new System.Drawing.Point(270, 9);
            this.upDownLocationY.Name = "upDownLocationY";
            this.upDownLocationY.Size = new System.Drawing.Size(41, 20);
            this.upDownLocationY.TabIndex = 7;
            this.upDownLocationY.ValueChanged += new System.EventHandler(this.upDownLocationY_ValueChanged);
            // 
            // upDownSpeedX
            // 
            this.upDownSpeedX.Location = new System.Drawing.Point(223, 46);
            this.upDownSpeedX.Name = "upDownSpeedX";
            this.upDownSpeedX.Size = new System.Drawing.Size(41, 20);
            this.upDownSpeedX.TabIndex = 8;
            this.upDownSpeedX.ValueChanged += new System.EventHandler(this.upDownSpeedX_ValueChanged);
            // 
            // upDownSpeedY
            // 
            this.upDownSpeedY.Location = new System.Drawing.Point(270, 46);
            this.upDownSpeedY.Name = "upDownSpeedY";
            this.upDownSpeedY.Size = new System.Drawing.Size(41, 20);
            this.upDownSpeedY.TabIndex = 9;
            this.upDownSpeedY.ValueChanged += new System.EventHandler(this.upDownSpeedY_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Radius:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mass:";
            // 
            // upDownMass
            // 
            this.upDownMass.Location = new System.Drawing.Point(223, 82);
            this.upDownMass.Name = "upDownMass";
            this.upDownMass.Size = new System.Drawing.Size(41, 20);
            this.upDownMass.TabIndex = 12;
            this.upDownMass.ValueChanged += new System.EventHandler(this.upDownMass_ValueChanged);
            // 
            // upDownRadius
            // 
            this.upDownRadius.Location = new System.Drawing.Point(70, 82);
            this.upDownRadius.Name = "upDownRadius";
            this.upDownRadius.Size = new System.Drawing.Size(67, 20);
            this.upDownRadius.TabIndex = 13;
            this.upDownRadius.ValueChanged += new System.EventHandler(this.upDownRadius_ValueChanged);
            // 
            // BallEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.upDownRadius);
            this.Controls.Add(this.upDownMass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.upDownSpeedY);
            this.Controls.Add(this.upDownSpeedX);
            this.Controls.Add(this.upDownLocationY);
            this.Controls.Add(this.upDownLocationX);
            this.Controls.Add(this.upDownWidth);
            this.Controls.Add(this.cmBxColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BallEditor";
            this.Size = new System.Drawing.Size(334, 114);
            ((System.ComponentModel.ISupportInitialize)(this.upDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownLocationX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownLocationY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownSpeedX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownSpeedY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownMass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownRadius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmBxColor;
        private System.Windows.Forms.NumericUpDown upDownWidth;
        private System.Windows.Forms.NumericUpDown upDownLocationX;
        private System.Windows.Forms.NumericUpDown upDownLocationY;
        private System.Windows.Forms.NumericUpDown upDownSpeedX;
        private System.Windows.Forms.NumericUpDown upDownSpeedY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown upDownMass;
        private System.Windows.Forms.NumericUpDown upDownRadius;
    }
}
