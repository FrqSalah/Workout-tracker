namespace WorkoutTracker.Domain.Entities;

public class Set
{
    public int Id { get; set; }
    public int WeightLifted { get; set; }
    public int Repetitions { get; set; }
    public TimeSpan RestTime { get; set; }
}
