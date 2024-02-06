using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperheroSocialClub.Database;

namespace SuperheroSocialClub.Pages.Superhero
{
	public class IndexModel : PageModel
	{
		public List<Models.Superhero>? AllSuperheroes { get; set; }
		public void OnGet()
		{
			AllSuperheroes = SuperheroRepo.Superheroes;
		}
	}
}
