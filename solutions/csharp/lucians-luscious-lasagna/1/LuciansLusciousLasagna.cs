class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() {
        return 40;
    }
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int MinutesSpentInOven) {
        return ExpectedMinutesInOven() - MinutesSpentInOven;
    }
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int NumberOfLayers) {
        return 2*NumberOfLayers;
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int NumberOfLayers, int MinutesSpentInOven) {
        return PreparationTimeInMinutes(NumberOfLayers) + MinutesSpentInOven;
    }
}
