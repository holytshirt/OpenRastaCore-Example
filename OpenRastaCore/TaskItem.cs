namespace BasicOpenRastaSite
{
    public class TaskItem
    {
        public TaskItem(int id, string title)
        {
            Id = id;
            Title = title;
        }

        public int Id { get; }
        public string Title { get; }
    }
}