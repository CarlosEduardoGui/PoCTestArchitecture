using FluentAssertions;
using NetArchTest.Rules;
using PoCTestArchitecture.Application.Handlers;

namespace PoCTestArchitecture.Architecture.Tests.Application;
public class HandlerTests : BaseTest
{
    [Fact]
    public void CommandHandler_Should_HaveImplementInterface()
    {
        var result = Types
           .InAssembly(ApplicationAssembly)
           .That()
           .ImplementInterface(typeof(ICommandHandler<,>))
           .Should()
           .HaveNameEndingWith("CommandHandler")
           .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }
}
