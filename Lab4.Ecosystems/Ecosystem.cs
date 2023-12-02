using Lab4.Ecosystems.Organisms.Abstraction;
using Lab4.Ecosystems.Organisms.Entities;
using Lab4.Ecosystems.Organisms.Enums;

namespace Lab4.Ecosystems;

public class Ecosystem
{
    public readonly List<LivingOrganism> LivingOrganisms = new();

    public Ecosystem()
    {
        LivingOrganisms.Add(new Plant
        {
            Age = 12,
            Energy = 244,
            SeasonCharacter = "Every year",
            Size = 12
        });
        LivingOrganisms.Add(new Plant
        {
            Age = 12,
            Energy = 400,
            SeasonCharacter = "Every year",
            Size = 11
        });
        LivingOrganisms.Add(new Microorganism
        {
            Age = 12,
            Energy = 500,
            Size = 4,
            CellType = CellType.Multicellular,
            NutritionType = NutritionType.Autotrophic
        });
        LivingOrganisms.Add(new Microorganism
        {
            Age = 12,
            Energy = 300,
            Size = 4
        });
        LivingOrganisms.Add(new Animal
        {
            Age = 12,
            Energy = 1200,
            Size = 4,
            EyeColor = "Red",
            MainColor = "Blue"
        });
    }

    public void Modulate()
    {
        while (LivingOrganisms.Count > 1)
        {
            var organisms = LivingOrganisms.ToArray();
            foreach (var activeOrganism in organisms.Where(o => o.Energy > 0))
            {
                if (activeOrganism is IPredator predator && predator.CanPredator())
                    foreach (var victim in organisms.Where(o => o.Energy > 0 && o != activeOrganism))
                    {
                        predator.Hunt(victim);
                        Console.WriteLine($"{activeOrganism,-40} Hunts {victim,-40}");
                    }

                if (activeOrganism is IReproducible reproducible && reproducible.CanReproducible())
                {
                    var baby = reproducible.Reproduce();

                    if (baby is not null)
                    {
                        LivingOrganisms.Add(baby);
                        Console.WriteLine($"{activeOrganism,-40} gave birth {baby,-40}");
                    }
                }
            }

            LivingOrganisms.RemoveAll(p => p.Energy <= 0);
        }


        Console.WriteLine($"Only {LivingOrganisms[0]} survived");
    }
}