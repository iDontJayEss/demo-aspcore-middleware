using System;

namespace Demo.Services.Models.Library
{
    /// <summary>
    /// Represents a physical instance of <see cref="Title"/>.
    /// </summary>
    public class Book : ResourceBase<string>
    {
        /// <summary>
        /// The unique identifier of the parent <see cref="Title"/>. Renames <see cref="TitleId"/>.
        /// </summary>
        public string Isbn { get => TitleId; set => TitleId = value; }

        /// <inheritdoc cref="Title.Subject"/>.
        public string Subject { get; set; } = string.Empty;

        /// <summary>
        /// The name of this book.
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// The unique identifier of the parent <see cref="Title"/>.
        /// </summary>
        public string TitleId { get; set; } = string.Empty;

        /// <summary>
        /// Indicates the books is for reference use and can not be borrowed.
        /// </summary>
        public bool IsReferenceOnly { get; set; } = false;

        /// <inheritdoc cref="Title.Language"/>.
        public Language Language { get; set; } = Language.Unspecified;

        /// <summary>
        /// The page count.
        /// </summary>
        public int NumberOfPages { get; set; }

        /// <summary>
        /// The media format of the book.
        /// </summary>
        public BookFormat Format { get; set; } = BookFormat.Unspecified;
    }

    /// <summary>
    /// Represents a <see cref="Book"/> that has been borrowed from the library.
    /// </summary>
    public class BorrowedBook : Book
    {
        /// <summary>
        /// The date the book was borrowed from the library.
        /// </summary>
        public DateTime Borrowed { get; set; }

        /// <summary>
        /// The number of days the book is loaned out for.
        /// </summary>
        public int LoanPeriod { get; init; }

        /// <summary>
        /// The date the book must be returned to the library.
        /// </summary>
        public DateTime DueDate { get; init; }

        /// <summary>
        /// Indicates the <see cref="DueDate"/> has elapsed.
        /// </summary>
        public bool IsOverdue { get; init; } = false;
    }

    /// <summary>
    /// The media format of a book.
    /// </summary>
    public enum BookFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Unspecified = 0,

        /// <summary>
        /// A physical, paperback copy of a book.
        /// </summary>
        Paperback,

        /// <summary>
        /// A physical, hardcover copy of a book.
        /// </summary>
        Hardcover,

        /// <summary>
        /// An audio book, in physical or digital form.
        /// </summary>
        AudioBook,

        /// <summary>
        /// An audio CD.
        /// </summary>
        AudioCd,

        /// <summary>
        /// An audio CD containing an MP3 recording.
        /// </summary>
        Mp3Cd,

        /// <summary>
        /// A PDF copy of a book.
        /// </summary>
        Pdf
    }
}
