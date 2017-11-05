namespace CastleModel
{
    partial class CastleForm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.glWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glWindow.Location = new System.Drawing.Point(0, 0);
            this.glWindow.Name = "glWindow";
            this.glWindow.Size = new System.Drawing.Size(921, 653);
            this.glWindow.StencilBits = ((byte)(0));
            this.glWindow.TabIndex = 0;
            this.glWindow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.glWindow.KeyUp += new System.Windows.Forms.KeyEventHandler(this.glWindow_KeyUp);
            this.glWindow.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.glWindow_PreviewKeyDown);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CastleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 653);
            this.Controls.Add(this.glWindow);
            this.Name = "CastleForm";
            this.Text = "Castle";
            this.Load += new System.EventHandler(this.CastleForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.glWindow_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl glWindow;
        private System.Windows.Forms.Timer timer1;
    }
}

