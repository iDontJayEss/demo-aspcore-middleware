namespace Demo.Services.Library
{
    /// <summary>
    /// Represents a controller exposing operations on <see cref="Librarian"/> items.
    /// </summary>
    public interface ILibrariansController : IGetController<Librarian>, ICreateController<Librarian>, IUpdateController<Librarian>, IDeleteController<Librarian>
    {
    }
}
