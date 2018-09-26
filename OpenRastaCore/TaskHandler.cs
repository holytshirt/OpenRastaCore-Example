using System.Collections.Generic;

namespace BasicOpenRastaSite
{
    public class TaskHandler
    {
        public IEnumerable<TaskItem> Get()
        {
            return new[] {new TaskItem(1, "Title 1"), new TaskItem(2, "Title 2")};
        }
    }
}