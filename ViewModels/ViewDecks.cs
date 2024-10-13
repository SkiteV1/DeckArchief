using System.ComponentModel;

namespace DeckArchief.ViewModels
{
	public class ViewDecks
	{
		[DisplayName("Id")]
		public int Id { get; set; }
		[DisplayName("Name")]
		public string? Name { get; set; }
		[DisplayName("Series")]
		public string? Series {  get; set; }
		[DisplayName("Price")]
		public double Price { get; set; }
		[DisplayName("Brand")]
		public string? BrandName { get; set; }
		[DisplayName("Producer")]
		public string? ProducerName { get; set; }
		[DisplayName("Designer")]
		public string? Designer {  get; set; }
		[DisplayName("Color")]
		public string? Color { get; set; }
		[DisplayName("Current Value")]
		public double CurrentValue1 { get; set; }
	}
}
