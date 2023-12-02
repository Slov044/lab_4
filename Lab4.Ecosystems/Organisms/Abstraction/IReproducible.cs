namespace Lab4.Ecosystems.Organisms.Abstraction;

public interface IReproducible
{
    bool CanReproducible();
    LivingOrganism? Reproduce();
}