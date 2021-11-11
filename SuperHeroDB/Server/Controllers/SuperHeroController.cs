using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroDB.Server.Services;
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

        private readonly ISuperHeroSer _superhero;

        
        public SuperHeroController(ISuperHeroSer SuperHeroRef)
        {
            _superhero = SuperHeroRef;
        }

        

        [HttpGet("comics")]
        public async Task<IActionResult> GetComics()
        {
            return Ok(_superhero.AccessComic());
        }

        [HttpGet]
        public async Task<IActionResult> GetSuperHeroes()
        {
            return Ok(_superhero.AccessSuperHeroes());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingleSuperHero(int id)
        {
            var hero = _superhero.AccessSuperHeroes().FirstOrDefault(h => h.Id == id);
            if(hero == null)
            {
                return NotFound("Super Hero Wasn't Found..");
            }
            return Ok(hero);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSuperHero(SuperHero hero)
        {
            hero.Id = _superhero.AccessSuperHeroes().Max(h => h.Id + 1);
            _superhero.AccessSuperHeroes().Add(hero);
            return Ok(_superhero.AccessSuperHeroes());
        }

    }
}
