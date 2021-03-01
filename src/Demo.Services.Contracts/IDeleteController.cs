using Microsoft.AspNetCore.Mvc;

namespace Demo.Services
{
    /// <summary>
    /// Represents a controller with item deletion capabilities.
    /// </summary>
    /// <typeparam name="TId">The type of unique item identifier.</typeparam>
    public interface IDeleteController<TId>
    {
        /// <summary>
        /// Removes an existing item with the provided <paramref name="id"/>.
        /// </summary>
        /// <param name="id">The unique identifier.</param>
        /// <returns>A result indicating the success of the operation.</returns>
        ActionResult Delete(TId id);
    }

    /// <inheritdoc />
    public interface IDeleteController : IDeleteController<int> { }
}
