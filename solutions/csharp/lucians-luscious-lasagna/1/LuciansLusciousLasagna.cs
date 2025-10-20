class Lasagna
{
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    public int RemainingMinutesInOven(int minutesInOven)
    {
        return 40 - minutesInOven;
    }

    public int PreparationTimeInMinutes(int layers)
    {
        return 2*layers;
    }

    public int ElapsedTimeInMinutes(int layers, int minutesInOven)
    {
        
        return 2*layers + minutesInOven;
    }
}
