namespace Resenhapp.Repositories.Models;

public class Item: NamedBase
{
    public double Price {get;set;}
    public string Description {get;set;} = string.Empty;
    
}
