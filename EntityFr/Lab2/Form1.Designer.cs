namespace Lab2
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
            this.dataViewTourist = new System.Windows.Forms.DataGridView();
            this.dataViewBases = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.bDeleteTourist = new System.Windows.Forms.Button();
            this.bDeleteBase = new System.Windows.Forms.Button();
            this.touristBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.touristNameTextBox = new System.Windows.Forms.TextBox();
            this.baseNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewTourist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewBases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.touristBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataViewTourist
            // 
            this.dataViewTourist.AllowUserToAddRows = false;
            this.dataViewTourist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewTourist.Location = new System.Drawing.Point(3, 3);
            this.dataViewTourist.Name = "dataViewTourist";
            this.dataViewTourist.ReadOnly = true;
            this.dataViewTourist.Size = new System.Drawing.Size(499, 150);
            this.dataViewTourist.TabIndex = 0;
            // 
            // dataViewBases
            // 
            this.dataViewBases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewBases.Location = new System.Drawing.Point(3, 258);
            this.dataViewBases.Name = "dataViewBases";
            this.dataViewBases.Size = new System.Drawing.Size(499, 150);
            this.dataViewBases.TabIndex = 1;
            this.dataViewBases.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewBases_CellClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(669, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bDeleteTourist
            // 
            this.bDeleteTourist.Location = new System.Drawing.Point(427, 159);
            this.bDeleteTourist.Name = "bDeleteTourist";
            this.bDeleteTourist.Size = new System.Drawing.Size(75, 23);
            this.bDeleteTourist.TabIndex = 4;
            this.bDeleteTourist.Text = "Delete";
            this.bDeleteTourist.UseVisualStyleBackColor = true;
            this.bDeleteTourist.Click += new System.EventHandler(this.bDeleteTourist_Click);
            // 
            // bDeleteBase
            // 
            this.bDeleteBase.Location = new System.Drawing.Point(427, 419);
            this.bDeleteBase.Name = "bDeleteBase";
            this.bDeleteBase.Size = new System.Drawing.Size(75, 23);
            this.bDeleteBase.TabIndex = 5;
            this.bDeleteBase.Text = "Delete";
            this.bDeleteBase.UseVisualStyleBackColor = true;
            this.bDeleteBase.Click += new System.EventHandler(this.bDeleteBase_Click);
            // 
            // touristBindingSource
            // 
            this.touristBindingSource.DataSource = typeof(Lab2.Tourist);
            // 
            // touristNameTextBox
            // 
            this.touristNameTextBox.Location = new System.Drawing.Point(644, 274);
            this.touristNameTextBox.Name = "touristNameTextBox";
            this.touristNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.touristNameTextBox.TabIndex = 6;
            // 
            // baseNameTextBox
            // 
            this.baseNameTextBox.Location = new System.Drawing.Point(644, 317);
            this.baseNameTextBox.Name = "baseNameTextBox";
            this.baseNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.baseNameTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(641, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tourist name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(641, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Base Name:";
            // 
            // bFind
            // 
            this.bFind.Location = new System.Drawing.Point(669, 343);
            this.bFind.Name = "bFind";
            this.bFind.Size = new System.Drawing.Size(75, 23);
            this.bFind.TabIndex = 10;
            this.bFind.Text = "Find";
            this.bFind.UseVisualStyleBackColor = true;
            this.bFind.Click += new System.EventHandler(this.bFind_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Controls.Add(this.bFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baseNameTextBox);
            this.Controls.Add(this.touristNameTextBox);
            this.Controls.Add(this.bDeleteBase);
            this.Controls.Add(this.bDeleteTourist);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataViewBases);
            this.Controls.Add(this.dataViewTourist);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataViewTourist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewBases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.touristBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataViewTourist;
        private System.Windows.Forms.DataGridView dataViewBases;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bDeleteTourist;
        private System.Windows.Forms.Button bDeleteBase;
        private System.Windows.Forms.BindingSource touristBindingSource;
        private System.Windows.Forms.TextBox touristNameTextBox;
        private System.Windows.Forms.TextBox baseNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bFind;
    }
}

