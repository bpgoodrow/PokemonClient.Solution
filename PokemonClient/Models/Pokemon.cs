using System.Collections.Generic;
using System;
using System.Collections;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PokemonClient.Models
{
  public class Pokemon
  {
    public int PokemonId { get; set; }
    public int NationalPokedexNumber { get; set; }
    public string PokemonName { get; set; }
    public string PrimaryType { get; set; }
    public string SecondaryType { get; set; }
    public string EvolvesFrom { get; set; }
    public string EvolvesTo { get; set; }
    public string Details { get; set; } 
  

  public static List<Pokemon> GetPokemons()
  {
    var apiCallTask = ApiHelper.GetAll();
    var result = apiCallTask.Result;
    JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
    List<Pokemon> pokemonList = JsonConvert.DeserializeObject<List<Pokemon>>(jsonResponse.ToString());
    return pokemonList;
  }

  public static Pokemon GetDetails(int id)
  {
    var apiCallTask = ApiHelper.Get(id);
    var result = apiCallTask.Result;
    JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
    Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(jsonResponse.ToString());
    return pokemon;
  }

  public static void Post(Pokemon pokemon)
  {
    string jsonPokemon = JsonConvert.SerializeObject(pokemon);
    var apiCallTask = ApiHelper.Post(jsonPokemon);
  }
  public static void Put(Pokemon pokemon)
  {
    string jsonPokemon = JsonConvert.SerializeObject(pokemon);
    var apiCallTask = ApiHelper.Put(pokemon.PokemonId, jsonPokemon);
  }
  public static void Delete(int id)
  {
    var apiCallTask = ApiHelper.Delete(id);
  }
}
}