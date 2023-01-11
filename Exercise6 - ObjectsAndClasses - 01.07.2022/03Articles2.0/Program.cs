using System;
using System.Collections.Generic;

namespace _03Articles2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //03.Articles2.0
            //Change the program from the previous problem in such a way,
            //that you will be able to store a list of articles.
            //You will not need to use the previous methods anymore
            //(except the "ToString()"). On the first line, you will
            //receive the number of articles. On the next lines, you will receive the articles
            //in the same format as in the previous problem:
            //"{title}, {content}, {author}".
            //Print the articles. 

            int countOfArticles = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < countOfArticles; i++)
            {
                string[] currentArticle = Console.ReadLine().Split(", ");

                var article = new Article(currentArticle[0], currentArticle[1], currentArticle[2]);

                articles.Add(article);
            }

            string line = Console.ReadLine();

            foreach (var article in articles)
            {
                Console.WriteLine(article);
            }
     
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
