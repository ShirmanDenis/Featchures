namespace Lab4
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
            this.glWindow = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.renderTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // glWindow
            // 
            this.glWindow.AccumBits = ((byte)(0));
            this.glWindow.AutoCheckErrors = false;
            this.glWindow.AutoFinish = false;
            this.glWindow.AutoMakeCurrent = true;
            this.glWindow.AutoSwapBuffers = true;
            this.glWindow.BackColor = System.Drawing.Color.Black;
            this.glWindow.ColorBits = ((byte)(32));
            this.glWindow.DepthBits = ((byte)(16));
            this.glWindow.Location = new System.Drawing.Point(12, 12);
            this.glWindow.Name = "glWindow";
            this.glWindow.Size = new System.Drawing.Size(700, 544);
            this.glWindow.StencilBits = ((byte)(0));
            this.glWindow.TabIndex = 0;
            this.glWindow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.glWindow.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.glWindow_PreviewKeyDown);
            // 
            // renderTimer
            // 
            this.renderTimer.Enabled = true;
            this.renderTimer.Interval = 30;
            this.renderTimer.Tick += new System.EventHandler(this.renderTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 568);
            this.Controls.Add(this.glWindow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl glWindow;
        private System.Windows.Forms.Timer renderTimer;
    }
}

