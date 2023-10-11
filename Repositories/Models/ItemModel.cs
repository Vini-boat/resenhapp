namespace Resenhapp;

public class Item: NamedBase
{
    public double Price {get;set;}
    public string Description {get;set;} = string.Empty;

    public static List<Item> items = new List<Item> 
    {
        new Item {Id = 1, Name = "Cooler", Price = 170, Description = "Para guardar a bebida"},
        new Item {Id = 2, Name = "JBL", Price = 200, Description = "Para tocar a música"},
        new Item {Id = 3, Name = "Copo", Price = 15, Description = "Para tomar a bebida"},
    };
}
