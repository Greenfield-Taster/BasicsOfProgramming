namespace RGR
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ввестиМатрицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вывестиМатрицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записатьМатрицу33ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.умножНаJСтолбецToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьИзмененияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.dataGridViewInput = new System.Windows.Forms.DataGridView();
            this.dataGridViewOutput = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(695, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.ввестиМатрицуToolStripMenuItem,
            this.вывестиМатрицуToolStripMenuItem,
            this.записатьМатрицу33ToolStripMenuItem,
            this.умножНаJСтолбецToolStripMenuItem,
            this.сохранитьИзмененияToolStripMenuItem,
            this.удалитьФайлToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // ввестиМатрицуToolStripMenuItem
            // 
            this.ввестиМатрицуToolStripMenuItem.Name = "ввестиМатрицуToolStripMenuItem";
            this.ввестиМатрицуToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.ввестиМатрицуToolStripMenuItem.Text = "Ввести матрицу";
            this.ввестиМатрицуToolStripMenuItem.Click += new System.EventHandler(this.ввестиМатрицуToolStripMenuItem_Click);
            // 
            // вывестиМатрицуToolStripMenuItem
            // 
            this.вывестиМатрицуToolStripMenuItem.Name = "вывестиМатрицуToolStripMenuItem";
            this.вывестиМатрицуToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.вывестиМатрицуToolStripMenuItem.Text = "Вывести матрицу";
            this.вывестиМатрицуToolStripMenuItem.Click += new System.EventHandler(this.вывестиМатрицуToolStripMenuItem_Click);
            // 
            // записатьМатрицу33ToolStripMenuItem
            // 
            this.записатьМатрицу33ToolStripMenuItem.Name = "записатьМатрицу33ToolStripMenuItem";
            this.записатьМатрицу33ToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.записатьМатрицу33ToolStripMenuItem.Text = "Записать матрицу в файл";
            this.записатьМатрицу33ToolStripMenuItem.Click += new System.EventHandler(this.записатьМатрицу44ToolStripMenuItem_Click);
            // 
            // умножНаJСтолбецToolStripMenuItem
            // 
            this.умножНаJСтолбецToolStripMenuItem.Name = "умножНаJСтолбецToolStripMenuItem";
            this.умножНаJСтолбецToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.умножНаJСтолбецToolStripMenuItem.Text = "Умнож на j столбец";
            this.умножНаJСтолбецToolStripMenuItem.Click += new System.EventHandler(this.умножНаJСтолбецToolStripMenuItem_Click);
            // 
            // сохранитьИзмененияToolStripMenuItem
            // 
            this.сохранитьИзмененияToolStripMenuItem.Name = "сохранитьИзмененияToolStripMenuItem";
            this.сохранитьИзмененияToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.сохранитьИзмененияToolStripMenuItem.Text = "Сохранить изменения";
            this.сохранитьИзмененияToolStripMenuItem.Click += new System.EventHandler(this.сохранитьИзмененияToolStripMenuItem_Click);
            // 
            // удалитьФайлToolStripMenuItem
            // 
            this.удалитьФайлToolStripMenuItem.Name = "удалитьФайлToolStripMenuItem";
            this.удалитьФайлToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.удалитьФайлToolStripMenuItem.Text = "Удалить файл";
            this.удалитьФайлToolStripMenuItem.Click += new System.EventHandler(this.удалитьФайлToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.ItemHeight = 15;
            this.listBoxOutput.Location = new System.Drawing.Point(471, 37);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(205, 289);
            this.listBoxOutput.TabIndex = 2;
            // 
            // dataGridViewInput
            // 
            this.dataGridViewInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput.Location = new System.Drawing.Point(12, 37);
            this.dataGridViewInput.Name = "dataGridViewInput";
            this.dataGridViewInput.RowTemplate.Height = 25;
            this.dataGridViewInput.Size = new System.Drawing.Size(434, 132);
            this.dataGridViewInput.TabIndex = 4;
            // 
            // dataGridViewOutput
            // 
            this.dataGridViewOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput.Location = new System.Drawing.Point(12, 193);
            this.dataGridViewOutput.Name = "dataGridViewOutput";
            this.dataGridViewOutput.RowTemplate.Height = 25;
            this.dataGridViewOutput.Size = new System.Drawing.Size(434, 132);
            this.dataGridViewOutput.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(695, 365);
            this.Controls.Add(this.dataGridViewOutput);
            this.Controls.Add(this.dataGridViewInput);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ИДЗ (РГР)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ListBox listBoxOutput;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem записатьМатрицу33ToolStripMenuItem;
        private ToolStripMenuItem умножНаJСтолбецToolStripMenuItem;
        private ToolStripMenuItem вывестиМатрицуToolStripMenuItem;
        private ToolStripMenuItem удалитьФайлToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem сохранитьИзмененияToolStripMenuItem;
        private ToolStripMenuItem ввестиМатрицуToolStripMenuItem;
        private DataGridView dataGridViewInput;
        private DataGridView dataGridViewOutput;
    }
}