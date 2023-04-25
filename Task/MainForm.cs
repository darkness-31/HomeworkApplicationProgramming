using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public partial class MainForm : Form
    {
        string _PathCountry = Environment.CurrentDirectory + @"\country.xml";
        string _PathPerson = Environment.CurrentDirectory + @"\person.xml";

        public MainForm() => InitializeComponent();
        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            if (ComboBox.Text.Equals("Люди"))
                DataGrid.DataSource = new Data.PersonGrid().Get(_PathPerson);
            else if (ComboBox.Text.Equals("Города"))
                DataGrid.DataSource = new Data.CountryGrid().Get(_PathCountry);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (ComboBox.Text.Equals("Люди"))
                new Data.PersonGrid().Set(DataGrid.DataSource, _PathPerson);
            else if (ComboBox.Text.Equals("Города"))
                new Data.CountryGrid().Set(DataGrid.DataSource, _PathCountry);
        }
    }
}
