using FluentAssertions;
using NetArchTest.Rules;

namespace PoCTestArchitecture.Architecture.Tests.Application;
public class ApplicationArchitectureTests : BaseTest
{
    [Fact]
    public void ApplicationLayer_Should_NotDependyOfInfrastructure()
    {
        var result = Types
            .InAssembly(ApplicationAssembly)
            .Should()
            .NotHaveDependencyOn("PoCTestArchitecture.Infrastructure")
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    public void ApplicationLayer_Should_NotDependyOfApi()
    {
        var result = Types
            .InAssembly(ApplicationAssembly)
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
            .HaveNameEndingWith("CommandHandler")
            .Should()
            .HaveDependencyOn("PoCTestArchitecture.Domain")
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }
}
