namespace Lab4.Ecosystems.Organisms.Abstraction;

public interface IPredator
{
    bool CanPredator();
    void Hunt(LivingOrganism organism);
}