using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApi.DAL
{
    public class Review
    {
        public int Id { get; set; }
        public short Rate { get; set; }
        public string Comment { get; set; }

        public Movie Movie { get; set; }
    }
}
