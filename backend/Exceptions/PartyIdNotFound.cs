namespace Resenhapp.Exceptions;

[System.Serializable]
public class PartyIdNotFoundException : System.Exception
{
    public PartyIdNotFoundException() { }
    public PartyIdNotFoundException(string message) : base(message) { }
    public PartyIdNotFoundException(string message, System.Exception inner) : base(message, inner) { }
    protected PartyIdNotFoundException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}