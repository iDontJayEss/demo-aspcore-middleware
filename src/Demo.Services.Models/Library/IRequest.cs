using System;

namespace Demo.Services.Models.Library
{
    /// <summary>
    /// Represents a type of request an <see cref="Account"/> can make.
    /// </summary>
    public interface IRequest
    {
        /// <summary>
        /// Unique identifier for the request.
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Unique identifier for the account making the request.
        /// </summary>
        int AccountId { get; }

        /// <summary>
        /// Date the request was first received.
        /// </summary>
        DateTime? Received { get; }

        /// <summary>
        /// Last date this request was updated.
        /// </summary>
        DateTime? LastAction { get; }

        /// <summary>
        /// The current status of the request.
        /// </summary>
        RequestStatus Status { get; }

        /// <summary>
        /// Identifies the fully qualified type of request.
        /// </summary>
        string RequestType { get; }
    }

    /// <summary>
    /// Indicates the various states for a request.
    /// </summary>
    public enum RequestStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Unspecified = 0,

        /// <summary>
        /// A received but unprocessed request.
        /// </summary>
        Pending,

        /// <summary>
        /// An accepted request.
        /// </summary>
        Approved,

        /// <summary>
        /// A denied request.
        /// </summary>
        Rejected
    }
}
