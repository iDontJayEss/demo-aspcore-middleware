using System;

namespace Demo.Services.Library
{
    /// <summary>
    /// <inheritdoc cref="IRequest"/>
    /// </summary>
    /// <typeparam name="TRequestType">Type representing the request category.</typeparam>
    public abstract class Request<TRequestType> : ResourceBase, IRequest
        where TRequestType : struct
    {
        /// <inheritdoc />
        public int AccountId { get; set; }

        /// <inheritdoc />
        public DateTime? Received { get; set; } = DateTime.Now;

        /// <inheritdoc />
        public DateTime? LastAction { get; init; }

        /// <inheritdoc />
        public RequestStatus Status { get; set; } = RequestStatus.Unspecified;

        /// <summary>
        /// The subcategory for this type of request.
        /// </summary>
        public TRequestType RequestType { get; set; }

        string IRequest.RequestType => $"{typeof(TRequestType).Name}.{RequestType}";
    }

    /// <summary>
    /// Represents a request to borrow, return, or reserve a <see cref="Book"/>.
    /// </summary>
    public class BookRequest : Request<BookRequestAction>
    {
        /// <summary>
        /// Unique identifier of the <see cref="Book"/>.
        /// </summary>
        public string BookId { get; set; } = string.Empty;
    }

    /// <summary>
    /// Represents an action that may be performed on a <see cref="Book"/>.
    /// </summary>
    public enum BookRequestAction
    {
        /// <summary>
        /// 
        /// </summary>
        Unspecified = 0,

        /// <summary>
        /// A request to borrow a book.
        /// </summary>
        Borrow,

        /// <summary>
        /// A request to return a borrowed book.
        /// </summary>
        Return,

        /// <summary>
        /// A request to reserve a book when it becomes available.
        /// </summary>
        Reserve
    }

}
