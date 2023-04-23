using System.Data;
using System.Xml.Serialization;
using TaskEight.Data;

namespace EditorXML
{
    public partial class MainForm : Form
    {
        string _Path = Environment.CurrentDirectory + @"\e.xml";

        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlSer = new XmlSerializer(typeof(Person[]));
            FileStream fs = new FileStream(_Path, FileMode.OpenOrCreate);
            Person[]? persons = xmlSer.Deserialize(fs) as Person[];
            fs.Close();
            DataGrid.DataSource = persons;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlSer = new XmlSerializer(typeof(Person[]));
            FileStream fs = new FileStream(_Path, FileMode.OpenOrCreate);
            Person[] persons = DataGrid.DataSource as Person[];
            xmlSer.Serialize(fs, persons);
            fs.Close();
        }
    }
}