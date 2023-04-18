namespace TaskFive
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
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonOpenFileOneTextBox = new System.Windows.Forms.Button();
            this.ButtonOpenFileTwoTextBox = new System.Windows.Forms.Button();
            this.ButtonEquals = new System.Windows.Forms.Button();
            this.RichTextBoxOne = new System.Windows.Forms.RichTextBox();
            this.RichTextBoxTwo = new System.Windows.Forms.RichTextBox();
            this.LabelEquals = new System.Windows.Forms.Label();
            this.TableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.Controls.Add(this.RichTextBoxOne, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.RichTextBoxTwo, 1, 0);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 1;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(800, 392);
            this.TableLayoutPanel.TabIndex = 0;
            // 
            // ButtonOpenFileOneTextBox
            // 
            this.ButtonOpenFileOneTextBox.Location = new System.Drawing.Point(12, 398);
            this.ButtonOpenFileOneTextBox.Name = "ButtonOpenFileOneTextBox";
            this.ButtonOpenFileOneTextBox.Size = new System.Drawing.Size(75, 23);
            this.ButtonOpenFileOneTextBox.TabIndex = 1;
            this.ButtonOpenFileOneTextBox.Text = "Открыть";
            this.ButtonOpenFileOneTextBox.UseVisualStyleBackColor = true;
            this.ButtonOpenFileOneTextBox.Click += new System.EventHandler(this.ButtonOpenFileOneTextBox_Click);
            // 
            // ButtonOpenFileTwoTextBox
            // 
            this.ButtonOpenFileTwoTextBox.Location = new System.Drawing.Point(713, 398);
            this.ButtonOpenFileTwoTextBox.Name = "ButtonOpenFileTwoTextBox";
            this.ButtonOpenFileTwoTextBox.Size = new System.Drawing.Size(75, 23);
            this.ButtonOpenFileTwoTextBox.TabIndex = 1;
            this.ButtonOpenFileTwoTextBox.Text = "Открыть";
            this.ButtonOpenFileTwoTextBox.UseVisualStyleBackColor = true;
            this.ButtonOpenFileTwoTextBox.Click += new System.EventHandler(this.ButtonOpenFileTwoTextBox_Click);
            // 
            // ButtonEquals
            // 
            this.ButtonEquals.Location = new System.Drawing.Point(363, 398);
            this.ButtonEquals.Name = "ButtonEquals";
            this.ButtonEquals.Size = new System.Drawing.Size(75, 23);
            this.ButtonEquals.TabIndex = 1;
            this.ButtonEquals.Text = "Сравнение";
            this.ButtonEquals.UseVisualStyleBackColor = true;
            this.ButtonEquals.Click += new System.EventHandler(this.ButtonEquals_Click);
            // 
            // RichTextBoxOne
            // 
            this.RichTextBoxOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RichTextBoxOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBoxOne.Location = new System.Drawing.Point(3, 3);
            this.RichTextBoxOne.Name = "RichTextBoxOne";
            this.RichTextBoxOne.ReadOnly = true;
            this.RichTextBoxOne.Size = new System.Drawing.Size(394, 386);
            this.RichTextBoxOne.TabIndex = 0;
            this.RichTextBoxOne.Text = "";
            // 
            // RichTextBoxTwo
            // 
            this.RichTextBoxTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RichTextBoxTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBoxTwo.Location = new System.Drawing.Point(403, 3);
            this.RichTextBoxTwo.Name = "RichTextBoxTwo";
            this.RichTextBoxTwo.ReadOnly = true;
            this.RichTextBoxTwo.Size = new System.Drawing.Size(394, 386);
            this.RichTextBoxTwo.TabIndex = 0;
            this.RichTextBoxTwo.Text = "";
            // 
            // LabelEquals
            // 
            this.LabelEquals.AutoSize = true;
            this.LabelEquals.Location = new System.Drawing.Point(370, 436);
            this.LabelEquals.Name = "LabelEquals";
            this.LabelEquals.Size = new System.Drawing.Size(0, 13);
            this.LabelEquals.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.LabelEquals);
            this.Controls.Add(this.ButtonEquals);
            this.Controls.Add(this.ButtonOpenFileTwoTextBox);
            this.Controls.Add(this.ButtonOpenFileOneTextBox);
            this.Controls.Add(this.TableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Сравниение текста";
            this.TableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.Button ButtonOpenFileOneTextBox;
        private System.Windows.Forms.Button ButtonOpenFileTwoTextBox;
        private System.Windows.Forms.Button ButtonEquals;
        private System.Windows.Forms.RichTextBox RichTextBoxOne;
        private System.Windows.Forms.RichTextBox RichTextBoxTwo;
        private System.Windows.Forms.Label LabelEquals;
    }
}

