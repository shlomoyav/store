﻿namespace Store
{
    public class Book
    {
        public int Id { get; }
        public string Title { get; set; }

        public Book(int id, string title)
        {
            Id = id;
            Title = title;
        }
    }
}