using AutoMapper;
using UserMvcApp.Data;
using UserMvcApp.DTO;
using UserMvcApp.Repositories;

namespace UserMvcApp.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;// den xreisimopoieitai edw akoma alla mazi me to config class kai alla repositories xreiazetai

        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task SignUpUserAsync(UserSignUpDTO request)
        {
            if (!await _unitOfWork.UserRepository.SignUpUserAsync(request))
            {
                throw new ApplicationException("user already exists");
                // min xrisimopoieis to Application Exception, ftiakse to diko soy Exception
            }
            await _unitOfWork.SaveAsync();
        }

        public async Task<User?> LoginUserAsync(UserLoginDTO credentials)
        {
            var user = await _unitOfWork.UserRepository.GetUserAsync(credentials.Username!, credentials.Password!);
            if (user == null)
            {
                return null;
            }
            return user;
        }

        public async Task<User?> UpdateUserAccountInfoAsync(UserPatchDTO request, int userId)
        {
            var user = await _unitOfWork.UserRepository.UpdateUserAsync(userId, request);
            await _unitOfWork.SaveAsync();
            return user!;
        }

        public async Task<User?> GetUserByUsername(string username)
        {
            return await _unitOfWork.UserRepository.GetByUSernameAsync(username);
        }

       

    }
}
