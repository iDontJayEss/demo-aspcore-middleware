namespace Demo.Services.Library
{
    /// <summary>
    /// Represents a controller exposing operations on <see cref="Book"/> items.
    /// </summary>
    public interface IBooksController : IGetController<Book>, IUpdateController<Book>, ICreateController<Book>, IDeleteController<Book>
    {
    }
}
