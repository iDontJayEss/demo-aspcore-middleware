namespace Demo.Services.Library
{
    /// <summary>
    /// Represents the owner of an <see cref="Account"/>.
    /// </summary>
    public class Patron : ResourceBase
    {
        /// <summary>
        /// The full name of the patron.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The patron's mailing address.
        /// </summary>
        public string Address { get; set; } = string.Empty;
    }
}
