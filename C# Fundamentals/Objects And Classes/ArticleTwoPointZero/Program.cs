using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCmds = int.Parse(Console.ReadLine());

            List<Article> allArticles = new List<Article>();

            for (int i = 0; i < numberOfCmds; i++)
            {
                string[] startingString = Console.ReadLine().Split(", ");
                Article newArticle = new Article(startingString[0], startingString[1], startingString[2]);

                allArticles.Add(newArticle);
            }
            List<Article> sortedArticles = new List<Article>();
            string criteria = Console.ReadLine();
            if (criteria == "title")
            {
                sortedArticles = allArticles.OrderBy(x => x.Title).ToList();
            }
            else if (criteria == "content")
            {
                sortedArticles = allArticles.OrderBy(x => x.Content).ToList();
            }
            else
            {
                sortedArticles = allArticles.OrderBy(x => x.Author).ToList();
            }
            sortedArticles.ForEach(x => Console.WriteLine(x));
        }
    }
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }

}
