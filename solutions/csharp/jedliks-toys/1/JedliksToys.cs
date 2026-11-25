class RemoteControlCar
{
    private int distance = 0;
    private int battery = 100;
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar() ;
        throw new NotImplementedException("Please implement the (static) RemoteControlCar.Buy() method");
    }

    public string DistanceDisplay()
    {
        return $"Driven {distance} meters";
        throw new NotImplementedException("Please implement the RemoteControlCar.DistanceDisplay() method");
    }

    public string BatteryDisplay()
    {
         if (battery == 0)
            return "Battery empty";
        return $"Battery at {battery}%";
    }

    public void Drive()
    {
        if (battery <= 0) return;
        distance += 20;
        battery = Math.Max(0, battery - 1);
    }
}
