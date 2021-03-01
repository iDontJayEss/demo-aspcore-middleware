namespace Demo.Services.Library
{
    /// <summary>
    /// Represents a controller exposing operations on <see cref="Library"/> items.
    /// </summary>
    public interface ILibrariesController : IGetController<Library>, ICreateController<Library>, IUpdateController<Library>, IDeleteController
    {
    }
}
