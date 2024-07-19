﻿namespace FlashCards.DataAccess.Entities;

public abstract class BaseEntity<TKey> where TKey : IEquatable<TKey>
{
    public required TKey Id { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}