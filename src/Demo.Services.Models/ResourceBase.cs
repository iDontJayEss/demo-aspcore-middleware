namespace Demo.Services
{
    /// <summary>
    /// Base type for all resources.
    /// </summary>
    /// <typeparam name="TId">The type of unique identifier.</typeparam>
    public abstract class ResourceBase<TId>
    {
        /// <summary>
        /// Unique identifier of the resource.
        /// </summary>
        public TId Id { get; set; }

    }

    /// <summary>
    /// Base type for all resources with an integer identifier.
    /// </summary>
    public abstract class ResourceBase : ResourceBase<int> { }
}
