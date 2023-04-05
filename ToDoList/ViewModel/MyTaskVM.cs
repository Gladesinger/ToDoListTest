using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ToDoList.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace ToDoList.ViewModel
{
    public class MyTaskVM
    {
        public BindingList<MyTask> MyTasksList { get; set; } = new BindingList<MyTask>();

        public void AddEmpty()
        {
            MyTasksList.Add(new MyTask());
        }

        public void Add(MyTask task)
        {
            MyTasksList.Add(task);
        }

        public void Clear()
        {
            MyTasksList.Clear();
        }

        public void SaveToFIle()
        {
            string str = JsonSerializer.Serialize(MyTasksList);

            File.Delete("MyTasks.txt");
            File.AppendAllText("MyTasks.txt", str);
        }

        public void LoadFromFile()
        {
            string str = File.ReadAllText("MyTasks.txt");

            if (str != "")
            {
                var listfile = JsonSerializer.Deserialize<List<MyTask>>(str);

                foreach (var l in listfile)
                    MyTasksList.Add(l);
            }
        }
    }
}
