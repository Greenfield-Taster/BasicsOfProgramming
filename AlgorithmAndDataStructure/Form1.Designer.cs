namespace AlgorithmAndDataStructure
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
            this.открытьИДополнительноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.читатьИВыполнитьДействиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.читатьИПоказатьНаФормеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записьВФайлеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалениеФайлаСДискаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxWriteText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(466, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьИДополнительноToolStripMenuItem,
            this.читатьИВыполнитьДействиеToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.читатьИПоказатьНаФормеToolStripMenuItem,
            this.записьВФайлеToolStripMenuItem,
            this.удалениеФайлаСДискаToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьИДополнительноToolStripMenuItem
            // 
            this.открытьИДополнительноToolStripMenuItem.Name = "открытьИДополнительноToolStripMenuItem";
            this.открытьИДополнительноToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.открытьИДополнительноToolStripMenuItem.Text = "Открыть и дополнить";
            this.открытьИДополнительноToolStripMenuItem.Click += new System.EventHandler(this.открытьИДополнительноToolStripMenuItem_Click);
            // 
            // читатьИВыполнитьДействиеToolStripMenuItem
            // 
            this.читатьИВыполнитьДействиеToolStripMenuItem.Name = "читатьИВыполнитьДействиеToolStripMenuItem";
            this.читатьИВыполнитьДействиеToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.читатьИВыполнитьДействиеToolStripMenuItem.Text = "Читать и выполнить действие";
            this.читатьИВыполнитьДействиеToolStripMenuItem.Click += new System.EventHandler(this.читатьИВыполнитьДействиеToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // читатьИПоказатьНаФормеToolStripMenuItem
            // 
            this.читатьИПоказатьНаФормеToolStripMenuItem.Name = "читатьИПоказатьНаФормеToolStripMenuItem";
            this.читатьИПоказатьНаФормеToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.читатьИПоказатьНаФормеToolStripMenuItem.Text = "Читать и показать на форме";
            this.читатьИПоказатьНаФормеToolStripMenuItem.Click += new System.EventHandler(this.читатьИПоказатьНаФормеToolStripMenuItem_Click);
            // 
            // записьВФайлеToolStripMenuItem
            // 
            this.записьВФайлеToolStripMenuItem.Name = "записьВФайлеToolStripMenuItem";
            this.записьВФайлеToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.записьВФайлеToolStripMenuItem.Text = "Запись в файл";
            this.записьВФайлеToolStripMenuItem.Click += new System.EventHandler(this.записьВФайлеToolStripMenuItem_Click);
            // 
            // удалениеФайлаСДискаToolStripMenuItem
            // 
            this.удалениеФайлаСДискаToolStripMenuItem.Name = "удалениеФайлаСДискаToolStripMenuItem";
            this.удалениеФайлаСДискаToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.удалениеФайлаСДискаToolStripMenuItem.Text = "Удаление файла с диска";
            this.удалениеФайлаСДискаToolStripMenuItem.Click += new System.EventHandler(this.удалениеФайлаСДискаToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество букв";
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.ItemHeight = 15;
            this.listBoxOutput.Location = new System.Drawing.Point(12, 227);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(442, 94);
            this.listBoxOutput.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Вывод текста из файла";
            // 
            // textBoxWriteText
            // 
            this.textBoxWriteText.Location = new System.Drawing.Point(12, 71);
            this.textBoxWriteText.Name = "textBoxWriteText";
            this.textBoxWriteText.Size = new System.Drawing.Size(442, 23);
            this.textBoxWriteText.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Введите текст";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(466, 333);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxWriteText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem открытьИДополнительноToolStripMenuItem;
        private ToolStripMenuItem читатьИВыполнитьДействиеToolStripMenuItem;
        private ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private ToolStripMenuItem читатьИПоказатьНаФормеToolStripMenuItem;
        private ToolStripMenuItem записьВФайлеToolStripMenuItem;
        private ToolStripMenuItem удалениеФайлаСДискаToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TextBox textBox1;
        private Label label1;
        private ListBox listBoxOutput;
        private Label label3;
        private TextBox textBoxWriteText;
        private Label label4;
    }
}