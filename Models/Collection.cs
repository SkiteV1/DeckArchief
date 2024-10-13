using System.ComponentModel.DataAnnotations;

namespace DeckArchief.Models
{
    public class Collection
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public DateOnly StartDate { get; set; }
        public int TotalAmount { get; set; }
        
        //public ICollection<Deck>? Decks { get; set; }

    }
}
