using System.Collections.Generic;

namespace MoviesDb.DAL
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public int CategoryId { get; set; }
        public virtual ICollection<Review> Review { get; set; }
    }
}
