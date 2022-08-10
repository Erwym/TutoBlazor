namespace TutoBlazor.Models;

public class Product
{
    
    //GUID = ID unique générée par l'ordinateur
    public Guid Id { get; set; }
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public double Price { get; set; }
}