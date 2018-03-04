using System;
using System.Collections.Generic;
using System.Text;


public class Book
{
    private const int MIN_LENGHT = 3;

    private string title;
    private string author;
    private decimal price;

    public Book(string author, string title, decimal price)
    {
        this.Title = title;
        this.Author = author;
        this.Price = price;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Type: {this.GetType().Name}");
        sb.AppendLine($"Title: {this.Title}");
        sb.AppendLine($"Author: {this.Author}");
        sb.AppendLine($"Price: {this.Price:f2}");

        return sb.ToString().TrimEnd();
    }

    public virtual decimal Price
    {
        get { return this.price; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price not valid!");
            }
            price = value;
        }
    }

    public string Author
    {
        get { return this.author; }
        protected set
        {
            var isDigit = value.IndexOf(' ');
            if (char.IsDigit(value[isDigit + 1]))
            {
                throw new ArgumentException("Author not valid!");
            }

            this.author = value;
        }
    }

    public string Title
    {
        get { return this.title; }
        set
        {
            if (value.Length < MIN_LENGHT || string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Title not valid!");
            }
            title = value;
        }
    }

}

