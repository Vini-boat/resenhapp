namespace Resenhapp.Exceptions;

[System.Serializable]
public class UserIdNotFoundException : System.Exception
{
    public UserIdNotFoundException() { }
    public UserIdNotFoundException(string message) : base(message) { }
    public UserIdNotFoundException(string message, System.Exception inner) : base(message, inner) { }
    protected UserIdNotFoundException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}