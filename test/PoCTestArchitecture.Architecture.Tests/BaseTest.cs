using PoCTestArchitecture.Application;
using PoCTestArchitecture.Infrastructure.Repository;
using System.Reflection;
using Entity = PoCTestArchitecture.Domain.Entities;

namespace PoCTestArchitecture.Architecture.Tests;
public class BaseTest
{
    public static readonly Assembly DomainAssembly = typeof(Entity.Domain).Assembly;
    public static readonly Assembly ApplicationAssembly = typeof(ApplicationLayer).Assembly;
    public static readonly Assembly InfrastructureAssembly = typeof(UserRepository).Assembly;
    public static readonly Type DomainType = typeof(Entity.Domain);
}
