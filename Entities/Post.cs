using System;

namespace DesafioSemana1.Entities
{
    public class Post
    {
        public int  Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public User User { get; set; }
    }
}
