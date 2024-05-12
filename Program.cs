using System.Collections.Generic;

namespace DB
{
    namespace ProtectionFaune
    {
        class Program
        {
            static void Main(string[] args)
            {
                var animals = new List<Animal>();
                var species = new List<Species>();

                species.Add(new Species { SpeciesId = 1, Name = "White Cougar", Population = 3 });
                species.Add(new Species { SpeciesId = 2, Name = "White Tiger", Population = 100 });
                species.Add(new Species { SpeciesId = 3, Name = "Albino Turtle", Population = 15 });


                animals.Add(new Animal { AnimalId = 1, Name = "Cougar", SpeciesId = 1 });
                animals.Add(new Animal { AnimalId = 2, Name = "Tiger", SpeciesId = 2 });
                animals.Add(new Animal { AnimalId = 3, Name = "Turtle", SpeciesId = 3 });
                animals.Add(new Animal { AnimalId = 4, Name = "Cougar", SpeciesId = 1 });
                animals.Add(new Animal { AnimalId = 5, Name = "Tiger", SpeciesId = 2 });
                animals.Add(new Animal { AnimalId = 6, Name = "Turtle", SpeciesId = 3 });


                foreach (var speciesItem in species)
                {
                    int animalCount = animals.Count(a => a.SpeciesId == speciesItem.SpeciesId);
                    Console.WriteLine($"Species: {speciesItem.Name} - Number of animals: {animalCount}");
                }
            }
        }
    }
}
