﻿namespace WorkoutTracker.Domain.Entities;

public class Exercise
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public List<Set> Sets { get; set; }
}
