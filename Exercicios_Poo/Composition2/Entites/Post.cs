using System;
using System.Collections.Generic;
using System.Text;
using Composition2.Entites;

namespace Composition2.Entites
{
    class Post
    {
        public DateTime Moment;
        public string Title;
        public string Content;
        public int Likes;
        public List<Comment> comment = new List<Comment>();

        public Post()
        {
        }

        public Post(DateTime moment,string title,string content,int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment commentt)
        {
            comment.Add(commentt);
        }

        public void RemoveComment(Comment commentt)
        {
            comment.Remove(commentt);
        }

        public override string ToString()
        {
            //Serve para fazer a motagem de strings.
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach (Comment c in comment)
            {
                sb.AppendLine(c.Text);
            }

            return sb.ToString();
        }
    }
}
