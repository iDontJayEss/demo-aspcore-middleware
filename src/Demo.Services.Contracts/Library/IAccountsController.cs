namespace Demo.Services.Library
{
    /// <summary>
    /// Represents a controller exposing operations on <see cref="Account"/> items.
    /// </summary>
    public interface IAccountsController : IGetController<Account>, IUpdateController<Account>, ICreateController<Account>
    {

    }
}
