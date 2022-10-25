namespace ListItemsMultiplication
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
            this.textBoxNumbers = new System.Windows.Forms.TextBox();
            this.labelText = new System.Windows.Forms.Label();
            this.buttonResult = new System.Windows.Forms.Button();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelKol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNumbers
            // 
            this.textBoxNumbers.Location = new System.Drawing.Point(222, 28);
            this.textBoxNumbers.Name = "textBoxNumbers";
            this.textBoxNumbers.Size = new System.Drawing.Size(127, 20);
            this.textBoxNumbers.TabIndex = 0;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelText.Location = new System.Drawing.Point(97, 31);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(108, 13);
            this.labelText.TabIndex = 1;
            this.labelText.Text = "Введите 7 значений";
            // 
            // buttonResult
            // 
            this.buttonResult.BackColor = System.Drawing.Color.Azure;
            this.buttonResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonResult.Location = new System.Drawing.Point(100, 71);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(105, 43);
            this.buttonResult.TabIndex = 2;
            this.buttonResult.Text = " Расчитать";
            this.buttonResult.UseVisualStyleBackColor = false;
            this.buttonResult.Click += new System.EventHandler(this.ButtonResult_Click);
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(219, 71);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(138, 13);
            this.labelSum.TabIndex = 3;
            this.labelSum.Text = "Сумма на парных местах:";
            // 
            // labelKol
            // 
            this.labelKol.AutoSize = true;
            this.labelKol.Location = new System.Drawing.Point(219, 99);
            this.labelKol.Name = "labelKol";
            this.labelKol.Size = new System.Drawing.Size(178, 13);
            this.labelKol.TabIndex = 4;
            this.labelKol.Text = "Количество эл на парных местах:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(481, 161);
            this.Controls.Add(this.labelKol);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.textBoxNumbers);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Practical Work 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumbers;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelKol;
    }
}

