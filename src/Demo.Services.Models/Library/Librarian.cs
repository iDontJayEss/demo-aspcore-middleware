namespace Demo.Services.Models.Library
{
    /// <summary>
    /// Represents a librarian; an employee of a <see cref="Library"/>.
    /// </summary>
    public class Librarian : ResourceBase
    {
        /// <summary>
        /// The full name of the librarian.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The address of the librarian's residence.
        /// </summary>
        public string Address { get; set; } = string.Empty;

        /// <summary>
        /// The librarian's position within the <see cref="Library"/>.
        /// </summary>
        public string Position { get; set; } = string.Empty;
    }
}
