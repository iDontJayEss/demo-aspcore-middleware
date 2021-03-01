using Microsoft.AspNetCore.Mvc;

namespace Demo.Services
{

    /// <summary>
    /// Represents a controller with item creation capabilities.
    /// </summary>
    /// <typeparam name="TItem">The type of item to create.</typeparam>
    public interface ICreateController<TItem>
    {
        /// <summary>
        /// Creates a new item.
        /// </summary>
        /// <param name="item">The item to create.</param>
        /// <returns>The created item.</returns>
        ActionResult<TItem> Create(TItem item);
    }

}
