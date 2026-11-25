public class Player
{
    private static readonly Random Random = new(); 
    public int RollDie()
    {
        return Random.Next(1,19);
        throw new NotImplementedException("Please implement the Player.RollDie() method");
    }

    public double GenerateSpellStrength()
    {
        return Random.NextDouble();
        throw new NotImplementedException("Please implement the Player.GenerateSpellStrength() method");
    }
}

