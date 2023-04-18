using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskSeven
{
    public partial class MainFrom : Form
    {
        SQLite _SQLite = new SQLite(Environment.CurrentDirectory + @"\source.sqlite");
        public MainFrom()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {

            string sql = "SELECT name " +
                         "FROM questions " +
                         "ORDER BY RANDOM() " +
                         "LIMIT 5";

            DataTable dt = _SQLite.SQLQueryAsDataTable(sql);
            dt.Columns[0].ColumnName = "Вопросы";
            dt.Columns[0].ReadOnly = true;
            dt.Columns.Add("Ответы", typeof(string));
            TestingGridView.DataSource = dt;
            TestingGridView.Columns[0].Width = 300;
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            string sql = "CREATE TABLE temp_table (name varchar, answer varchar)";
            _SQLite.SQLNonQuery(sql);

            sql = "INSERT INTO temp_table (name, answer) VALUES ";
            DataTable dt = (DataTable)TestingGridView.DataSource;
            foreach (DataRow row in dt.Rows) 
            {
                sql += string.Format("('{0}','{1}'),", row.ItemArray[0].ToString(), row.ItemArray[1].ToString().ToLower());
            }
            sql = sql.TrimEnd(',');
            _SQLite.SQLNonQuery(sql);

            sql = "SELECT q.name, " +
                         "CASE WHEN t.answer = q.answer THEN t.answer ELSE '' END AS answer " +
                "FROM temp_table AS q LEFT JOIN " +
                "questions as t ON t.name = q.name";
            TestingGridView.DataSource = _SQLite.SQLQueryAsDataTable(sql);
            TestingGridView.Columns[0].Width = 300;
            TestingGridView.Columns[0].Name = "Вопросы";
            TestingGridView.Columns[1].Name = "Ответы";

            sql = "DROP TABLE temp_table";
            _SQLite.SQLNonQuery(sql);
        }
    }
}
