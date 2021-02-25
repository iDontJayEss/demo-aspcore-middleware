namespace Demo.Services.Models.Library
{
    /// <summary>
    /// Represents the physical location of a library.
    /// </summary>
    public class Library : ResourceBase
    {
        /// <summary>
        /// The name of the library.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The physical address of the library.
        /// </summary>
        public string Address { get; set; } = string.Empty;
    }
}
