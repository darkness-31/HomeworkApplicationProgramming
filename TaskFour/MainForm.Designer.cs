namespace TaskFour
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
            this.ButtonConvertor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonConvertor
            // 
            this.ButtonConvertor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonConvertor.Location = new System.Drawing.Point(0, 0);
            this.ButtonConvertor.Name = "ButtonConvertor";
            this.ButtonConvertor.Size = new System.Drawing.Size(289, 100);
            this.ButtonConvertor.TabIndex = 0;
            this.ButtonConvertor.Text = "СКОМПИЛИРОВАТЬ";
            this.ButtonConvertor.UseVisualStyleBackColor = true;
            this.ButtonConvertor.Click += new System.EventHandler(this.ButtonConvertor_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 100);
            this.Controls.Add(this.ButtonConvertor);
            this.Name = "MainForm";
            this.Text = "Конвертор из JSON в SQLITE";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonConvertor;
    }
}

