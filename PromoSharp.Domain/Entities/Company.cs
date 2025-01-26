using CSharpFunctionalExtensions;

namespace PromoSharp.Domain.Entities;

public class Company : Entity<Guid>
{
    public string Name { get; }
    
    public string Email { get; }
    
    public string PasswordHash { get; }

    private Company() { }
    
    private Company(Guid id, string name, string email, string passwordHash) : base(id)
    {
        Name = name;
        Email = email;
        PasswordHash = passwordHash;
    }

    public static Result<Company> Create(Guid id, string name, string email, string passwordHash)
    {
        Company company = new(id, name, email, passwordHash);

        return Result.Success(company);
    }
}