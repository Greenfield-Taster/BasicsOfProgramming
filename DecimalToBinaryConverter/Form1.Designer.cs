namespace DecimalToBinaryConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelDecimal = new System.Windows.Forms.Label();
            this.textBoxDecimal = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxBinary = new System.Windows.Forms.TextBox();
            this.labelBinary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDecimal
            // 
            this.labelDecimal.AutoSize = true;
            this.labelDecimal.Location = new System.Drawing.Point(38, 39);
            this.labelDecimal.Name = "labelDecimal";
            this.labelDecimal.Size = new System.Drawing.Size(109, 15);
            this.labelDecimal.TabIndex = 0;
            this.labelDecimal.Text = "Десятичное число";
            // 
            // textBoxDecimal
            // 
            this.textBoxDecimal.Location = new System.Drawing.Point(168, 36);
            this.textBoxDecimal.Name = "textBoxDecimal";
            this.textBoxDecimal.Size = new System.Drawing.Size(155, 23);
            this.textBoxDecimal.TabIndex = 1;
            // 
            // buttonConvert
            // 
            this.buttonConvert.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonConvert.Location = new System.Drawing.Point(362, 56);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(102, 51);
            this.buttonConvert.TabIndex = 2;
            this.buttonConvert.Text = "Перевести";
            this.buttonConvert.UseVisualStyleBackColor = false;
            this.buttonConvert.Click += new System.EventHandler(this.ButtonConvert_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.Control;
            this.buttonExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExit.BackgroundImage")));
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Location = new System.Drawing.Point(500, 22);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(243, 137);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // textBoxBinary
            // 
            this.textBoxBinary.Location = new System.Drawing.Point(168, 106);
            this.textBoxBinary.Name = "textBoxBinary";
            this.textBoxBinary.Size = new System.Drawing.Size(155, 23);
            this.textBoxBinary.TabIndex = 5;
            // 
            // labelBinary
            // 
            this.labelBinary.AutoSize = true;
            this.labelBinary.Location = new System.Drawing.Point(38, 109);
            this.labelBinary.Name = "labelBinary";
            this.labelBinary.Size = new System.Drawing.Size(99, 15);
            this.labelBinary.TabIndex = 4;
            this.labelBinary.Text = "Двоичное число";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(765, 178);
            this.Controls.Add(this.textBoxBinary);
            this.Controls.Add(this.labelBinary);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.textBoxDecimal);
            this.Controls.Add(this.labelDecimal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конвертер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelDecimal;
        private TextBox textBoxDecimal;
        private Button buttonConvert;
        private Button buttonExit;
        private TextBox textBoxBinary;
        private Label labelBinary;
    }
}