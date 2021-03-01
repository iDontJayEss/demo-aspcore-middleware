namespace Demo.Services.Library
{
    /// <summary>
    /// Represents a controller exposing operations on <see cref="Author"/> items.
    /// </summary>
    public interface IAuthorsController : IGetController<Author>, IUpdateController<Author>, ICreateController<Author>, IDeleteController
    {
    }
}
