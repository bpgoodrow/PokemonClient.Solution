using System.Collections.Generic;
using System;
using System.Collections;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PokemonClient.Models
{
  public class PokemonResponse
  {
    public int Pages { get; set; }
    public int CurrentPage { get; set; }

    public static List<PokemonResponse> GetPokemonResponse()
  {
    var apiCallTask = ApiHelper.GetAll();
    var result = apiCallTask.Result;
    JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
    List<PokemonResponse> pokemonResponseList = JsonConvert.DeserializeObject<List<PokemonResponse>>(jsonResponse.ToString());
    return pokemonResponseList;
  }
  }
}