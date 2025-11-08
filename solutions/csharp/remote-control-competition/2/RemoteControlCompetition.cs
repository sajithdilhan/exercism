
public interface IRemoteControlCar 
{
    int DistanceTravelled { get; }
    public void Drive();
}

public class ProductionRemoteControlCar : IRemoteControlCar, IComparable<ProductionRemoteControlCar>
{
    public int DistanceTravelled {get; private set;}
        
    public int NumberOfVictories { get; set; }

    public void Drive()
    {
        DistanceTravelled += 10;
    }

    public int CompareTo(ProductionRemoteControlCar other) => this.NumberOfVictories - other.NumberOfVictories;
    
}

public class ExperimentalRemoteControlCar : IRemoteControlCar
{
    public int DistanceTravelled {get; private set;}

    public void Drive()
    {
        DistanceTravelled += 20;
    }
}

public static class TestTrack
{
    public static void Race(IRemoteControlCar car)
    {
        car.Drive();
    }

    public static List<ProductionRemoteControlCar> GetRankedCars(ProductionRemoteControlCar prc1,
        ProductionRemoteControlCar prc2)
    {
        List<ProductionRemoteControlCar> rankings = new();
        var prc1Rank = prc1.CompareTo(prc2);
        var prc2Rank = prc1.CompareTo(prc1);

        if(prc1Rank >= prc2Rank)
        {
            rankings.Add(prc2);
            rankings.Add(prc1);
        }
        else
        {
            rankings.Add(prc1);
             rankings.Add(prc2);
        }
        return rankings;
    }
}
