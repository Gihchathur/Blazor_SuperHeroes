using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroDB.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroDB.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        static List<Comic> comics = new List<Comic>
        {
            new Comic {Id = 1, Name = "Marvel"},
            new Comic {Id = 2,  Name = "DC"}
        };

        static List<SuperHero> heroes = new List<SuperHero>
        {
            new SuperHero
            {
                Id = 1, FirstName ="Peter", LastName="Parker",HeroName ="Spider-Man",Comic = comics[0]
            },
            new SuperHero
            {
                Id = 2,FirstName ="Bruce", LastName="Wayne",HeroName ="Bat-Man",Comic = comics[1]
            },
        };

        [HttpGet("comics")]
        public async Task<IActionResult> GetComics()
        {
            return Ok(comics);
        }

        [HttpGet]
        public async Task<IActionResult> GetSuperHeroes()
        {
            return Ok(heroes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingleSuperHero(int id)
        {
            var hero = heroes.FirstOrDefault(h => h.Id == id);
            if(hero == null)
            {
                return NotFound("Super Hero Wasn't Found..");
            }
            return Ok(hero);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSuperHero(SuperHero hero)
        {
            hero.Id = heroes.Max(h => h.Id + 1);
            heroes.Add(hero);
            return Ok(heroes);
        }

    }
}
