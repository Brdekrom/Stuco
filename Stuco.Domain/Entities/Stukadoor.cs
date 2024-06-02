﻿namespace Stuco.Domain.Entities;

public class Stukadoor : Personeel
{
    public string Name { get; set; }
    public int? ProjectId { get; set; }

    // Navigation properties
    public Project Project { get; set; }
}