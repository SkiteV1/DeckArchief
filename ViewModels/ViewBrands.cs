using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DeckArchief.ViewModels
{
    public class ViewBrands
    {
        [DisplayName("Id")]
        public int Id { get; set; }
        [DisplayName("Name")]
        public string? Name { get; set; }
        [DisplayName("Adress")]
        public string? Adress { get; set; }
        [DisplayName("Producer")]
        public string? ProducerName { get; set; }
    }
}
