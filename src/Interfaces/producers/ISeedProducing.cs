namespace Trestlebridge.Interfaces
{
    public interface ISeedProducing
    {
        double Harvest();
        string Name { get; }
    }
}