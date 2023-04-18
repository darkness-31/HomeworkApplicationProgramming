namespace TaskTwo
{
    partial class RandomScheme
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
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TextBoxInputLesson = new System.Windows.Forms.TextBox();
            this.TextBoxOutputLesson = new System.Windows.Forms.TextBox();
            this.ButtonCreateLesson = new System.Windows.Forms.Button();
            this.ButtonSaveLesson = new System.Windows.Forms.Button();
            this.ButtonLoadLesson = new System.Windows.Forms.Button();
            this.TableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.Controls.Add(this.TextBoxInputLesson, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.TextBoxOutputLesson, 1, 0);
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 1;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(800, 397);
            this.TableLayoutPanel.TabIndex = 0;
            // 
            // TextBoxInputLesson
            // 
            this.TextBoxInputLesson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxInputLesson.Location = new System.Drawing.Point(3, 3);
            this.TextBoxInputLesson.Multiline = true;
            this.TextBoxInputLesson.Name = "TextBoxInputLesson";
            this.TextBoxInputLesson.Size = new System.Drawing.Size(394, 391);
            this.TextBoxInputLesson.TabIndex = 0;
            // 
            // TextBoxOutputLesson
            // 
            this.TextBoxOutputLesson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxOutputLesson.Location = new System.Drawing.Point(403, 3);
            this.TextBoxOutputLesson.Multiline = true;
            this.TextBoxOutputLesson.Name = "TextBoxOutputLesson";
            this.TextBoxOutputLesson.ReadOnly = true;
            this.TextBoxOutputLesson.Size = new System.Drawing.Size(394, 391);
            this.TextBoxOutputLesson.TabIndex = 1;
            // 
            // ButtonCreateLesson
            // 
            this.ButtonCreateLesson.Location = new System.Drawing.Point(361, 415);
            this.ButtonCreateLesson.Name = "ButtonCreateLesson";
            this.ButtonCreateLesson.Size = new System.Drawing.Size(75, 23);
            this.ButtonCreateLesson.TabIndex = 1;
            this.ButtonCreateLesson.Text = "Составить";
            this.ButtonCreateLesson.UseVisualStyleBackColor = true;
            this.ButtonCreateLesson.Click += new System.EventHandler(this.ButtonCreateLesson_Click);
            // 
            // ButtonSaveLesson
            // 
            this.ButtonSaveLesson.Location = new System.Drawing.Point(713, 415);
            this.ButtonSaveLesson.Name = "ButtonSaveLesson";
            this.ButtonSaveLesson.Size = new System.Drawing.Size(75, 23);
            this.ButtonSaveLesson.TabIndex = 2;
            this.ButtonSaveLesson.Text = "Сохранить";
            this.ButtonSaveLesson.UseVisualStyleBackColor = true;
            this.ButtonSaveLesson.Click += new System.EventHandler(this.ButtonSaveLesson_Click);
            // 
            // ButtonLoadLesson
            // 
            this.ButtonLoadLesson.Location = new System.Drawing.Point(12, 415);
            this.ButtonLoadLesson.Name = "ButtonLoadLesson";
            this.ButtonLoadLesson.Size = new System.Drawing.Size(75, 23);
            this.ButtonLoadLesson.TabIndex = 3;
            this.ButtonLoadLesson.Text = "Открыть";
            this.ButtonLoadLesson.UseVisualStyleBackColor = true;
            this.ButtonLoadLesson.Click += new System.EventHandler(this.ButtonLoadLesson_Click);
            // 
            // RandomScheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonLoadLesson);
            this.Controls.Add(this.ButtonSaveLesson);
            this.Controls.Add(this.ButtonCreateLesson);
            this.Controls.Add(this.TableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RandomScheme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Рандомайзер расписания";
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.TextBox TextBoxInputLesson;
        private System.Windows.Forms.TextBox TextBoxOutputLesson;
        private System.Windows.Forms.Button ButtonCreateLesson;
        private System.Windows.Forms.Button ButtonSaveLesson;
        private System.Windows.Forms.Button ButtonLoadLesson;
    }
}

