namespace Sets
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
            this.menuStripOperation = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemOperation = new System.Windows.Forms.ToolStripMenuItem();
            this.объединениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пересечениеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вычитаниеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сравнениеАВToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аСодержитсяВВToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вСодержитсяВАToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.принадлежностьЭлтаМнвуАToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.иДЗToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStripOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripOperation
            // 
            this.menuStripOperation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOperation,
            this.оПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem,
            this.иДЗToolStripMenuItem});
            this.menuStripOperation.Location = new System.Drawing.Point(0, 0);
            this.menuStripOperation.Name = "menuStripOperation";
            this.menuStripOperation.Size = new System.Drawing.Size(421, 24);
            this.menuStripOperation.TabIndex = 0;
            this.menuStripOperation.Text = "Операции над множествами";
            // 
            // toolStripMenuItemOperation
            // 
            this.toolStripMenuItemOperation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.объединениеToolStripMenuItem,
            this.пересечениеToolStripMenuItem1,
            this.вычитаниеToolStripMenuItem1,
            this.сравнениеАВToolStripMenuItem,
            this.аСодержитсяВВToolStripMenuItem,
            this.вСодержитсяВАToolStripMenuItem,
            this.принадлежностьЭлтаМнвуАToolStripMenuItem});
            this.toolStripMenuItemOperation.Name = "toolStripMenuItemOperation";
            this.toolStripMenuItemOperation.Size = new System.Drawing.Size(159, 20);
            this.toolStripMenuItemOperation.Text = "Работа над множествами";
            // 
            // объединениеToolStripMenuItem
            // 
            this.объединениеToolStripMenuItem.Name = "объединениеToolStripMenuItem";
            this.объединениеToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.объединениеToolStripMenuItem.Text = "Объединение";
            this.объединениеToolStripMenuItem.Click += new System.EventHandler(this.объединениеToolStripMenuItem_Click);
            // 
            // пересечениеToolStripMenuItem1
            // 
            this.пересечениеToolStripMenuItem1.Name = "пересечениеToolStripMenuItem1";
            this.пересечениеToolStripMenuItem1.Size = new System.Drawing.Size(248, 22);
            this.пересечениеToolStripMenuItem1.Text = "Пересечение";
            this.пересечениеToolStripMenuItem1.Click += new System.EventHandler(this.пересечениеToolStripMenuItem1_Click);
            // 
            // вычитаниеToolStripMenuItem1
            // 
            this.вычитаниеToolStripMenuItem1.Name = "вычитаниеToolStripMenuItem1";
            this.вычитаниеToolStripMenuItem1.Size = new System.Drawing.Size(248, 22);
            this.вычитаниеToolStripMenuItem1.Text = "Вычитание";
            this.вычитаниеToolStripMenuItem1.Click += new System.EventHandler(this.вычитаниеToolStripMenuItem1_Click);
            // 
            // сравнениеАВToolStripMenuItem
            // 
            this.сравнениеАВToolStripMenuItem.Name = "сравнениеАВToolStripMenuItem";
            this.сравнениеАВToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.сравнениеАВToolStripMenuItem.Text = "Сравнение А=В";
            this.сравнениеАВToolStripMenuItem.Click += new System.EventHandler(this.сравнениеАВToolStripMenuItem_Click);
            // 
            // аСодержитсяВВToolStripMenuItem
            // 
            this.аСодержитсяВВToolStripMenuItem.Name = "аСодержитсяВВToolStripMenuItem";
            this.аСодержитсяВВToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.аСодержитсяВВToolStripMenuItem.Text = "А содержится в В";
            this.аСодержитсяВВToolStripMenuItem.Click += new System.EventHandler(this.аСодержитсяВВToolStripMenuItem_Click);
            // 
            // вСодержитсяВАToolStripMenuItem
            // 
            this.вСодержитсяВАToolStripMenuItem.Name = "вСодержитсяВАToolStripMenuItem";
            this.вСодержитсяВАToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.вСодержитсяВАToolStripMenuItem.Text = "В содержится в А";
            this.вСодержитсяВАToolStripMenuItem.Click += new System.EventHandler(this.вСодержитсяВАToolStripMenuItem_Click);
            // 
            // принадлежностьЭлтаМнвуАToolStripMenuItem
            // 
            this.принадлежностьЭлтаМнвуАToolStripMenuItem.Name = "принадлежностьЭлтаМнвуАToolStripMenuItem";
            this.принадлежностьЭлтаМнвуАToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.принадлежностьЭлтаМнвуАToolStripMenuItem.Text = "Принадлежность эл-та мн-ву А";
            this.принадлежностьЭлтаМнвуАToolStripMenuItem.Click += new System.EventHandler(this.принадлежностьЭлтаМнвуАToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // иДЗToolStripMenuItem
            // 
            this.иДЗToolStripMenuItem.Name = "иДЗToolStripMenuItem";
            this.иДЗToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.иДЗToolStripMenuItem.Text = "ИДЗ";
            this.иДЗToolStripMenuItem.Click += new System.EventHandler(this.иДЗToolStripMenuItem_Click);
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(49, 61);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(125, 20);
            this.textBoxA.TabIndex = 2;
            this.textBoxA.Text = "4 5 3 6 ";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(243, 61);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(125, 20);
            this.textBoxB.TabIndex = 3;
            this.textBoxB.Text = "4 3 6 8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите можество А";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите множество В";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(128, 235);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(59, 13);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "Результат";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(421, 293);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.menuStripOperation);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sets PR10";
            this.menuStripOperation.ResumeLayout(false);
            this.menuStripOperation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripOperation;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOperation;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem объединениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пересечениеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вычитаниеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem иДЗToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сравнениеАВToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аСодержитсяВВToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вСодержитсяВАToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem принадлежностьЭлтаМнвуАToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button button1;
    }
}

