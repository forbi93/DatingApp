using MyFirstProject.Entities;

namespace MyFirstProject.Interfaces;

public interface ITokenService
{
    string CreateToken(AppUser user);
}