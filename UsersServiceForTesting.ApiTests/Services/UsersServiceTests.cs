using Microsoft.VisualStudio.TestTools.UnitTesting;
using UsersServiceForTesting.Api.Data;
using UsersServiceForTesting.Api.Dto;
using UsersServiceForTesting.Api.Repositories;
using UsersServiceForTesting.Api.Services;

namespace UsersServiceForTesting.ApiTests.Services;

[TestClass]
public class UsersServiceTests
{
    [TestMethod]
    public void AddUserTest()
    {
        /*var context = new AppDbContext();
        var userRepository = new UsersRepository(context);*/
        var mockUserRepository = new MockUserRepository();
        var userService = new UsersService(mockUserRepository);

        try
        {
            userService.AddUser(new UserDto());
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw new Exception("Can not add user");
        }
    }

    [TestMethod()]
    public void GetUserTest()
    {
        var mockUserRepository = new MockUserRepository();
        var userService = new UsersService(mockUserRepository);
        
        var user = userService.GetUser(1);
        //ExceptionsContainer.IsNotNull(user);
        Assert.IsNotNull(user);

        var user2 = userService.GetUser(2);
        //ExceptionsContainer.IsNull(user2);
        Assert.IsNull(user2);

        var sum = userService.Sum(2, 4);
        //ExceptionsContainer.IsNotNull(sum);
        Assert.IsNotNull(sum);

        //ExceptionsContainer.IsEqual(sum, 6);
        Assert.AreEqual(sum, 6);
    }
}

public static class ExceptionsContainer
{
    public static void IsNotNull(object? obj)
    {
        if (obj is null)
        {
            throw new Exception("obj is null");
        }
    }

    public static void IsEqual(int a, int b)
    {
        if (a != b)
        {
            throw new Exception("not equals");
        }
    }

    public static void IsNull(object? obj)
    {
        if (obj is not null)
        {
            throw new Exception("obj is not null");
        }
    }
}