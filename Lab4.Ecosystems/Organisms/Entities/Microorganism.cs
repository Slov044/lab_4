using Lab4.Ecosystems.Organisms.Abstraction;
using Lab4.Ecosystems.Organisms.Enums;

namespace Lab4.Ecosystems.Organisms.Entities;

public class Microorganism : LivingOrganism, IPredator, IReproducible
{
    public CellType CellType;
    public NutritionType NutritionType;

    public bool CanPredator()
    {
        return Energy >= 50;
    }

    public void Hunt(LivingOrganism organism)
    {
        switch (organism)
        {
            case Animal animal:
            {
                HuntAnimal(animal);
                break;
            }
            case Microorganism microorganism:
            {
                HuntMicroorganism(microorganism);
                break;
            }
        }
    }

    public bool CanReproducible()
    {
        return Energy <= 200;
    }

    public LivingOrganism? Reproduce()
    {
        if (!CanReproducible())
            return null;

        var energy = Energy * 0.4;
        Energy -= energy * 1.2;
        return new Microorganism
        {
            Energy = energy,
            Size = Random.Shared.Next(3, 5),
            Age = 23,
            CellType = CellType,
            NutritionType = NutritionType
        };
    }

    private void HuntMicroorganism(Microorganism microorganism)
    {
        var takedEnergy = 15 + Random.Shared.Next(-2, 2);
        microorganism.Energy -= takedEnergy * 1.25;
        Energy += takedEnergy;
    }

    private void HuntAnimal(Animal animal)
    {
        var takedEnergy = 300 + Random.Shared.Next(-50, 50);
        animal.Energy -= takedEnergy * 1.05;
        Energy += takedEnergy;
    }
}