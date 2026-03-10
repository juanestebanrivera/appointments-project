namespace Appointments.Domain.Common;

public abstract class BaseEntity
{
    public Guid Id { get; private init; } = Guid.NewGuid();
}