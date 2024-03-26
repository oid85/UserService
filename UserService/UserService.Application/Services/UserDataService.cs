using Microsoft.EntityFrameworkCore;
using UserService.DataAccess.Db;
using UserService.Domain.Entities;

namespace UserService.Application.Services
{
    public class UserDataService
    {
        private readonly ApplicationDbContext _context;

        public UserDataService(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Выбрать пользователя (с его тегами) по его Id и Domain
        /// </summary>
        /// <param name="userId">Guid пользователя</param>
        /// <param name="domain">Имя домена</param>
        /// <returns></returns>
        public async Task<User> GetUserByIdAndDomainAsync(Guid userId, string domain)
        {
            var result = await _context.Users
                .Include(user => user.TagToUsers!)
                    .ThenInclude(tagToUser => tagToUser.Tag)
                .FirstOrDefaultAsync(user => user.Id == userId && user.Domain == domain);

            return result;
        }

        /// <summary>
        /// Выбрать всех пользователей (с их тегами) одного Domain, используя pagination
        /// </summary>
        /// <param name="domain">Имя домена</param>
        /// <param name="page">Номер страницы</param>
        /// <param name="pageSize">Размер страницы</param>
        /// <returns></returns>
        public async Task<List<User>> GetUsersByDomainAsync(string domain, int page, int pageSize)
        {
            var result = await _context.Users
                .Include(user => user.TagToUsers)!
                    .ThenInclude(tagToUser => tagToUser.Tag)
                .Where(user => user.Domain == domain)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return result;
        }

        /// <summary>
        /// Выбрать всех пользователей по значению тега (которые имеют данный тег) и Domain
        /// </summary>
        /// <param name="tagValue">Имя тега</param>
        /// <param name="domain">Имя домена</param>
        /// <returns></returns>
        public async Task<List<User>> GetUsersByTagAndDomainAsync(string tagValue, string domain)
        {
            var result = await _context.Users
                .Include(user => user.TagToUsers)!
                    .ThenInclude(tagToUser => tagToUser.Tag)
                .Where(user => user.TagToUsers!.Any(tu => tu.Tag!.Value == tagValue) && user.Domain == domain)
                .ToListAsync();

            return result;
        }
    }
}
