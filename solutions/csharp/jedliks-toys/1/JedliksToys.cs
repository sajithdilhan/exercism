class RemoteControlCar
{
    private int distance = 0;
    private int batteryLevel = 100;
    
    public static RemoteControlCar Buy() =>    new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {distance} meters";

    public string BatteryDisplay() 
    {
        if(batteryLevel >0)
            return $"Battery at {batteryLevel}%";
        return 
            "Battery empty";
    }

    public void Drive()
    {
        if(batteryLevel >0)
        {
            distance += 20;
            batteryLevel -= 1;
        }
    }
}
