using BookManagementSystemAPI.Dto;

namespace BookManagementSystemAPI.Services
{
    public interface IAuthService
    {
        Task<string> Register(RegisterRequestDto registerRequest);
    }
}
