using MoviesDb.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApi.Models
{
    public class MovieRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public Category Category { get; set; }
        public virtual ICollection<Review> Review { get; set; }
    }
}
