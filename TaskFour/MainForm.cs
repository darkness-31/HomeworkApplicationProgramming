using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Data.SQLite;

namespace TaskFour
{
    public partial class MainForm : Form
    {
        public MainForm() => InitializeComponent();

        private void ButtonConvertor_Click(object sender, EventArgs e)
        {
            string json = string.Empty;
            
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text file|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                json = sr.ReadToEnd();
                sr.Close();
            }
            ofd.Dispose();

            var request = JArray.Parse(json).Select(x => new
            {
                kWh180 = (double)x["1.8.0*kWh"],
                kVARh380 = (int)x["3.8.0*kVARh"],
                kVARh480 = (int)x["4.8.0*kVARh"],
                kVARh1780 = (int)x["17.8.0*kVARh"],
                kVARh1880 = (int)x["18.8.0*kVARh"],
                ZeroNineFore = (DateTime)x["0.9.4"],
                ZeroTwoZero = (string)x["0.2.0"],
                ZeroTwoOne = (string)x["0.2.1"],
                C16 = (string)x["C.1.6"],
                C17 = (string)x["C.1.7"],
                NineNineNine = (int)x["9.9.9"]
            }).ToList();

            if (!File.Exists(Environment.CurrentDirectory + @"\source.sqlite"))
            {
                SQLiteConnection.CreateFile("source.sqlite");
            }

            string connectionString = "Data source=source.sqlite;Version=3";
            SQLiteConnection DataBase = new SQLiteConnection(connectionString);
            DataBase.Open();

            string sql = "CREATE TABLE IF NOT EXISTS electronik (" +
                "kWh180 string," +
                "kVARh380 int," +
                "kVARh480 int," +
                "kVARh1780 int," +
                "kVARh1880 int," +
                "ZeroNineFore DateTime," +
                "ZeroTwoZero string," +
                "ZeroTwoOne string," +
                "C16 string," +
                "C17 string," +
                "NineNineNine int)";
            new SQLiteCommand(sql, DataBase).ExecuteNonQuery();

            sql = "INSERT INTO electronik (kWh180, kVARh380, kVARh480, kVARh1780, kVARh1880, ZeroNineFore, ZeroTwoZero, ZeroTwoOne, C16, C17, NineNineNine) " +
                "VALUES ";
            request.ForEach(x =>
            {
                sql += $"({x.kWh180.ToString().Replace(',','.')}, {x.kVARh380}, {x.kVARh480}, {x.kVARh1780}, {x.kVARh1880}, \"{ x.ZeroNineFore.ToString()}\", \"{x.ZeroTwoZero}\", \"{x.ZeroTwoOne}\", \"{x.C16}\", \"{x.C17}\", {x.NineNineNine}),";
            });
            new SQLiteCommand(sql.TrimEnd(','), DataBase).ExecuteNonQuery();
            DataBase.Close();
        }
    }
}
