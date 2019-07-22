namespace Trestlebridge.Interfaces
{
    public interface IGrazing
    {
        string Name { get; }
        double GrassPerDay { get; set; }
        void Graze();
    }
}