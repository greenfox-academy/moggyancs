﻿namespace ToDoApp.Models
{
    public class ToDo
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public bool IsUrgent { get; set; }
        public bool IsDone { get; set; }

        public ToDo(string title, bool isUrgent)
        {
            Title = title;
            IsUrgent = isUrgent;
            IsDone = false;
        }
    }
}
