using FluentAssertions;
using NetArchTest.Rules;
using PoCTestArchitecture.Domain.Repositories;
using Entities = PoCTestArchitecture.Domain.Entities;

namespace PoCTestArchitecture.Architecture.Tests.Domain;
public class RepositoryTests : BaseTest
{
    [Fact]
    public void FolderRepository_Should_HaveInterfacesOnly()
    {
        var files = Types
            .InNamespace(typeof(IRepository<Entities.Domain>).Namespace)
            .That()
            .AreNotInterfaces()
            .GetTypes();

        files.Should().BeNullOrEmpty();
    }

    [Fact]
    public void Repositories_Should_HaveEndNameRepository()
    {
        var result = Types
           .InAssembly(DomainAssembly)
           .That()
           .AreInterfaces()
           .And()
           .ImplementInterface(typeof(IRepository<>))
           .Should()
           .HaveNameEndingWith("Repository")
           .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    public void Repositories_Should_HaveStartNameI()
    {
        var result = Types
           .InAssembly(DomainAssembly)
           .That()
           .AreInterfaces()
           .And()
           .ImplementInterface(typeof(IRepository<>))
           .Should()
           .HaveNameStartingWith("I")
           .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }
}
