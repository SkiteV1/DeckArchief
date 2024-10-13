using System.ComponentModel.DataAnnotations;

namespace DeckArchief.Models
{
    public class CurrentValue
    {
        public int Id { get; set; }
        [Required]
        public string? DeckName { get; set; }
        public DateOnly Date {  get; set; }
        public double Price { get; set; }
        


    }
}
