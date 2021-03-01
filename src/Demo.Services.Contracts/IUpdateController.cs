using Microsoft.AspNetCore.Mvc;

namespace Demo.Services
{
    /// <summary>
    /// Represents a controller with item update capabilities.
    /// </summary>
    /// <typeparam name="TItem">The type of item this controller updates.</typeparam>
    /// <typeparam name="TId">The type of unique item identifier.</typeparam>
    public interface IUpdateController<TItem, TId>
    {
        /// <summary>
        /// Updates an existing item.
        /// </summary>
        /// <param name="id">The unique identifier.</param>
        /// <param name="model">The item with updated values.</param>
        /// <returns>The updated item.</returns>
        ActionResult<TItem> Update(TId id, TItem model);
    }

    /// <inheritdoc />
    public interface IUpdateController<TItem> : IUpdateController<TItem, int>
    { }
}
