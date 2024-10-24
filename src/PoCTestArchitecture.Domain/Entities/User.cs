using PoCTestArchitecture.Domain.Exceptions;

namespace PoCTestArchitecture.Domain.Entities;

public class User : Domain
{
    private User() { }

    public User(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;

        Validate();
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    private void Validate()
    {
        if (string.IsNullOrEmpty(FirstName))
            throw new DomainException("First Name should not be null.");

        if (string.IsNullOrEmpty(LastName))
            throw new DomainException("Last Name should not be null.");
    }
}
