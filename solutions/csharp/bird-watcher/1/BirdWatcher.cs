class BirdCount
{
    private int[] birdsPerDay =  {2, 5, 0, 7, 4, 1};

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => [0, 2, 5, 3, 7, 8, 4];

    public int Today() => birdsPerDay[6];

    public void IncrementTodaysCount() => birdsPerDay[6]++;

    public bool HasDayWithoutBirds() => birdsPerDay.Contains(0);

    public int CountForFirstDays(int numberOfDays) => birdsPerDay[0..numberOfDays].Sum();

    public int BusyDays()
    {
        int i = 0;
        foreach (int birds in birdsPerDay)
            if (birds >= 5) i++;
        return i;
    }
}
