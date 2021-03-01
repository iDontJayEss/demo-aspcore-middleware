namespace Demo.Services.Library
{
    /// <summary>
    /// Represents a controller exposing operations on <see cref="Title"/> items.
    /// </summary>
    public interface ITitlesController : IGetController<Title, string>, ICreateController<Title>, IUpdateController<Title, string>, IDeleteController<string>
    {

    }
}
