using SuperheroSocialClub.Database;
using SuperheroSocialClub.Models;

namespace SuperheroSocialClub.RepositoryPattern;

// Greenthhumb
public class RepositoryPatternHero
{
    private readonly List<Superhero> _superheroes;
    public RepositoryPatternHero()
    {
        _superheroes = SuperheroRepo.Superheroes;
    }
    public static Superhero GetSuperheroById(int id)
    {
        // Hämta en id för herop
        return SuperheroRepo.Superheroes.FirstOrDefault(s => s.Id == id);
    }

    public void UpdateSuperhero(Superhero superhero)
    {
        // använder metod get superhero id.
        var existingSuperhero = _superheroes.FirstOrDefault(s => s.Id == superhero.Id);

        // very interesting api
        if (existingSuperhero != null)
        {
            existingSuperhero.Name = superhero.Name;
            existingSuperhero.SecretIdentity = superhero.SecretIdentity;
            existingSuperhero.Superpowers = superhero.Superpowers;
            existingSuperhero.Image = superhero.Image;
        }
    }

    public void DeleteSuperhero(int id)
    {
        // Ta bort, hämta ID.
        var superheroToDelete = SuperheroRepo.Superheroes.FirstOrDefault(s => s.Id == id);
        if (superheroToDelete != null)
        {
            SuperheroRepo.Superheroes.Remove(superheroToDelete);
        }
    }
}
