static class AssemblyLine
{
    public static double SuccessRate(int speed)
    => speed switch 
        {
            0 => 0,
            1 or 2 or 3 or 4 => 1,
            5 or 6 or 7 or 8 => 0.9,
            9 => 0.8,
            10 => 0.77,
            _ => 0
        };
    
    public static double ProductionRatePerHour(int speed)
    {
        const int baseRate = 221;
        int ratePerHour = speed * baseRate;

        double successRate = SuccessRate(speed);

        return ratePerHour * successRate;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        double prodRatePerHour = ProductionRatePerHour(speed);
        double workingItemsPerMinute = prodRatePerHour/60;

        return (int)workingItemsPerMinute;
    }
}
