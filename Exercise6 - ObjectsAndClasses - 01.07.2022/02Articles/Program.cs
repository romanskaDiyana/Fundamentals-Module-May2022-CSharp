using System;

namespace _02Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            //02.Articles
            //Create a class Article with the following properties:
            //    • Title – a string
            //    • Content – a string
            //    • Author – a string

            //The class should have a constructor and the following methods:
            //    • Edit(new content) – change the old content with the new one
            //    • ChangeAuthor(new author) – change the author
            //    • Rename(new title) – change the title of the article
            //    • Override the ToString method – print the article in the following format: 
            //"{title} - {content}: {author}"

            //Create a program that reads an article in the following format
            //"{title}, {content}, {author}". On the next line, you will receive
            //a number n, representing the number of commands, which will follow after it.
            //On the next n lines, you will be receiving the following commands: 
            //    • "Edit: {new content}"
            //    • "ChangeAuthor: {new author}"
            //    • "Rename: {new title}"
            //In the end, print the final state of the article.


            string[] currentArticle = Console.ReadLine().Split(", ");
            var article = new Article(currentArticle[0], currentArticle[1], currentArticle[2]);

            int countOfChanges = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfChanges; i++)
            {
                string[] lines = Console.ReadLine().Split(": ");
               
                string command = lines[0];
                string argument = lines[1];

                switch (command)
                {
                    case "Edit":
                        article.Edit(argument);
                            break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(argument);
                        break;
                    case "Rename":
                        article.Rename(argument);
                        break;
                }
            }

            Console.WriteLine(article);
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


        public void Rename(string title) => Title = title;      

        public void Edit(string content) => Content = content;

        public void ChangeAuthor(string author) => Author = author;

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
