class RemoteControlCar
{
    private int distance_driven = 0;
    private int battery = 100;
    public static RemoteControlCar Buy() => new();

    public string DistanceDisplay() => $"Driven {distance_driven} meters";

    public string BatteryDisplay() => (battery <= 0)? "Battery empty" : $"Battery at {battery}%";

    public void Drive()
    {
        if (battery > 0)
            distance_driven += 20; battery--;
    }
}
