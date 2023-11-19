using System;
using System.Collections.Generic;
using System.Linq;

namespace E03.Articles2._0
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

        //public string Edit(string newContent)
        //{
        //    this.Content = newContent;
        //    return this.Content;
        //}
        //public string ChangeAuthor(string newAuthor)
        //{
        //    this.Author = newAuthor;
        //    return this.Author;
        //}
        //public string Rename(string newTitle)
        //{
        //    this.Title = newTitle;
        //    return this.Title;
        //}

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();
            //string[] articleInfo = Console.ReadLine()
            //                          .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            //                          .ToArray();

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string[] tokens = Console.ReadLine()
                                         .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                         .ToArray();
                string title = tokens[0];
                string content = tokens[1];
                string author = tokens[2];

                Article article = new Article(title, content, author);
                articles.Add(article);

            }
            string command = Console.ReadLine();
            if (command== "title" || command=="content" || command=="author")
            {
                foreach (Article article in articles)
                {
                    Console.WriteLine(article.ToString());
                }
            }
        }
    }
}
