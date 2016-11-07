using System;

namespace News.Controllers
{
    internal class BlogArticle
    {
        public BlogArticle()
        {
        }

        public object Body { get; internal set; }
        public DateTime DateCreated { get; internal set; }
        public object Subject { get; internal set; }
    }
}