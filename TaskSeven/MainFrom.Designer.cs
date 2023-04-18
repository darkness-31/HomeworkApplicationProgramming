namespace TaskSeven
{
    partial class MainFrom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TestingGridView = new System.Windows.Forms.DataGridView();
            this.StartButton = new System.Windows.Forms.Button();
            this.CheckButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TestingGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TestingGridView
            // 
            this.TestingGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TestingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TestingGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.TestingGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.TestingGridView.Location = new System.Drawing.Point(0, 0);
            this.TestingGridView.Name = "TestingGridView";
            this.TestingGridView.Size = new System.Drawing.Size(800, 409);
            this.TestingGridView.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(13, 415);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(216, 23);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Начать тестирование";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(642, 415);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(146, 23);
            this.CheckButton.TabIndex = 1;
            this.CheckButton.Text = "Проверка";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.TestingGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainFrom";
            this.Text = "Тестирование";
            ((System.ComponentModel.ISupportInitialize)(this.TestingGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TestingGridView;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button CheckButton;
    }
}

