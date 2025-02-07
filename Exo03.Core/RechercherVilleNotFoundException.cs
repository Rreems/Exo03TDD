namespace Exo03.Core;

public class RechercherVilleNotFoundException : Exception
{
    public RechercherVilleNotFoundException() : base()
    {
    }

    public RechercherVilleNotFoundException(string? message) : base(message)
    {
    }

    public RechercherVilleNotFoundException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
