using System;

namespace DesafioSemana1.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }
    }
}
