using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTwo
{
    public partial class RandomScheme : Form
    {
        public RandomScheme()
        {
            InitializeComponent();
        }

        private void ButtonLoadLesson_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text file (*.txt)|*.txt";
            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog.FileName);
                TextBoxInputLesson.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void ButtonSaveLesson_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.Create(saveFileDialog.FileName).Close();
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                sw.WriteLine(TextBoxInputLesson.Text);
                sw.Close();
            }
        }

        private void ButtonCreateLesson_Click(object sender, EventArgs e)
        {
            try
            {
                string[] items = TextBoxInputLesson.Text.Replace('\r',' ').Split('\n').Where(x => !string.IsNullOrEmpty(x)).ToArray();
                Lesson[] lessons = new Lesson[items.Length];
                Schedule schedule = new Schedule();

                for (int i = 0; i < items.Length; i++)
                {
                    if (string.IsNullOrEmpty(items[i]))
                        continue;
                    var item = items[i].Split(' ').Where(x => x.Length != 0).ToArray();
                    lessons[i] = schedule.ArrayToLesson(item);    
                }

                string[,] scheduleMatrix = schedule.Create(lessons);
                TextBoxOutputLesson.Text = schedule.From(scheduleMatrix);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
