using UsersServiceForTesting.Api.Data;
using UsersServiceForTesting.Api.Repositories;

namespace UsersServiceForTesting.ApiTests.Services;

public class MockUserRepository : IUsersRepository
{
    private readonly List<UserEntity> _users = new List<UserEntity>()
    {
        new UserEntity()
        {
            Id = 1,
            Name = "user1"
        }
    };

    public UserEntity? GetUser(int id)
    {
        return _users.FirstOrDefault(u => u.Id == id);
    }

    public void AddUser(UserEntity userEntity)
    {
        _users.Add(userEntity);
    }
}