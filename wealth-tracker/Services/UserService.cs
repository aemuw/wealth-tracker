using BCrypt.Net;
using Microsoft.EntityFrameworkCore;
using wealth_tracker.Data;
using wealth_tracker.Models;

namespace wealth_tracker.Services
{
    public class UserService
    {
        private readonly AppDbContext _context;

        public AppUser? CurrentUser { get; private set; }
        public bool IsLoggedIn => CurrentUser != null;
        public bool IsAdmin => CurrentUser?.Role == UserRole.Admin;
        public bool IsParent => CurrentUser?.Role is UserRole.Admin;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public async Task EnsureAdminExistsAsync()
        {
            if (!await _context.Users.AnyAsync())
            {
                var admin = new AppUser
                {
                    Username = "admin",
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("admin123"),
                    Role = UserRole.Admin,
                    IsActive = true
                };

                _context.Users.Add(admin);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> LoginAsync(string username, string password)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Username == username && u.IsActive);

            if (user == null)
                return false;
            if (!BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
                return false;

            CurrentUser = user;
            return true;
        }

        public void Logout() => CurrentUser = null;
        public async Task<List<AppUser>> GetAllUsersAsync()
            => await _context.Users.OrderBy(u => u.Username).ToListAsync();

        public async Task<List<AppUser>> GetChildrenAsync()
        {
            if (CurrentUser == null)
                return new();
            return await _context.Users
                .Where(u => u.ParentId == CurrentUser.Id && u.IsActive)
                .ToListAsync();
        }

        public async Task<AppUser> CreateUserAsync(string username, string password, UserRole role, Guid? parentId = null)
        {
            if (await _context.Users.AnyAsync(u => u.Username == username))
                throw new InvalidOperationException($"Користувач '{username}' вже існує");
            var user = new AppUser
            {
                Username = username,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(password),
                Role = role,
                ParentId = parentId,
                IsActive = true
            };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task ChangePasswordAsync(Guid userId, string newPassword)
        {
            var user = await _context.Users.FindAsync(userId) ?? throw new InvalidOperationException("Користувача не знайдено");
            user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(newPassword);
            await _context.SaveChangesAsync();
        }

        public async Task ChangeRoleAsync(Guid userId, UserRole newRole)
        {
            var user = await _context.Users.FindAsync(userId) ?? throw new InvalidOperationException("Користувача не знайдено");
            if (user.Id == CurrentUser?.Id && newRole != UserRole.Admin) throw new InvalidOperationException("Не можна знизити власну роль адміна");
            user.Role = newRole;
            await _context.SaveChangesAsync();
        }

        public async Task DeactivateUserAsync(Guid userId)
        {
            var user = await _context.Users.FindAsync(userId) ?? throw new InvalidOperationException("Користувача не знайдено");
            if (user.Id == CurrentUser?.Id) throw new InvalidOperationException("Не можна видалити власний акаунт");
            user.IsActive = false;
            await _context.SaveChangesAsync();
        }

        public bool CanViewUser(Guid targetUserId)
        {
            if (CurrentUser == null)
                return false;
            if (IsAdmin)
                return true;
            if (CurrentUser.Id == targetUserId)
                return true;
            if (IsParent)
            {
                var target = _context.Users.Find(targetUserId);
                return target?.ParentId == CurrentUser.Id;
            }
            return false;
        }
    }
}
