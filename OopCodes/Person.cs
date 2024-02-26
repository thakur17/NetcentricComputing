public class Person
{
    public void WriteToConsole()
    {
        Console.WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
    }
    public string GetOrigin()
    {
        return $"{Name} was born on {HomePlanet}.";
    }
    // fields
    public string Name;
    public DateTime DateOfBirth;
    public WondersOfTheAncientWorld
        FavoriteAncientWonder;
    public List<Person> Children = new List<Person>();
    public readonly string HomePlanet = "Earth";
}


public enum WondersOfTheAncientWorld
{
    GreatPyramidOfGiza,
    HangingGardensOfBabylon,
    Statue_Of_ZeusAt_Olympia,
    TempleOfArtemisAtEphesus,
    MausoleumAtHalicarnassus,
    ColossusOfRhodes,
    LighthouseOfAlexandria

}
