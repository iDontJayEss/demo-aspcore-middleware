using System;

namespace Demo.Services.Library
{
    /// <summary>
    /// Contains information about the author of <see cref="Title"/>.
    /// </summary>
    public class Author : ResourceBase
    {
        /// <summary>
        /// The full name of the author.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Biographical information about the author.
        /// </summary>
        public string Biography { get; set; } = string.Empty;

        /// <summary>
        /// The date of birth of the author.
        /// </summary>
        public DateTime? BirthDate { get; set; }
    }
}
