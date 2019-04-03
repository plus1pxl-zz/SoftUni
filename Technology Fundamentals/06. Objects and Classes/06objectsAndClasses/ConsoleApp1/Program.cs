using System;
using System.Collections.Generic;
using System.Linq;

namespace _02articles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(", ");

                string title = command[0];
                string content = command[1];
                string author = command[2];

                Article article = new Article()
                {
                    Title = title,
                    Content = content,
                    Author = author
                };
                articles.Add(article);
            }

            string orderBy = Console.ReadLine();
            if (orderBy == "title")
            {
                articles = articles.OrderBy(x => x.Title)
                    .ToList();
            }
            else if (orderBy == "content")
            {
                articles = articles.OrderBy(x => x.Content)
                     .ToList();
            }
            else if (orderBy == "author")
            {
                articles = articles.OrderBy(x => x.Author)
                    .ToList();
            }

            Console.WriteLine(string.Join(Environment.NewLine, articles));


        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
