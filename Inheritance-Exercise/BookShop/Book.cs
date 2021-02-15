using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop
{
    public class Book
    {
        private string title;
        private decimal price;
        private string author;

        public Book(string author, string title, decimal price)
        {
            this.SetTitle(title);
            this.SetAuthor(author);
            this.SetPrice(price);
        }

        public virtual string Title
        {
            get { return title; }
            protected set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                title = value;
            }
        }

        public virtual string Author
        {
            get { return author; }
            protected set
            {
                string[] names = value.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                if (names.Length > 1)
                {
                    if (char.IsDigit(names[1][0]))
                    {
                        throw new ArgumentException("Author not valid!");
                    }
                }
                this.author = value;
            }
        }

        public virtual decimal Price
        {
            get { return price; }
            protected set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Price not valid!");
                }
                price = value;
            }
        }

        private void SetAuthor(string author)
        {
            this.Author = author;
        }

        private void SetTitle(string title)
        {
            this.Title = title;
        }

        private void SetPrice(decimal price)
        {
            this.Price = price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Type: ").Append(this.GetType().Name)
                    .Append(Environment.NewLine)
                    .Append("Title: ").Append(this.Title)
                    .Append(Environment.NewLine)
                    .Append("Author: ").Append(this.Author)
                    .Append(Environment.NewLine)
                    .Append(String.Format("Price: {0:F2}", this.Price))
                    .Append(Environment.NewLine);

            return sb.ToString();
        }
    }
}
