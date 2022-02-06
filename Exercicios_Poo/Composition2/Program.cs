using System;
using Composition2.Entites;

namespace Composition2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Moment: ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.Write("Content: ");
            string cont = Console.ReadLine();

            Console.Write("Likes: ");
            int likes = int.Parse(Console.ReadLine());

            Post post1 = new Post(date,title,cont,likes);

            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that´s awesome!");

            post1.AddComment(c1);
            post1.AddComment(c2);


            //---------------------------------------------

            Console.Write("Title: ");
            string title2 = Console.ReadLine();

            Console.Write("Moment: ");
            DateTime date2 = DateTime.Parse(Console.ReadLine());

            Console.Write("Content: ");
            string cont2 = Console.ReadLine();

            Console.Write("Likes: ");
            int likes2 = int.Parse(Console.ReadLine());

            Post post2 = new Post(date2, title2, cont2, likes2);

            Comment c3 = new Comment("Good night guys");
            Comment c4 = new Comment("See you tomorrow");

            post2.AddComment(c3);
            post2.AddComment(c4);

            Console.WriteLine(post1);
            Console.WriteLine(post2);

        }
    }
}
