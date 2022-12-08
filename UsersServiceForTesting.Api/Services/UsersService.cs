using UsersServiceForTesting.Api.Data;
using UsersServiceForTesting.Api.Dto;
using UsersServiceForTesting.Api.Repositories;

namespace UsersServiceForTesting.Api.Services;

public class UsersService
{
    //private readonly AppDbContext _context;
    private readonly IUsersRepository _usersRepository;

    public UsersService(IUsersRepository usersRepository)
    {
        _usersRepository = usersRepository;
    }
    
    public UserDto? GetUser(int id)
    {
        //get data from database
        //var user = _context.Users.First(u => u.Id == id);
        var user = _usersRepository.GetUser(id);
        if (user is null)
            return null;

        //mapper logic
        return new UserDto()
        {
            Name = user.Name,
        };
    }

    public void AddUser(UserDto userDto)
    {
        //mapper logic
        var user = new UserEntity()
        {
            Name = userDto.Name
        };
        
        //more logics

        //save entity to database
        
        //_context.Users.Add(user);
        //_context.SaveChanges();

        _usersRepository.AddUser(user);
    }

    public int Sum(int a, int b) => a + b;
}