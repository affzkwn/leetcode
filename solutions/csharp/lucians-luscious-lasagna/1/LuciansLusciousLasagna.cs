class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        int x = 40;
        return x;
    }
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int timeInOven)
    {
        return ExpectedMinutesInOven() - timeInOven;
    }
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layer)
    {
        int prepMinutes = layer * 2;
        return prepMinutes;
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int timeInOven)
    {
        int ElapseMinutes = PreparationTimeInMinutes(layers) + timeInOven;
        return ElapseMinutes;
    }
}