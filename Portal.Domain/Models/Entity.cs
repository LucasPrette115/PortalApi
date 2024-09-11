using System;

namespace Portal.Domain.Models;

public abstract class Entity
{
    public Guid Id { get; private set;} = Guid.NewGuid();
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? UpdatedAt { get; set;}
}
