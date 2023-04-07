using System.ComponentModel;
using System.Data;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using ToDoList.Models;
using ToDoList.ViewModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        MyTaskVM tasks = new();

        public Form1()
        {
            InitializeComponent();

            ConfigureDataGridView();

            tasks.LoadFromFile();
            todolist_dataGridView.DataSource = tasks.MyTasksList;
            //aiefnIWJBNGW
            
        }

        private void addTask_button_Click(object sender, EventArgs e)
        {
            tasks.AddEmpty();
        }

        private void deleteTask_button_Click(object sender, EventArgs e)
        {
            tasks.Clear();
        }

        private void filter_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                CurrencyManager currencyManager = (CurrencyManager)BindingContext[todolist_dataGridView.DataSource];
                currencyManager.SuspendBinding();

                for (int u = 0; u < todolist_dataGridView.RowCount; u++)
                {
                    todolist_dataGridView.Rows[u].Visible = true;
                }

                for (int u = 0; u < todolist_dataGridView.RowCount; u++)
                {
                    if (todolist_dataGridView.Rows[u].Cells[0].Value?.ToString() != filter_dateTimePicker.Value.ToString("d"))
                    {
                        todolist_dataGridView.Rows[u].Visible = false;
                    }
                }

                currencyManager.ResumeBinding();
            }
            catch { }
        }

        private void todolist_dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            tasks.SaveToFIle();
        }

        private void ConfigureDataGridView()
        {
            todolist_dataGridView.AutoGenerateColumns = false;
            todolist_dataGridView.RowHeadersVisible = false;

            DataGridViewTextBoxColumn columnDate = new DataGridViewTextBoxColumn { Name = "Date", DataPropertyName = "DateOfTask", HeaderText = "Дата" };
            DataGridViewTextBoxColumn columnName = new DataGridViewTextBoxColumn { DataPropertyName = "Name", HeaderText = "Задача" };
            DataGridViewTextBoxColumn columnDescription = new DataGridViewTextBoxColumn { DataPropertyName = "Description", HeaderText = "Описание" };
            DataGridViewCheckBoxColumn columnIsActive = new DataGridViewCheckBoxColumn { DataPropertyName = "IsActive", HeaderText = "Активна" };

            todolist_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            todolist_dataGridView.Columns.AddRange(columnDate, columnName, columnDescription, columnIsActive);
        }
    }
}