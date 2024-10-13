using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace DeckArchief.Models
{
    public class Deck
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Series {  get; set; }
        public double Price { get; set; }
        public string? BrandName { get; set; }
        public string? ProducerName { get; set; }
        public string? Designer { get; set; }
        public string? Color { get; set; }
        public double CurrentValue1 { get; set; }

        //public int? CollectionId { get; set; }
        //public Collection? Collection { get; set; }
    }
}
