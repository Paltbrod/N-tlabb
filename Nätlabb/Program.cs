using System;
using System.Text.Json;
using RestSharp;

RestClient pokeClient = new RestClient("https://pokeapi.co/api/v2");

RestRequest pokeRequest = new RestRequest("pokemon/ditto");

RestResponse result = await pokeClient.GetAsync(pokeRequest);
//System.Console.WriteLine(result.StatusCode);
//System.Console.WriteLine(result.Content);

Pokemon poke = JsonSerializer.Deserialize<Pokemon>(result.Content);
System.Console.WriteLine($"Name: {poke.name} id: {poke.id}");
Console.WriteLine(poke.held_items[0].item.name);
Console.ReadLine();


