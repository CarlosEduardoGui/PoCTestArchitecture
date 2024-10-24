using FluentAssertions;
using NetArchTest.Rules;

namespace PoCTestArchitecture.Architecture.Tests.Infrastructure;
public class InfrastructureArchitectureTests : BaseTest
{
    [Fact]
    public void InfrastructureLayer_Should_NotDependyOfApplication()
    {
        var result = Types
            .InAssembly(InfrastructureAssembly)
            .Should()
            .NotHaveDependencyOn("PoCTestArchitecture.Application")
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    public void InfrastructureLayer_Should_NotDependyOfApi()
    {
        var result = Types
            .InAssembly(InfrastructureAssembly)
            .Should()
            .NotHaveDependencyOn("PoCTestArchitecture.Api")
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    public void InfrastructureLayer_Should_DependyDomainLayer()
    {
        var result = Types
            .InAssembly(InfrastructureAssembly)
            .That()
            .HaveNameEndingWith("Repository")
            .Should()
            .HaveDependencyOn("PoCTestArchitecture.Domain")
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }
}
