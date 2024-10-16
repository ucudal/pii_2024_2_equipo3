using System;
using System.IO;
using NUnit.Framework;

namespace Library.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }

    [Test]
    public void pokemonStatus()
    {
        string expected = "Charizard tiene 100/100 puntos de vida";
        IOutput output = new Consola();
        PokeType Fire = new PokeType("Fire", ["Ground","Water","Rock"], ["Grass","Fire","Ice","Bug","Steel","Fairy"],[]);
        PokeType Flying = new PokeType("Flying", ["Electric","Ice","Rock"], ["Grass","Fighting","Bug"], ["Ground"]);
        PokeType Normal = new PokeType("Normal", ["Fighting"], [], ["Ghost"]);
        PokeType Dragon = new PokeType("Dragon", ["Ice","Dragon","Fairy"], ["Fire","Water","Grass","Electric",], []);
        Move Ember = new Move("Ember", Fire, 40, 100);
        Move Scratch = new Move("Scratch", Normal, 35, 100);
        Move Gust = new Move("Gust", Flying, 45, 100);
        Move Twister = new Move("Twister", Dragon, 45, 100);
        Pokemon Charizard = Catalog.Instance.AddPokemon("Charizard", 100,75,52,11, Fire, Flying, Ember,Gust,Twister,Scratch);
        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);
            output.printPokemonStatus(Charizard);
            string result = sw.ToString().Trim();
            Assert.That(expected, Is.EqualTo(result));
        }
        
    }
}