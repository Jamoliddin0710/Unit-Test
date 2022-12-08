using UsersServiceForTesting.Api.Data;

namespace UsersServiceForTesting.Api.Repositories;

public interface IUsersRepository
{
    public UserEntity? GetUser(int id);

    public void AddUser(UserEntity userEntity);
}