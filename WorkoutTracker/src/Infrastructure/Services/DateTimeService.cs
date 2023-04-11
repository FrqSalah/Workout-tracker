using WorkoutTracker.Application.Common.Interfaces;

namespace WorkoutTracker.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
