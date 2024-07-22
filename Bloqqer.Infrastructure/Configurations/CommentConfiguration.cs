﻿using Bloqqer.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bloqqer.Infrastructure.Configurations;

public sealed class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.ToTable("Bloqqer.Comments");

        builder.Property(p => p.Content)
            .HasMaxLength(Post.MaxContentLength);

        builder.HasOne(c => c.Post)
            .WithMany(p => p.Comments)
            .HasForeignKey(p => p.PostId)
            .HasPrincipalKey(p => p.Id);

        builder.HasOne(c => c.Author)
            .WithMany(a => a.Comments)
            .HasForeignKey(c => c.AuthorId)
            .HasPrincipalKey(a => a.Id);
    }
}