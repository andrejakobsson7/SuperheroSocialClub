using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperheroSocialClub.Database;
using SuperheroSocialClub.RepositoryPattern;
namespace SuperheroSocialClub.Pages.Superhero
{
    public class DetailsModel : PageModel
    {
        private readonly RepositoryPatternHero _repository;
        public List<Models.Superhero> Superheros { get; set; }

        // En contructor som tar emot och instansiear _repository
        public DetailsModel(RepositoryPatternHero repository)
        {
            _repository = repository;
        }
        public void OnGet()
        {
            Superheros = SuperheroRepo.Superheroes;
        }
        public IActionResult OnPost(int id)
        {
            // Hämta metoden från Repo hero.
            _repository.DeleteSuperhero(id);
            return RedirectToPage("./Details");
        }
    }
}