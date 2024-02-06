using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperheroSocialClub.RepositoryPattern;
namespace SuperheroSocialClub.Pages.Superhero;

public class EditModel : PageModel
{
    private readonly RepositoryPatternHero _repository;
    [BindProperty]
    public Models.Superhero Superhero { get; set; }
    public int SuperheroId { get; set; }

    public EditModel(RepositoryPatternHero repository)
    {
        _repository = repository;
    }

    public void OnGet(int id)
    {
        SuperheroId = id;
        Superhero = RepositoryPatternHero.GetSuperheroById(id);

    }


    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        _repository.UpdateSuperhero(Superhero);
        return RedirectToPage("/Superhero/Details", new { id = Superhero.Id });
    }

}