namespace MoviesDb.DAL
{
    public class Review
    {
        public int Id { get; set; }
        public short Rate { get; set; }
        public string Comment { get; set; }

        public int MovieId { get; set; }
    }
}
