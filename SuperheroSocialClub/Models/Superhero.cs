namespace SuperheroSocialClub.Models
{
	public class Superhero
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string SecretIdentity { get; set; }
		public List<string> Superpowers { get; set; } = new();
		public string Image { get; set; }

	}
}

