using System.Security.Claims;

namespace AccessManagement.API.Interfaces
{
    public interface IJwtTokenService
    {
        string GenerateAccessToken(IEnumerable<Claim> claims);
        string GenerateRefreshToken();
    }
}
