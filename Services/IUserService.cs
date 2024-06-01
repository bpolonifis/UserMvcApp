using UserMvcApp.Data;
using UserMvcApp.DTO;

namespace UserMvcApp.Services
{
    public interface IUserService
    {
        Task SignUpUserAsync(UserSignUpDTO request);
        Task <User?> LoginUserAsync(UserLoginDTO credentials);
        Task<User?> UpdateUserAccountInfoAsync(UserPatchDTO request, int userId);
        Task<User?> GetUserByUsername(string username);
    }
}
