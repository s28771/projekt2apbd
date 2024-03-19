namespace projekt2abd.Exceptions;

public class OverfillExeption : Exception
{
    public OverfillExeption()
    {
    }

    public OverfillExeption(string? message) : base(message)
    {
    }

    public OverfillExeption(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
// crl + k + c komentarz