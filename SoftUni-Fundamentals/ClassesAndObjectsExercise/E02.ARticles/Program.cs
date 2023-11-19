using System;
using System.Linq;

namespace E02.Articles
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;

        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public string Edit(string newContent)
        {
            this.Content = newContent;
            return this.Content;
        }
        public string ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
            return this.Author;
        }
        public string Rename(string newTitle)
        {
            this.Title = newTitle;
            return this.Title;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] articleInfo = Console.ReadLine()
                                      .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                      .ToArray();
            Article article = new Article(articleInfo[0], articleInfo[1],articleInfo[2]);

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string[] tokens = Console.ReadLine()
                                         .Split(": ", StringSplitOptions.RemoveEmptyEntries)
                                         .ToArray();
                string command = tokens[0];
                if (command == "Edit")
                {
                    article.Edit(tokens[1]);
                }
                else if (command == "ChangeAuthor")
                {
                    article.ChangeAuthor(tokens[1]);
                }
                else if (command=="Rename")
                {
                    article.Rename(tokens[1]);
                }
            }
            Console.WriteLine(article.ToString());
        }
    }
}
