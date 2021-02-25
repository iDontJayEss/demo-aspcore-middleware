using System;

namespace Demo.Services.Models.Library
{
    /// <summary>
    /// A type of <see cref="Book"/> in a <see cref="Library"/>. 
    /// </summary>
    /// <remarks>
    /// Based on the Book class https://www.uml-diagrams.org/library-domain-uml-class-diagram-example.html.
    /// As this is a resource model, rather than a domain model, the term Title was used to make the Book (previously BookItem) controller more coherent.
    /// </remarks>
    public class Title : ResourceBase<string>
    {
        /// <summary>
        /// Unique identifier of the <see cref="Title"/>. Renames Id.
        /// </summary>
        public string Isbn { get => Id; set => Id = value; }

        /// <summary>
        /// The official name of the book.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The subject content of the book.
        /// </summary>
        public string Subject { get; set; } = string.Empty;

        /// <summary>
        /// Summary of the book contents.
        /// </summary>
        public string Overview { get; set; } = string.Empty;

        /// <summary>
        /// The name of the publisher.
        /// </summary>
        public string Publisher { get; set; } = string.Empty;

        /// <summary>
        /// The date of publication.
        /// </summary>
        public DateTime? PublicationDate { get; set; }

        /// <summary>
        /// The language the book is written in.
        /// </summary>
        /// <remarks>
        /// In <see cref="Title"/>, represents the original language the book was written in.
        /// For <see cref="Book"/>, if representing a translated copy, this would be the translated language.
        /// </remarks>
        public Language Language { get; set; } = Language.Unspecified;
    }

    /// <summary>
    /// Indicates a spoken or written language.
    /// </summary>
    public enum Language
    {
        /// <summary>
        /// 
        /// </summary>
        Unspecified = 0,

        /// <summary>
        /// The English language.
        /// </summary>
        English,

        /// <summary>
        /// The French language.
        /// </summary>
        French,

        /// <summary>
        /// The German language.
        /// </summary>
        German,

        /// <summary>
        /// The Spanish language.
        /// </summary>
        Spanish,

        /// <summary>
        /// The Italian language.
        /// </summary>
        Italian
    }
}
