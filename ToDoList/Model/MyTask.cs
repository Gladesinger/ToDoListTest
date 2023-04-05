using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class MyTask
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Description { get; set; }
        public DateOnly DateOfTask { get; set; }
        public bool IsActive { get; set; }

        public MyTask()
        { }

        public MyTask(DateOnly? dateOfTask = null, string name = "", string description = "", bool isActive = true)
        {
            if (dateOfTask is null)
                DateOfTask = DateOnly.FromDateTime(DateTime.Now);
            else
                DateOfTask = (DateOnly)dateOfTask;

            Name = name;
            Description = description;
            IsActive = isActive;
        }
    }
}
