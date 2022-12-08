using UsersServiceForTesting.Api.Data;
using UsersServiceForTesting.Api.Dto;

namespace UsersServiceForTesting.Api.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly AppDbContext _context;

        public UsersRepository(AppDbContext context) => _context = context;

        public UserEntity GetUser(int id)
        {
            //get data from database
            return _context.Users.First(u => u.Id == id);
        }

        public void AddUser(UserEntity userEntity)
        {
            //save entity to database
            _context.Users.Add(userEntity);
            _context.SaveChanges();
        }
    }
}
