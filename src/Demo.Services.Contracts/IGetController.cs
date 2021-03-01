using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Demo.Services
{
    /// <summary>
    /// Represents a controller with item retrieval capabilities.
    /// </summary>
    /// <typeparam name="TItem">The type of item this controller retrieves.</typeparam>
    /// <typeparam name="TId">The type of unique item identifier.</typeparam>
    public interface IGetController<TItem, TId>
    {
        /// <summary>
        /// Retrieves all items.
        /// </summary>
        /// <returns>A collection containing the retrieved items.</returns>
        IAsyncEnumerable<TItem> GetAll();

        /// <summary>
        /// Retrieves an item with the provided <paramref name="id"/>.
        /// </summary>
        /// <param name="id">The unique identifier.</param>
        /// <returns>A matching item, if it exists.</returns>
        ActionResult<TItem> GetById(TId id);
    }

    /// <inheritdoc />
    public interface IGetController<TItem> : IGetController<TItem, int>
    {

    }
}
