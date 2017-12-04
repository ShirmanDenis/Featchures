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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txBxRadius = new System.Windows.Forms.TextBox();
            this.txBxMass = new System.Windows.Forms.TextBox();
            this.txBxLocationX = new System.Windows.Forms.TextBox();
            this.txBxLocationY = new System.Windows.Forms.TextBox();
            this.txBxSpeedX = new System.Windows.Forms.TextBox();
            this.txBxSpeedY = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.upDownWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 80);
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
            this.cmBxColor.Location = new System.Drawing.Point(49, 43);
            this.cmBxColor.Name = "cmBxColor";
            this.cmBxColor.Size = new System.Drawing.Size(94, 21);
            this.cmBxColor.TabIndex = 4;
            this.cmBxColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmBxColor_DrawItem);
            this.cmBxColor.SelectedIndexChanged += new System.EventHandler(this.cmBxColor_SelectedIndexChanged);
            // 
            // upDownWidth
            // 
            this.upDownWidth.Location = new System.Drawing.Point(251, 77);
            this.upDownWidth.Name = "upDownWidth";
            this.upDownWidth.Size = new System.Drawing.Size(67, 20);
            this.upDownWidth.TabIndex = 5;
            this.upDownWidth.ValueChanged += new System.EventHandler(this.upDownWidth_ValueChanged);
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
            this.label6.Location = new System.Drawing.Point(3, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mass:";
            // 
            // txBxRadius
            // 
            this.txBxRadius.Location = new System.Drawing.Point(49, 77);
            this.txBxRadius.Name = "txBxRadius";
            this.txBxRadius.Size = new System.Drawing.Size(94, 20);
            this.txBxRadius.TabIndex = 12;
            this.txBxRadius.Validated += new System.EventHandler(this.txBxRadius_Validated);
            // 
            // txBxMass
            // 
            this.txBxMass.Location = new System.Drawing.Point(49, 8);
            this.txBxMass.Name = "txBxMass";
            this.txBxMass.Size = new System.Drawing.Size(94, 20);
            this.txBxMass.TabIndex = 13;
            this.txBxMass.Validated += new System.EventHandler(this.txBxMass_Validated);
            // 
            // txBxLocationX
            // 
            this.txBxLocationX.Location = new System.Drawing.Point(223, 8);
            this.txBxLocationX.Name = "txBxLocationX";
            this.txBxLocationX.Size = new System.Drawing.Size(40, 20);
            this.txBxLocationX.TabIndex = 14;
            this.txBxLocationX.Validated += new System.EventHandler(this.txBxLocationX_Validated);
            // 
            // txBxLocationY
            // 
            this.txBxLocationY.Location = new System.Drawing.Point(278, 8);
            this.txBxLocationY.Name = "txBxLocationY";
            this.txBxLocationY.Size = new System.Drawing.Size(40, 20);
            this.txBxLocationY.TabIndex = 15;
            this.txBxLocationY.Validated += new System.EventHandler(this.txBxLocationY_Validated);
            // 
            // txBxSpeedX
            // 
            this.txBxSpeedX.Location = new System.Drawing.Point(223, 44);
            this.txBxSpeedX.Name = "txBxSpeedX";
            this.txBxSpeedX.Size = new System.Drawing.Size(40, 20);
            this.txBxSpeedX.TabIndex = 16;
            this.txBxSpeedX.Validated += new System.EventHandler(this.txBxSpeedX_Validated);
            // 
            // txBxSpeedY
            // 
            this.txBxSpeedY.Location = new System.Drawing.Point(278, 45);
            this.txBxSpeedY.Name = "txBxSpeedY";
            this.txBxSpeedY.Size = new System.Drawing.Size(40, 20);
            this.txBxSpeedY.TabIndex = 17;
            this.txBxSpeedY.Validated += new System.EventHandler(this.txBxSpeedY_Validated);
            // 
            // BallEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txBxSpeedY);
            this.Controls.Add(this.txBxSpeedX);
            this.Controls.Add(this.txBxLocationY);
            this.Controls.Add(this.txBxLocationX);
            this.Controls.Add(this.txBxMass);
            this.Controls.Add(this.txBxRadius);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.upDownWidth);
            this.Controls.Add(this.cmBxColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BallEditor";
            this.Size = new System.Drawing.Size(336, 116);
            ((System.ComponentModel.ISupportInitialize)(this.upDownWidth)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txBxRadius;
        private System.Windows.Forms.TextBox txBxMass;
        private System.Windows.Forms.TextBox txBxLocationX;
        private System.Windows.Forms.TextBox txBxLocationY;
        private System.Windows.Forms.TextBox txBxSpeedX;
        private System.Windows.Forms.TextBox txBxSpeedY;
    }
}
