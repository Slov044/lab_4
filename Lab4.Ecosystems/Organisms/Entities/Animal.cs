using Lab4.Ecosystems.Organisms.Abstraction;

namespace Lab4.Ecosystems.Organisms.Entities;

public class Animal : LivingOrganism, IReproducible, IPredator
{
    public string EyeColor;
    public string MainColor;

    public bool CanPredator()
    {
        return Energy <= 2000;
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
            case Plant plant:
            {
                HuntPlant(plant);
                break;
            }
        }
    }

    public bool CanReproducible()
    {
        return Energy <= 3000;
    }

    public LivingOrganism? Reproduce()
    {
        if (!CanPredator())
            return null;

        var energy = Energy * 0.25;
        Energy -= energy * 1.05;
        return new Animal
        {
            Energy = energy,
            Size = Random.Shared.Next(3, 5),
            Age = 23,
            EyeColor = "Blue",
            MainColor = "Red"
        };
    }

    private void HuntPlant(Plant plant)
    {
        var takedEnergy = 500 + Random.Shared.Next(-12, 12);
        plant.Energy -= takedEnergy * 1.25;
        Energy += takedEnergy;
    }

    private void HuntAnimal(Animal animal)
    {
        var takedEnergy = 400 + Random.Shared.Next(-12, 12);
        animal.Energy -= takedEnergy * 2;
        Energy += takedEnergy;
    }
}