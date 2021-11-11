using SuperHeroDB.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroDB.Server.Services
{
    public class SuperHeroSer : ISuperHeroSer
    {
        public event Action Onchange;

        static List<Comic> Comicsdata = new List<Comic>
        {
            new Comic {Id = 1, Name = "Marvel"},
            new Comic {Id = 2,  Name = "DC"}
        };

        static List<SuperHero> Heroesdata = new List<SuperHero>
        {
            new SuperHero
            {
                Id = 1, FirstName ="Peter", LastName="Parker",HeroName ="Spider-Man",Comic = Comicsdata[0]
            },
            new SuperHero
            {
                Id = 2,FirstName ="Bruce", LastName="Wayne",HeroName ="Bat-Man",Comic = Comicsdata[1]
            },
            new SuperHero
            {
                Id = 2,FirstName ="Tony", LastName="Stark",HeroName ="Iron-Man",Comic = Comicsdata[1]
            },
        };



        public List<SuperHero> AccessSuperHeroes()
        {
            return Heroesdata;
        }

        public List<Comic> AccessComic()
        {
            return Comicsdata;
        }
    }
}
