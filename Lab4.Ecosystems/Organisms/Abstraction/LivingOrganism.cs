namespace Lab4.Ecosystems.Organisms.Abstraction;

public class LivingOrganism
{
    public int Age;
    public double Energy;
    public double Size;

    public override string ToString()
    {
        return $"[{GetHashCode()}]{GetType().Name}(E{Energy:F1})";
    }
}