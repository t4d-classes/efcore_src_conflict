namespace ToolsDbApp.Models;

[Table("Color")]
public class Color
{
  public int Id { get; set; }
  public string Name { get; set; } = null!;
  public string HexCode { get; set; } = null!;
}