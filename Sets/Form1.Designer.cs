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
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            this.menuStripOperation.Size = new System.Drawing.Size(365, 24);
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(46, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(272, 225);
            this.listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(365, 294);
            this.Controls.Add(this.listBox1);
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
        private System.Windows.Forms.ListBox listBox1;
    }
}

