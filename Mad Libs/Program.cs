using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program is the mad libs game, 
      made using command lines.
      Author: Josue Oliveira
      */


      // Let the user know that the program is starting:
      Console.WriteLine("Mad Libs started!");

      // Give the Mad Lib a title:
      string title = "Mad Day";

      Console.WriteLine(title);
      // Define user input and variables:
      Console.Write("Enter a name: ");
      string name = Console.ReadLine();
      Console.Write("Enter a first adjective: ");
      string firstAdjective = Console.ReadLine();
      Console.Write("Enter a second adjective: ");
      string secondAdjective = Console.ReadLine();
      Console.Write("Enter a third adjective: ");
      string thirdAdjective = Console.ReadLine();
      Console.Write("Enter a verb: ");
      string verb = Console.ReadLine();
      Console.Write("Enter a first noun: ");
      string firstNoun = Console.ReadLine();
      Console.Write("Enter a second noun: ");
      string secondNoun = Console.ReadLine();

      Console.Write("Enter a animal: ");
      string animal = Console.ReadLine();
      Console.Write("Enter a food: ");
      string food = Console.ReadLine();
      Console.Write("Enter a fruit: ");
      string fruit = Console.ReadLine();
      Console.Write("Enter a super hero: ");
      string superHero = Console.ReadLine();
      Console.Write("Enter a country: ");
      string country = Console.ReadLine();
      Console.Write("Enter a dessert: ");
      string dessert = Console.ReadLine();
      Console.Write("Enter a year: ");
      int year = Int32.Parse(Console.ReadLine());
      

      // The template for the story:

      string story = $"This morning {name} woke up feeling {firstAdjective}. 'It is going to be a {secondAdjective} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {firstNoun}, which made all the {fruit}s very {thirdAdjective}. Concerned, {name} texted {superHero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {secondNoun}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);
    }
  }
}
