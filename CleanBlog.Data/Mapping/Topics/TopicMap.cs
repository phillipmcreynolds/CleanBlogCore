﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nhx.Core.Entities.Topics;

namespace CleanBlog.Data.Mapping.Topics
{
    /// <summary>
    /// Represents a topic mapping configuration
    /// </summary>
    public partial class TopicMap : EntityTypeConfiguration<Topic>
    {
        #region Methods

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<Topic> builder)
        {
            builder.ToTable(nameof(Topic));
            builder.HasKey(topic => topic.Id);

            base.Configure(builder);
        }

        #endregion
    }
}