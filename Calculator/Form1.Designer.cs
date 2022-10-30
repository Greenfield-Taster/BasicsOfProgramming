namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFirstElem = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonСonstruction = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxSearchElem = new System.Windows.Forms.TextBox();
            this.buttonOutput = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Первый элемент последовательности";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите элемент для поиска в текствое поле";
            // 
            // textBoxFirstElem
            // 
            this.textBoxFirstElem.Location = new System.Drawing.Point(286, 21);
            this.textBoxFirstElem.Name = "textBoxFirstElem";
            this.textBoxFirstElem.Size = new System.Drawing.Size(100, 23);
            this.textBoxFirstElem.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(23, 157);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(237, 259);
            this.listBox1.TabIndex = 4;
            // 
            // buttonСonstruction
            // 
            this.buttonСonstruction.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonСonstruction.Location = new System.Drawing.Point(288, 174);
            this.buttonСonstruction.Name = "buttonСonstruction";
            this.buttonСonstruction.Size = new System.Drawing.Size(89, 43);
            this.buttonСonstruction.TabIndex = 5;
            this.buttonСonstruction.Text = "Построение";
            this.buttonСonstruction.UseVisualStyleBackColor = false;
            this.buttonСonstruction.Click += new System.EventHandler(this.buttonСonstruction_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(400, 63);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(85, 26);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonClear.Location = new System.Drawing.Point(288, 346);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(89, 43);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Очистка";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonExit.Location = new System.Drawing.Point(415, 396);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(74, 26);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxSearchElem
            // 
            this.textBoxSearchElem.Location = new System.Drawing.Point(286, 66);
            this.textBoxSearchElem.Name = "textBoxSearchElem";
            this.textBoxSearchElem.Size = new System.Drawing.Size(100, 23);
            this.textBoxSearchElem.TabIndex = 13;
            // 
            // buttonOutput
            // 
            this.buttonOutput.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonOutput.Location = new System.Drawing.Point(288, 258);
            this.buttonOutput.Name = "buttonOutput";
            this.buttonOutput.Size = new System.Drawing.Size(89, 43);
            this.buttonOutput.TabIndex = 10;
            this.buttonOutput.Text = "Вывод";
            this.buttonOutput.UseVisualStyleBackColor = false;
            this.buttonOutput.Click += new System.EventHandler(this.buttonOutput_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.ForeColor = System.Drawing.Color.Red;
            this.labelResult.Location = new System.Drawing.Point(23, 112);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 15);
            this.labelResult.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(497, 428);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxSearchElem);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonOutput);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonСonstruction);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxFirstElem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doubly Lists";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxFirstElem;
        private ListBox listBox1;
        private Button buttonСonstruction;
        private Button buttonSearch;
        private Button buttonClear;
        private Button buttonExit;
        private TextBox textBoxSearchElem;
        private Button buttonOutput;
        private Label labelResult;
    }
}