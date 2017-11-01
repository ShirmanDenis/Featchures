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
            this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemCone = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLineStipple = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDepth = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemBackWall = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEdges = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenu.SuspendLayout();
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
            this.glWindow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.glWindow_MouseClick);
            this.glWindow.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.glWindow_PreviewKeyDown);
            // 
            // renderTimer
            // 
            this.renderTimer.Enabled = true;
            this.renderTimer.Interval = 30;
            this.renderTimer.Tick += new System.EventHandler(this.renderTimer_Tick);
            // 
            // ContextMenu
            // 
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCone,
            this.MenuItemStar,
            this.MenuItemLineStipple});
            this.ContextMenu.Name = "ContextMenu";
            this.ContextMenu.Size = new System.Drawing.Size(111, 70);
            // 
            // MenuItemCone
            // 
            this.MenuItemCone.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemDepth,
            this.MenuItemBackWall,
            this.MenuItemSelection});
            this.MenuItemCone.Name = "MenuItemCone";
            this.MenuItemCone.Size = new System.Drawing.Size(152, 22);
            this.MenuItemCone.Text = "Конус";
            this.MenuItemCone.Click += new System.EventHandler(this.contextCone_Click);
            // 
            // MenuItemStar
            // 
            this.MenuItemStar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemEdges});
            this.MenuItemStar.Name = "MenuItemStar";
            this.MenuItemStar.Size = new System.Drawing.Size(152, 22);
            this.MenuItemStar.Text = "Звезда";
            this.MenuItemStar.Click += new System.EventHandler(this.MenuItemStar_Click);
            // 
            // MenuItemLineStipple
            // 
            this.MenuItemLineStipple.Name = "MenuItemLineStipple";
            this.MenuItemLineStipple.Size = new System.Drawing.Size(152, 22);
            this.MenuItemLineStipple.Text = "Лучи";
            this.MenuItemLineStipple.Click += new System.EventHandler(this.MenuItemLinesStipple_Click);
            // 
            // MenuItemDepth
            // 
            this.MenuItemDepth.Name = "MenuItemDepth";
            this.MenuItemDepth.Size = new System.Drawing.Size(152, 22);
            this.MenuItemDepth.Text = "Глубина";
            this.MenuItemDepth.Click += new System.EventHandler(this.MenuItemDepth_Click);
            // 
            // MenuItemBackWall
            // 
            this.MenuItemBackWall.Name = "MenuItemBackWall";
            this.MenuItemBackWall.Size = new System.Drawing.Size(152, 22);
            this.MenuItemBackWall.Text = "Стенки";
            this.MenuItemBackWall.Click += new System.EventHandler(this.MenuItemBackWall_Click);
            // 
            // MenuItemSelection
            // 
            this.MenuItemSelection.Name = "MenuItemSelection";
            this.MenuItemSelection.Size = new System.Drawing.Size(152, 22);
            this.MenuItemSelection.Text = "Отбор";
            this.MenuItemSelection.Click += new System.EventHandler(this.MenuItemSelection_Click);
            // 
            // MenuItemEdges
            // 
            this.MenuItemEdges.Name = "MenuItemEdges";
            this.MenuItemEdges.Size = new System.Drawing.Size(152, 22);
            this.MenuItemEdges.Text = "Вершины";
            this.MenuItemEdges.Click += new System.EventHandler(this.MenuItemEdges_Click);
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
            this.ContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl glWindow;
        private System.Windows.Forms.Timer renderTimer;
        private System.Windows.Forms.ContextMenuStrip ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCone;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDepth;
        private System.Windows.Forms.ToolStripMenuItem MenuItemBackWall;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSelection;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStar;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEdges;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLineStipple;
    }
}

