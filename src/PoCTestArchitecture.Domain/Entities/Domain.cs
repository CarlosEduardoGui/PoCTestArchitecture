namespace PoCTestArchitecture.Domain.Entities;
public abstract class Domain
{
    protected Domain() => Id = Guid.NewGuid();
    public Guid Id { get; protected set; }
}
