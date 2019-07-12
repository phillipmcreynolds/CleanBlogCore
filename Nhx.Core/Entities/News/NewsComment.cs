using System;
using Nhx.Core.Entities.Users;
using Nhx.Core.Entities.Stores;

namespace Nhx.Core.Entities.News
{
    /// <summary>
    /// Represents a news comment
    /// </summary>
    public partial class NewsComment : BaseEntity
    {
        /// <summary>
        /// Gets or sets the comment title
        /// </summary>
        public string CommentTitle { get; set; }

        /// <summary>
        /// Gets or sets the comment text
        /// </summary>
        public string CommentText { get; set; }

        /// <summary>
        /// Gets or sets the news item identifier
        /// </summary>
        public int NewsItemId { get; set; }

        /// <summary>
        /// Gets or sets the user identifier
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the comment is approved
        /// </summary>
        public bool IsApproved { get; set; }

        /// <summary>
        /// Gets or sets the store identifier
        /// </summary>
        public int StoreId { get; set; }

        /// <summary>
        /// Gets or sets the date and time of instance creation
        /// </summary>
        public DateTime CreatedOnUtc { get; set; }

        /// <summary>
        /// Gets or sets the user
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// Gets or sets the news item
        /// </summary>
        public virtual NewsItem NewsItem { get; set; }

        /// <summary>
        /// Gets or sets the store
        /// </summary>
        public virtual Store Store { get; set; }
    }
}