using Bildirim.Common.Auth;
using System.Security.Claims;

namespace Bildirim.Infrastructure.Main.Repositories.Interfaces.Authorization
{
    public interface ITokenRepository
    {
        string GetToken(JwtPayLoad payload);

        ClaimsPrincipal ValidateToken(string jwtToken);

    }
}
