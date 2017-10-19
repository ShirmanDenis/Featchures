namespace Lab_3
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GlWindow = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GlWindow
            // 
            this.GlWindow.AccumBits = ((byte)(0));
            this.GlWindow.AutoCheckErrors = false;
            this.GlWindow.AutoFinish = false;
            this.GlWindow.AutoMakeCurrent = true;
            this.GlWindow.AutoSwapBuffers = true;
            this.GlWindow.BackColor = System.Drawing.Color.Black;
            this.GlWindow.ColorBits = ((byte)(32));
            this.GlWindow.DepthBits = ((byte)(16));
            this.GlWindow.Location = new System.Drawing.Point(12, 12);
            this.GlWindow.Name = "GlWindow";
            this.GlWindow.Size = new System.Drawing.Size(603, 558);
            this.GlWindow.StencilBits = ((byte)(0));
            this.GlWindow.TabIndex = 0;
            this.GlWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.window_MouseDown);
            this.GlWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.window_MouseMove);
            this.GlWindow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.window_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(739, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 582);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GlWindow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl GlWindow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}

