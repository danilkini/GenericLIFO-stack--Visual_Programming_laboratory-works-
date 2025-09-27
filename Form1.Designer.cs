namespace GenericLIFO_stack_
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewItem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtItemByIndex = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstStack = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Содержимое стэка";
            // 
            // txtNewItem
            // 
            this.txtNewItem.Location = new System.Drawing.Point(456, 124);
            this.txtNewItem.Name = "txtNewItem";
            this.txtNewItem.Size = new System.Drawing.Size(83, 22);
            this.txtNewItem.TabIndex = 2;
            this.txtNewItem.TextChanged += new System.EventHandler(this.txtNewItem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Добавить элемент в начало";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(577, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 27);
            this.button2.TabIndex = 5;
            this.button2.Text = "удалить 1-й элм";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnRemoveFirst_Click);
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(456, 225);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(83, 22);
            this.txtIndex.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(578, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 25);
            this.button3.TabIndex = 7;
            this.button3.Text = "найти элемент";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnFindByIndex_Click);
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(456, 341);
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(83, 22);
            this.txtCount.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(578, 338);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 25);
            this.button4.TabIndex = 9;
            this.button4.Text = "посчитать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "индекс элемента";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "элемент по индексу";
            // 
            // txtItemByIndex
            // 
            this.txtItemByIndex.Location = new System.Drawing.Point(456, 271);
            this.txtItemByIndex.Name = "txtItemByIndex";
            this.txtItemByIndex.ReadOnly = true;
            this.txtItemByIndex.Size = new System.Drawing.Size(83, 22);
            this.txtItemByIndex.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(415, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "количество элементов";
            // 
            // lstStack
            // 
            this.lstStack.FormattingEnabled = true;
            this.lstStack.ItemHeight = 16;
            this.lstStack.Location = new System.Drawing.Point(38, 95);
            this.lstStack.Name = "lstStack";
            this.lstStack.Size = new System.Drawing.Size(342, 356);
            this.lstStack.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 504);
            this.Controls.Add(this.lstStack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtItemByIndex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewItem);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtItemByIndex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstStack;
    }
}

