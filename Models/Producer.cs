using System.ComponentModel.DataAnnotations;

namespace DeckArchief.Models
{
    public class Producer
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Adress { get; set; }
        public string? Brands { get; set; }
        
    }
}
