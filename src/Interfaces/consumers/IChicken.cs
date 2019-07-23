namespace Trestlebridge.Interfaces
{
    public interface IChicken
    {
        double SeedPerDay { get; set; }
        string Name {get;}
        void Peck();
    }
}