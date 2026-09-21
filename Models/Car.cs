namespace DreamGarage.Models;

public class Car
{
    public int Id { get; set; }
    public string Make { get; set; } = "";
    public string Model { get; set; } = "";
    public string Trim { get; set; } = "";
    public int Year { get; set; }
    public string Color { get; set; } = "";
    public int Price { get; set; }
    public int Horsepower { get; set; }
    public bool IsElectric { get; set; }
    public bool IsHybrid { get; set; }
}