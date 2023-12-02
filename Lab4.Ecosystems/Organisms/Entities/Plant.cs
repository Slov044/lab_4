using Lab4.Ecosystems.Organisms.Abstraction;

namespace Lab4.Ecosystems.Organisms.Entities;

public class Plant : LivingOrganism, IReproducible, IPredator
{
    public string SeasonCharacter;

    public bool CanPredator()
    {
        return Energy <= 1500;
    }

    public void Hunt(LivingOrganism organism)
    {
        switch (organism)
        {
            case Microorganism microorganism:
            {
                HuntMicroorganism(microorganism);
                break;
            }
        }
    }

    public bool CanReproducible()
    {
        return Energy <= 500;
    }

    public LivingOrganism? Reproduce()
    {
        if (!CanReproducible())
            return null;

        var energy = Energy * 0.2;
        Energy -= energy * 1.1;
        return new Plant
        {
            Energy = energy,
            Size = Random.Shared.Next(3, 5),
            Age = 23,
            SeasonCharacter = SeasonCharacter
        };
    }

    private void HuntMicroorganism(Microorganism microorganism)
    {
        var takedEnergy = 150 + Random.Shared.Next(-15, 15);
        microorganism.Energy -= takedEnergy * 1.05;
        Energy += takedEnergy;
    }
}