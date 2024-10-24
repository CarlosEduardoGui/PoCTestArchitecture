using FluentAssertions;
using NetArchTest.Rules;

namespace PoCTestArchitecture.Architecture.Tests.Domain;
public class DomainArchitectureTests : BaseTest
{

    [Fact]
    public void DomainEntitiesNamespace_Should_BeOnlyClasses()
    {
        var files = Types
          .InNamespace(DomainType.Namespace)
          .GetTypes();

        var result = new List<Type>();
        foreach (var entity in files)
        {
            if (entity.IsClass != true)
                result.Add(entity);
        }

        result.Should().BeNullOrEmpty();
    }

    [Fact]
    public void DomainEntitiesNamespace_Should_AllInheritFromDomainClass()
    {
        var result = Types
            .InNamespace(DomainType.Namespace)
            .Should()
            .Inherit(DomainType)
            .GetResult()
            .FailingTypes
            .Except([DomainType]);

        result.Should().BeNullOrEmpty();
    }

    [Fact]
    public void DomainLayer_Should_NotDependyOfApplication()
    {
        var result = Types
            .InAssembly(DomainAssembly)
            .Should()
            .NotHaveDependencyOn("PoCTestArchitecture.Application")
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    public void DomainLayer_Should_NotDependyOfInfrastructure()
    {
        var result = Types
            .InAssembly(DomainAssembly)
            .Should()
            .NotHaveDependencyOn("PoCTestArchitecture.Infrastructure")
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    public void DomainLayer_Should_NotDependyOfApi()
    {
        var result = Types
            .InAssembly(DomainAssembly)
            .Should()
            .NotHaveDependencyOn("PoCTestArchitecture.Api")
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }
}
