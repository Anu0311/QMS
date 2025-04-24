using QMS.core.DatabaseContext;
using QMS.core.Models;

namespace QMS.core.Repositories.UsersRepository
{
    public interface IUsersRepository
    {
        Task<UserDetail> Login(LoginViewModel loginViewModel);
        Task<UserDetail> LoginWithAdId(string adId);
        Task<List<UserDetailViewModel>> GetUsersListAsync();
        Task<OperationResult> CreateUserAsync(UserDetailViewModel userViewModel, bool returnCreatedRecord = false);
        Task<OperationResult> UpdateUserAsync(UserDetailViewModel userViewModel, bool returnUpdatedRecord = false);
        Task<OperationResult> DeleteUserAsync(int userId);
        Task<UserDetailViewModel?> GetUserByIdAsync(int userId);
    }
}
