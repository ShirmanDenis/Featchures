namespace AffineCryptosystem
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
            this.panelDescription = new System.Windows.Forms.Panel();
            this.txBxAlphaBet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.upDownN = new System.Windows.Forms.NumericUpDown();
            this.upDownB = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.upDownA = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEncrypt = new System.Windows.Forms.TabPage();
            this.splitContainerEncrypt = new System.Windows.Forms.SplitContainer();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.txBxTextToEncrypt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txBxEncryptResult = new System.Windows.Forms.TextBox();
            this.tabPageDecrypt = new System.Windows.Forms.TabPage();
            this.splitContainerDecrypt = new System.Windows.Forms.SplitContainer();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.txBxTextToDecrypt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txBxDecryptedText = new System.Windows.Forms.TextBox();
            this.toolTipNOD = new System.Windows.Forms.ToolTip(this.components);
            this.panelDescription.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownA)).BeginInit();
            this.panelGeneral.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageEncrypt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEncrypt)).BeginInit();
            this.splitContainerEncrypt.Panel1.SuspendLayout();
            this.splitContainerEncrypt.Panel2.SuspendLayout();
            this.splitContainerEncrypt.SuspendLayout();
            this.tabPageDecrypt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDecrypt)).BeginInit();
            this.splitContainerDecrypt.Panel1.SuspendLayout();
            this.splitContainerDecrypt.Panel2.SuspendLayout();
            this.splitContainerDecrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDescription
            // 
            this.panelDescription.Controls.Add(this.txBxAlphaBet);
            this.panelDescription.Controls.Add(this.label8);
            this.panelDescription.Controls.Add(this.tableLayoutPanel1);
            this.panelDescription.Controls.Add(this.label1);
            this.panelDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDescription.Location = new System.Drawing.Point(0, 0);
            this.panelDescription.Name = "panelDescription";
            this.panelDescription.Size = new System.Drawing.Size(632, 111);
            this.panelDescription.TabIndex = 0;
            // 
            // txBxAlphaBet
            // 
            this.txBxAlphaBet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txBxAlphaBet.Location = new System.Drawing.Point(389, 26);
            this.txBxAlphaBet.Multiline = true;
            this.txBxAlphaBet.Name = "txBxAlphaBet";
            this.txBxAlphaBet.Size = new System.Drawing.Size(236, 79);
            this.txBxAlphaBet.TabIndex = 6;
            this.txBxAlphaBet.Text = " абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            this.txBxAlphaBet.TextChanged += new System.EventHandler(this.txBxAlphaBet_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Алфавит:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.upDownN, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.upDownB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.upDownA, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(295, 79);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "n:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "b:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "a:";
            // 
            // upDownN
            // 
            this.upDownN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.upDownN.AutoSize = true;
            this.upDownN.Location = new System.Drawing.Point(31, 3);
            this.upDownN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDownN.Name = "upDownN";
            this.upDownN.ReadOnly = true;
            this.upDownN.Size = new System.Drawing.Size(83, 20);
            this.upDownN.TabIndex = 5;
            this.upDownN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDownN.ValueChanged += new System.EventHandler(this.upDownN_ValueChanged);
            // 
            // upDownB
            // 
            this.upDownB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.upDownB.AutoSize = true;
            this.upDownB.Location = new System.Drawing.Point(31, 55);
            this.upDownB.Name = "upDownB";
            this.upDownB.Size = new System.Drawing.Size(83, 20);
            this.upDownB.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(120, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Мощность алфавита";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // upDownA
            // 
            this.upDownA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.upDownA.Location = new System.Drawing.Point(31, 29);
            this.upDownA.Name = "upDownA";
            this.upDownA.Size = new System.Drawing.Size(83, 20);
            this.upDownA.TabIndex = 9;
            this.upDownA.Validating += new System.ComponentModel.CancelEventHandler(this.upDownA_Validating);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(632, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Параметры:";
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.tabControl1);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGeneral.Location = new System.Drawing.Point(0, 111);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(632, 280);
            this.panelGeneral.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageEncrypt);
            this.tabControl1.Controls.Add(this.tabPageDecrypt);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(632, 280);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageEncrypt
            // 
            this.tabPageEncrypt.Controls.Add(this.splitContainerEncrypt);
            this.tabPageEncrypt.Location = new System.Drawing.Point(4, 22);
            this.tabPageEncrypt.Name = "tabPageEncrypt";
            this.tabPageEncrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEncrypt.Size = new System.Drawing.Size(624, 254);
            this.tabPageEncrypt.TabIndex = 0;
            this.tabPageEncrypt.Text = "Зашифровать";
            this.tabPageEncrypt.UseVisualStyleBackColor = true;
            // 
            // splitContainerEncrypt
            // 
            this.splitContainerEncrypt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerEncrypt.Location = new System.Drawing.Point(3, 3);
            this.splitContainerEncrypt.Name = "splitContainerEncrypt";
            // 
            // splitContainerEncrypt.Panel1
            // 
            this.splitContainerEncrypt.Panel1.Controls.Add(this.buttonEncrypt);
            this.splitContainerEncrypt.Panel1.Controls.Add(this.txBxTextToEncrypt);
            // 
            // splitContainerEncrypt.Panel2
            // 
            this.splitContainerEncrypt.Panel2.Controls.Add(this.label6);
            this.splitContainerEncrypt.Panel2.Controls.Add(this.txBxEncryptResult);
            this.splitContainerEncrypt.Size = new System.Drawing.Size(618, 248);
            this.splitContainerEncrypt.SplitterDistance = 293;
            this.splitContainerEncrypt.TabIndex = 0;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(5, 3);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(94, 23);
            this.buttonEncrypt.TabIndex = 1;
            this.buttonEncrypt.Text = "Зашифровать";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // txBxTextToEncrypt
            // 
            this.txBxTextToEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txBxTextToEncrypt.Location = new System.Drawing.Point(5, 32);
            this.txBxTextToEncrypt.Multiline = true;
            this.txBxTextToEncrypt.Name = "txBxTextToEncrypt";
            this.txBxTextToEncrypt.Size = new System.Drawing.Size(285, 216);
            this.txBxTextToEncrypt.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Зашифрованный текст:";
            // 
            // txBxEncryptResult
            // 
            this.txBxEncryptResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txBxEncryptResult.Location = new System.Drawing.Point(3, 32);
            this.txBxEncryptResult.Multiline = true;
            this.txBxEncryptResult.Name = "txBxEncryptResult";
            this.txBxEncryptResult.Size = new System.Drawing.Size(313, 216);
            this.txBxEncryptResult.TabIndex = 1;
            // 
            // tabPageDecrypt
            // 
            this.tabPageDecrypt.Controls.Add(this.splitContainerDecrypt);
            this.tabPageDecrypt.Location = new System.Drawing.Point(4, 22);
            this.tabPageDecrypt.Name = "tabPageDecrypt";
            this.tabPageDecrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDecrypt.Size = new System.Drawing.Size(624, 254);
            this.tabPageDecrypt.TabIndex = 1;
            this.tabPageDecrypt.Text = "Расшифровать";
            this.tabPageDecrypt.UseVisualStyleBackColor = true;
            // 
            // splitContainerDecrypt
            // 
            this.splitContainerDecrypt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDecrypt.Location = new System.Drawing.Point(3, 3);
            this.splitContainerDecrypt.Name = "splitContainerDecrypt";
            // 
            // splitContainerDecrypt.Panel1
            // 
            this.splitContainerDecrypt.Panel1.Controls.Add(this.buttonDecrypt);
            this.splitContainerDecrypt.Panel1.Controls.Add(this.txBxTextToDecrypt);
            // 
            // splitContainerDecrypt.Panel2
            // 
            this.splitContainerDecrypt.Panel2.Controls.Add(this.label7);
            this.splitContainerDecrypt.Panel2.Controls.Add(this.txBxDecryptedText);
            this.splitContainerDecrypt.Size = new System.Drawing.Size(618, 248);
            this.splitContainerDecrypt.SplitterDistance = 293;
            this.splitContainerDecrypt.TabIndex = 1;
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(5, 3);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(94, 23);
            this.buttonDecrypt.TabIndex = 1;
            this.buttonDecrypt.Text = "Расшифровать";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // txBxTextToDecrypt
            // 
            this.txBxTextToDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txBxTextToDecrypt.Location = new System.Drawing.Point(5, 32);
            this.txBxTextToDecrypt.Multiline = true;
            this.txBxTextToDecrypt.Name = "txBxTextToDecrypt";
            this.txBxTextToDecrypt.Size = new System.Drawing.Size(285, 216);
            this.txBxTextToDecrypt.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Расшифрованный текст:";
            // 
            // txBxDecryptedText
            // 
            this.txBxDecryptedText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txBxDecryptedText.Location = new System.Drawing.Point(3, 32);
            this.txBxDecryptedText.Multiline = true;
            this.txBxDecryptedText.Name = "txBxDecryptedText";
            this.txBxDecryptedText.Size = new System.Drawing.Size(313, 216);
            this.txBxDecryptedText.TabIndex = 1;
            // 
            // toolTipNOD
            // 
            this.toolTipNOD.ShowAlways = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 391);
            this.Controls.Add(this.panelGeneral);
            this.Controls.Add(this.panelDescription);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelDescription.ResumeLayout(false);
            this.panelDescription.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownA)).EndInit();
            this.panelGeneral.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageEncrypt.ResumeLayout(false);
            this.splitContainerEncrypt.Panel1.ResumeLayout(false);
            this.splitContainerEncrypt.Panel1.PerformLayout();
            this.splitContainerEncrypt.Panel2.ResumeLayout(false);
            this.splitContainerEncrypt.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEncrypt)).EndInit();
            this.splitContainerEncrypt.ResumeLayout(false);
            this.tabPageDecrypt.ResumeLayout(false);
            this.splitContainerDecrypt.Panel1.ResumeLayout(false);
            this.splitContainerDecrypt.Panel1.PerformLayout();
            this.splitContainerDecrypt.Panel2.ResumeLayout(false);
            this.splitContainerDecrypt.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDecrypt)).EndInit();
            this.splitContainerDecrypt.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDescription;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown upDownN;
        private System.Windows.Forms.NumericUpDown upDownB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEncrypt;
        private System.Windows.Forms.SplitContainer splitContainerEncrypt;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.TextBox txBxTextToEncrypt;
        private System.Windows.Forms.TabPage tabPageDecrypt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txBxEncryptResult;
        private System.Windows.Forms.SplitContainer splitContainerDecrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.TextBox txBxTextToDecrypt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txBxDecryptedText;
        private System.Windows.Forms.NumericUpDown upDownA;
        private System.Windows.Forms.ToolTip toolTipNOD;
        private System.Windows.Forms.TextBox txBxAlphaBet;
        private System.Windows.Forms.Label label8;
    }
}

