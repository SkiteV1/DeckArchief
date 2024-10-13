using System.ComponentModel.DataAnnotations;

namespace DeckArchief.Models
{
    public class Wishlist
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        
        
    }
}
