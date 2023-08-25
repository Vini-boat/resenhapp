namespace Resenhapp;

public class Expense: NamedBase
{
    public Person? Owner { get; set; }
    public double Value { get; set; }
    public DateTime BuiedAt { get; set; }
    public string? Description { get; set; }
    public bool Planned { get; set; }
    public bool Paied { get; set; }
}