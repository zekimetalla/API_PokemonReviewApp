namespace PokemonReviewApp.Models
{
    public class Review
    {
        internal int Rating;

        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public Reviewer Reviewer { get; set; }
        public Pokemon Pokemon { get; set; }
    }
}
