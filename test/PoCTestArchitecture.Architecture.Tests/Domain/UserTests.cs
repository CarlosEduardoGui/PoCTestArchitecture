using FluentAssertions;
using PoCTestArchitecture.Domain.Entities;

namespace PoCTestArchitecture.Architecture.Tests.Domain;
public class UserTests
{
    [Fact]
    public void UserConstructur_Should_HaveTwoParametersOnly()
    {
        var myClassType = typeof(User);
        var constructor = myClassType.GetConstructor([typeof(string), typeof(string)]);

        var parameters = constructor!.GetParameters();

        constructor.Should().NotBeNull();
        parameters.Length.Should().Be(2);
        parameters[0].Name.Should().Be("firstName");
        parameters[1].Name.Should().Be("lastName");
    }

    [Fact]
    public void UserClass_Should_HavePrivateProprietes()
    {
        var myClassType = typeof(User);

        var properties = myClassType.GetProperties();
        foreach (var property in properties)
        {
            if (property.CanWrite)
            {
                property.SetMethod.Should().NotBeNull()
                    .And.Match(setMethod => setMethod.IsPrivate || setMethod.IsFamily || setMethod.IsFamilyOrAssembly,
                        $"{property.Name} should have a private or protected setter.", property.DeclaringType?.FullName);
            }
        }
    }
}
