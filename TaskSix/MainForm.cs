using System;
using System.Windows.Forms;
using TaskFour;

namespace TaskSix
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SQLite.CheckConnect();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxView.Text))
                return;

            var sql = "INSERT INTO notebook ( description, date ) " +
                     $"VALUES ('{TextBoxView.Text}',{((DateTimeOffset)DateTimePickerOne.Value.ToUniversalTime()).ToUnixTimeSeconds()})";
            sql.SQLNonQuery();
        }

        private void ButtonView_Click(object sender, EventArgs e)
        {
            var currentDate = ((DateTimeOffset)DateTimePickerTwo.Value.ToUniversalTime()).ToUnixTimeSeconds();
            var sql = "SELECT description " +
                "FROM notebook " +
                $"WHERE date = {currentDate}";
            TextBoxView.Text = sql.SQLNonQueryAsString();
        }
    }
}
