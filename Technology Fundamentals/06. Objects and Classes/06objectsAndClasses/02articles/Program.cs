using System;

namespace _02articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            int n = int.Parse(Console.ReadLine());
            Article article = new Article();

            article.Title = input[0];
            article.Content = input[1];
            article.Author = input[2];

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(": ");

                if (command[0] == "Edit")
                {
                    article.Edit(command[1]);
                }
                else if (command[0] == "ChangeAuthor")
                {
                    article.changeAuthor(command[1]);
                }
                else if (command[0] == "Rename")
                {
                    article.changeTitle(command[1]);
                }
            }
            Console.WriteLine(article.ToString());

        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }

        public void Edit(string newContent)
        {
            Content = newContent;
        }
        public void changeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void changeTitle(string newTitle)
        {
            Title = newTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
