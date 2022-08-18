// using System;
// using System.Collections.Generic;
// using System.Diagnostics;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using PokemonClient.Models;

// namespace PokemonClient.Controllers
// {
//   public class PokemonResponsesController : Controller
//   {
//      public IActionResult GetPage(PokemonResponse pokemonResponse)
//     {
//       var pokemonPages = PokemonResponse.GetPokemonResponse();
//       return View(pokemonPages);
//     }
//   }
// }