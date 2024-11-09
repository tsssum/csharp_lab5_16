namespace lab5_16
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.taskStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 31);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(364, 337);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(382, 31);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(386, 337);
            this.textBox2.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStripMenuItem1,
            this.openStripMenuItem2,
            this.saveStripMenuItem1,
            this.saveAsStripMenuItem1,
            this.taskStripMenuItem1,
            this.clearStripMenuItem1,
            this.exitStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newStripMenuItem1
            // 
            this.newStripMenuItem1.Name = "newStripMenuItem1";
            this.newStripMenuItem1.Size = new System.Drawing.Size(78, 24);
            this.newStripMenuItem1.Text = "&Создать";
            this.newStripMenuItem1.Click += new System.EventHandler(this.newStripMenuItem1_Click);
            // 
            // openStripMenuItem2
            // 
            this.openStripMenuItem2.Name = "openStripMenuItem2";
            this.openStripMenuItem2.Size = new System.Drawing.Size(81, 24);
            this.openStripMenuItem2.Text = "&Открыть";
            this.openStripMenuItem2.Click += new System.EventHandler(this.openStripMenuItem2_Click);
            // 
            // saveStripMenuItem1
            // 
            this.saveStripMenuItem1.Name = "saveStripMenuItem1";
            this.saveStripMenuItem1.Size = new System.Drawing.Size(97, 24);
            this.saveStripMenuItem1.Text = "&Сохранить";
            this.saveStripMenuItem1.Click += new System.EventHandler(this.saveStripMenuItem1_Click);
            // 
            // saveAsStripMenuItem1
            // 
            this.saveAsStripMenuItem1.Name = "saveAsStripMenuItem1";
            this.saveAsStripMenuItem1.Size = new System.Drawing.Size(123, 24);
            this.saveAsStripMenuItem1.Text = "&Сохранить как";
            this.saveAsStripMenuItem1.Click += new System.EventHandler(this.saveAsStripMenuItem1_Click);
            // 
            // taskStripMenuItem1
            // 
            this.taskStripMenuItem1.Name = "taskStripMenuItem1";
            this.taskStripMenuItem1.Size = new System.Drawing.Size(81, 24);
            this.taskStripMenuItem1.Text = "&Задание";
            this.taskStripMenuItem1.Click += new System.EventHandler(this.taskStripMenuItem1_Click);
            // 
            // clearStripMenuItem1
            // 
            this.clearStripMenuItem1.Name = "clearStripMenuItem1";
            this.clearStripMenuItem1.Size = new System.Drawing.Size(79, 24);
            this.clearStripMenuItem1.Text = "&Очистка";
            this.clearStripMenuItem1.Click += new System.EventHandler(this.clearStripMenuItem1_Click);
            // 
            // exitStripMenuItem1
            // 
            this.exitStripMenuItem1.Name = "exitStripMenuItem1";
            this.exitStripMenuItem1.Size = new System.Drawing.Size(67, 24);
            this.exitStripMenuItem1.Text = "&Выход";
            this.exitStripMenuItem1.Click += new System.EventHandler(this.exitStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem taskStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearStripMenuItem1;
    }
}

