using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };


            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> anotherPlanetList = new List<string>() { "Uranus", "Neptune" };
            planetList.AddRange(anotherPlanetList);
            planetList.Insert(1, "Earth");
            planetList.Insert(1, "Venus");
            planetList.Add("Pluto");
            List<string> rockyPlanets = planetList.GetRange(0 , 4);
            planetList.Remove("Pluto");
        }
    }
}
