using SuperHeroDB.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroDB.Server.Services
{
    public interface ISuperHeroSer
    {
        event Action Onchange;
        public List<SuperHero> AccessSuperHeroes();

        public List<Comic> AccessComic();


    }
}
