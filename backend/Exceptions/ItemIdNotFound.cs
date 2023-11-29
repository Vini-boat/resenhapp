namespace Resenhapp.Exceptions;

[System.Serializable]
public class ItemIdNotFoundException : System.Exception
{
    public ItemIdNotFoundException() { }
    public ItemIdNotFoundException(string message) : base(message) { }
    public ItemIdNotFoundException(string message, System.Exception inner) : base(message, inner) { }
    protected ItemIdNotFoundException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}