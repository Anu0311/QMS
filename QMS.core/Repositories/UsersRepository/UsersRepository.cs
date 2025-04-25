using QMS.core.DatabaseContext;
using QMS.core.Models;
using Microsoft.EntityFrameworkCore;
using QMS.core.Repositories.Shared;
using QMS.core.Services.SystemLogs;
using QMS.core.Repositories.UsersRepository;


public class UsersRepository : SqlTableRepository, IUsersRepository
{
    private readonly QMSDbContext _context;

    public UsersRepository(QMSDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<UserDetail> Login(LoginViewModel loginViewModel)
    {
        return await _context.UserDetails
            .FirstOrDefaultAsync(u => u.Username == loginViewModel.Username && u.Password == loginViewModel.Password);
    }

    public async Task<UserDetail> LoginWithAdId(string adId)
    {
        return await _context.UserDetails.FirstOrDefaultAsync(u => u.Username == adId);
    }

    public async Task<List<UserDetailViewModel>> GetUsersListAsync()
    {
        return await _context.UserDetails.Where(u => !u.Deleted)
            .Select(u => new UserDetailViewModel
            {
                UserId = u.Id,
                Name = u.Name,
                Email = u.Email,
                Username = u.Username
            }).ToListAsync();
    }

    public async Task<OperationResult> CreateUserAsync(UserDetailViewModel userViewModel, bool returnCreatedRecord = false)
    {
        var user = new UserDetail
        {
            Name = userViewModel.Name,
            Email = userViewModel.Email,
            Username = userViewModel.Username,
            Password = userViewModel.Password,
            CreatedDate = DateTime.UtcNow
        };

        _context.UserDetails.Add(user);
        await _context.SaveChangesAsync();

        return new OperationResult
        {
            Success = true,
            Data = returnCreatedRecord ? user : null
        };
    }

    public async Task<OperationResult> UpdateUserAsync(UserDetailViewModel userViewModel, bool returnUpdatedRecord = false)
    {
        var user = await _context.UserDetails.FindAsync(userViewModel.UserId);
        if (user == null)
            return new OperationResult { Success = false, Message = "User not found." };

        user.Name = userViewModel.Name;
        user.Email = userViewModel.Email;
        user.Username = userViewModel.Username;
        user.Password = userViewModel.Password;

        await _context.SaveChangesAsync();

        return new OperationResult
        {
            Success = true,
            Data = returnUpdatedRecord ? user : null
        };
    }

    public async Task<OperationResult> DeleteUserAsync(int userId)
    {
        var user = await _context.UserDetails.FindAsync(userId);
        if (user == null)
            return new OperationResult { Success = false, Message = "User not found." };

        user.Deleted = true;
        await _context.SaveChangesAsync();

        return new OperationResult { Success = true };
    }

    public async Task<UserDetailViewModel?> GetUserByIdAsync(int userId)
    {
        return await _context.UserDetails
            .Where(u => u.Id == userId && !u.Deleted)
            .Select(u => new UserDetailViewModel
            {
                UserId = u.Id,
                Name = u.Name,
                Email = u.Email,
                Username = u.Username
            }).FirstOrDefaultAsync();
    }
}
