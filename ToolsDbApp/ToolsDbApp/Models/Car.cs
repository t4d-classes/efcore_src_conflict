﻿namespace ToolsDbApp.Models;

[Table("Car")]
public class Car
{
  public int Id { get; set; }
  public string Make { get; set; } = null!;
  public string Model { get; set; } = null!;
  public int Year { get; set; }
  public string BodyColor { get; set; } = null!;
  public decimal Price { get; set; }
  public string Country { get; set; } = null!;
  public string Transmission { get; set; } = null!;
}
