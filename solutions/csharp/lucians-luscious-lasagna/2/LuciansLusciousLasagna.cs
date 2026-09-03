class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => 40;
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int MinutesSpentInOven) => ExpectedMinutesInOven() - MinutesSpentInOven;
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int NumberOfLayers) => 2*NumberOfLayers;
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int NumberOfLayers, int MinutesSpentInOven) => PreparationTimeInMinutes(NumberOfLayers) + MinutesSpentInOven;
}
