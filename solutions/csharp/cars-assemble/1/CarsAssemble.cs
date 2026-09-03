static class AssemblyLine
{
    public static double SuccessRate(int speed) => (speed < 1)?0.0 : (speed < 5)? 1.0 :(speed < 9)? 0.9: (speed == 9)? 0.8: 0.77;
    
    public static double ProductionRatePerHour(int speed) => 221 * speed * SuccessRate(speed);

    public static int WorkingItemsPerMinute(int speed) => (int)Math.Floor(ProductionRatePerHour(speed)/60);
}
