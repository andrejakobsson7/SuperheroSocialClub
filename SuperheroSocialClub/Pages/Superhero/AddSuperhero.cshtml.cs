using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperheroSocialClub.Database;

namespace SuperheroSocialClub.Pages.Superhero
{

	public class AddSuperheroModel : PageModel
	{
		public int Id { get; set; }
		[BindProperty]
		public IFormFile Image { get; set; }
		[BindProperty]
		public string Name { get; set; }
		[BindProperty]
		public string SecretIdentity { get; set; }
		[BindProperty]
		public List<string> Superpowers { get; set; }

		public void OnGet()
		{
		}
		public async void OnPost()
		{
			Models.Superhero newSuperhero = new()
			{
				Id = SuperheroRepo.Superheroes.Count + 1,
				Name = Name,
				SecretIdentity = SecretIdentity,
				Superpowers = Superpowers
			};

			if (Image != null && Image.Length > 0)
			{
				string fileName = Path.GetFileName(Image.FileName);
				string destinationFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images");
				string filePath = Path.Combine(destinationFolder, fileName);
				using (var stream = new FileStream(filePath, FileMode.Create))
				{
					await Image.CopyToAsync(stream);
				}

				newSuperhero.Image = fileName;
			}
			SuperheroRepo.AddSuperhero(newSuperhero);
		}
	}
}
