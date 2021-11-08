using SuperHeroDB.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroDB.Client.Services
{
    public interface ISuperHeroService
    {
        event Action Onchange;
        List<Comic> Comics { get; set; }

        List<SuperHero> Heroes { get; set; }
        Task<List<SuperHero>> GetSuperHeroes();

        Task GetComic();
        Task<SuperHero> GetSuperHero(int id);

        Task<List<SuperHero>> CreateSuperHero(SuperHero hero);
    }
}
