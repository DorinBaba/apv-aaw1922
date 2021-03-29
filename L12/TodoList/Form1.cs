using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoList
{
    public partial class Form1 : Form
    {
        class Todo
        {
            public string Task { get; set; }
            public DateTime Date { get; set; }
        }

        public DataTable Todos { get; set; } = new DataTable();
        public string FilePath { get; set; }

        public Form1()
        {
            InitializeComponent();
            Todos.Columns.Add("Task", typeof(string));
            Todos.Columns.Add("Date", typeof(DateTime));

            dgvTodos.DataSource = Todos;
        }

        private void AddToDo(string task, DateTime date)
        {
            var todo = new Todo
            {
                Date = date,
                Task = task
            };

            AddToDo(todo);
        }

        private void AddToDo(Todo todo)
        {
            DataRow row = Todos.NewRow();
            row[0] = todo.Task;
            row[1] = todo.Date;
            Todos.Rows.Add(row);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string task = tbTask.Text;
            DateTime date = dtpDate.Value.Date + dtpTime.Value.TimeOfDay;
            AddToDo(task, date);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Todos.Clear();
            FilePath = null;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(FilePath == null)
            {
                SaveAs();
                return;
            }

            Save();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        public void SaveAs()
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "XML Files | *.xml";
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = fileDialog.FileName;
                Save();
            }
        }

        public void Save()
        {
            var dataset = new DataSet();
            dataset.Tables.Add(Todos.Copy());
            dataset.WriteXml(FilePath);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "XML Files | *.xml";

            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = fileDialog.FileName;

                var ds = new DataSet();
                ds.ReadXml(FilePath);

                if(ds.Tables.Count > 0)
                {
                    Todos.Clear();

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        AddToDo(row[0].ToString(), DateTime.Parse(row[1].ToString()));
                    }
                }
            }
        }
    }
}
