using System;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] startingString = Console.ReadLine().Split(", ");
            int numberOfCmds = int.Parse(Console.ReadLine());

            Article newArticle = new Article(startingString[0], startingString[1], startingString[2]);


            for (int i = 0; i < numberOfCmds; i++)
            {
                string[] input = Console.ReadLine().Split(": ");

                switch (input[0])
                {
                    case "Edit":
                        newArticle.Content = input[1];
                        break;
                    case "ChangeAuthor":
                        newArticle.Author = input[1];
                        break;
                    case "Rename":
                        newArticle.Title = input[1];
                        break;
                }
            }
            Console.WriteLine(newArticle);
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
