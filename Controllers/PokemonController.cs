using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PokedexAPI.Models;

namespace PokedexAPI.Controllers
{
    [ApiController]
    [Route("api/pokemons")]
    public class PokemonController : ControllerBase
    {
        private readonly ILogger<PokemonController> _logger;

        public PokemonController(ILogger<PokemonController> logger)
        {
            _logger = logger;
        }

        // GET: api/<PokemonController> All Pokemons in JSN File
        [HttpGet]
        public List<Pokemon> Get()
        {
            StreamReader r = new StreamReader(@"Json\PokemonJSON.json");
            string json = r.ReadToEnd();
            List<Pokemon> pokemons = JsonSerializer.Deserialize<List<Pokemon>>(json);
            return pokemons;
        }

        // GET api/<PokemonController>/5 For Id
        [HttpGet("api/pokemons/{id}")]
        public Pokemon Get(int id)
        {
            StreamReader r = new StreamReader(@"Json\PokemonJSON.json");
            string json = r.ReadToEnd();
            List<Pokemon> pokemons = JsonSerializer.Deserialize<List<Pokemon>>(json);
            var pokemon = pokemons.Where(p => p.Id == id).SingleOrDefault();
            return pokemon;
        }

    }
}