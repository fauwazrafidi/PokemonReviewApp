﻿using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
        Pokemon GetPokemon(int id);
        Pokemon GetPokemon(string name);
        decimal GetPokemonRating(int pokeId);
        bool PokemonExist(int pokeId);
        bool CreatePokemon (int ownerId, int categoryId, Pokemon pokemon);
        bool UpdatePokemon (int ownerId, int categoryId, Pokemon pokemon);
        bool Save();
    }
}
