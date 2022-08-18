using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PokemonClient.Models;

namespace PokemonClient.Controllers
{
  public class PokemonsController : Controller
  {
    public IActionResult Index()
    {
      var allPokemons = Pokemon.GetPokemons();
      return View(allPokemons);
    }


    public IActionResult Edit(int id)
    {
      var pokemon = Pokemon.GetDetails(id);
      return View(pokemon);
    }

    public IActionResult Details(int id)
    {
      var pokemon = Pokemon.GetDetails(id);
      return View(pokemon);
    }

    [HttpPost]
    public IActionResult Details(int id, Pokemon pokemon)
    {
      pokemon.PokemonId = id;
      Pokemon.Put(pokemon);
      return RedirectToAction("Details", id);
    }

    public IActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Create(Pokemon pokemon)
    {
      Pokemon.Post(pokemon);
      return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
      Pokemon.Delete(id);
      return RedirectToAction("Index");
    }

     public IActionResult Page(PokemonResponse pokemonResponse)
    {
      var pokemonPages = PokemonResponse.GetPokemonResponse();
      return View(pokemonPages);
    }
  }
}