using System;
using System.Collections.Generic;

namespace Demo.Services.Models.Library
{
    /// <summary>
    /// Represents a user as a member of a library.
    /// </summary>
    public class Account : ResourceBase
    {
        /// <summary>
        /// Date the account was opened.
        /// </summary>
        public DateTime? Opened { get; set; }

        /// <summary>
        /// The current state of the account.
        /// </summary>
        public AccountState State { get; set; } = AccountState.Unspecified;

        /// <summary>
        /// Historical actions performed on the account.
        /// </summary>
        public List<IRequest> History { get; init; }
            = new List<IRequest>();
    }

    /// <summary>
    /// The status of a created account.
    /// </summary>
    public enum AccountState
    {
        /// <summary>
        /// 
        /// </summary>
        Unspecified = 0,

        /// <summary>
        /// Indicates an account in good standing.
        /// </summary>
        Active,

        /// <summary>
        /// Indicates an account that has had its activity frozen.
        /// </summary>
        Frozen,

        /// <summary>
        /// Indicates an account that has been closed.
        /// </summary>
        Closed
    }
}
