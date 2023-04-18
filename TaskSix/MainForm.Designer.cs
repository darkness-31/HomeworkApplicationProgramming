namespace TaskSix
{
    partial class MainForm
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
            this.TextBoxView = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonView = new System.Windows.Forms.Button();
            this.DateTimePickerOne = new System.Windows.Forms.DateTimePicker();
            this.DateTimePickerTwo = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // TextBoxView
            // 
            this.TextBoxView.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBoxView.Location = new System.Drawing.Point(0, 0);
            this.TextBoxView.Multiline = true;
            this.TextBoxView.Name = "TextBoxView";
            this.TextBoxView.Size = new System.Drawing.Size(444, 269);
            this.TextBoxView.TabIndex = 0;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(357, 278);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 3;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonView
            // 
            this.ButtonView.Location = new System.Drawing.Point(357, 304);
            this.ButtonView.Name = "ButtonView";
            this.ButtonView.Size = new System.Drawing.Size(75, 23);
            this.ButtonView.TabIndex = 3;
            this.ButtonView.Text = "Отобразить";
            this.ButtonView.UseVisualStyleBackColor = true;
            this.ButtonView.Click += new System.EventHandler(this.ButtonView_Click);
            // 
            // DateTimePickerOne
            // 
            this.DateTimePickerOne.Location = new System.Drawing.Point(12, 278);
            this.DateTimePickerOne.Name = "DateTimePickerOne";
            this.DateTimePickerOne.Size = new System.Drawing.Size(339, 20);
            this.DateTimePickerOne.TabIndex = 4;
            // 
            // DateTimePickerTwo
            // 
            this.DateTimePickerTwo.Location = new System.Drawing.Point(12, 304);
            this.DateTimePickerTwo.Name = "DateTimePickerTwo";
            this.DateTimePickerTwo.Size = new System.Drawing.Size(339, 20);
            this.DateTimePickerTwo.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 336);
            this.Controls.Add(this.DateTimePickerTwo);
            this.Controls.Add(this.DateTimePickerOne);
            this.Controls.Add(this.ButtonView);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.TextBoxView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Записная книжка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxView;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonView;
        private System.Windows.Forms.DateTimePicker DateTimePickerOne;
        private System.Windows.Forms.DateTimePicker DateTimePickerTwo;
    }
}

