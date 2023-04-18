using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskFive
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonOpenFileOneTextBox_Click(object sender, EventArgs e) => RichTextBoxOne.Text = OpenTextFile();
        private void ButtonOpenFileTwoTextBox_Click(object sender, EventArgs e) => RichTextBoxTwo.Text = OpenTextFile();
        private string OpenTextFile()
        {
            LabelEquals.Text = string.Empty;
            RichTextBoxTwo.DeselectAll();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Textfile|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog.FileName);
                string temp = sr.ReadToEnd();
                sr.Close();
                return temp;
            }
            return string.Empty;
        }

        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            if (RichTextBoxOne.Text.Equals(RichTextBoxTwo.Text))
                LabelEquals.Text = "Равны";
            else
                LabelEquals.Text = "Не равны";

            var maxCount = RichTextBoxOne.Lines.Length > RichTextBoxTwo.Lines.Length ? RichTextBoxOne.Lines.Length : RichTextBoxTwo.Lines.Length;
            var count = 0;
            for ( int i = 0; i < maxCount; i++ )
            {
                count += RichTextBoxTwo.Lines[i].Length;
                if (!RichTextBoxOne.Lines[i].Equals(RichTextBoxTwo.Lines[i]))
                {
                    RichTextBoxTwo.Select(count, RichTextBoxTwo.Lines[i].Length + 1);
                    RichTextBoxTwo.SelectionBackColor = Color.Red;
                    break;
                } 
            }
        }
    }
}