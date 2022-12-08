using UsersServiceForTesting.Api.Services;

namespace UsersServiceForTesting.ApiXUnit
{
    public class UsersServiceTests
    {
        [Fact] //TestMethod
        public void GetUserTest()
        {
            MockUserRepository mockUserRepository = new();
            UsersService userService = new(mockUserRepository);

            Api.Dto.UserDto? user = userService.GetUser(1);
            Assert.NotNull(user);

            Api.Dto.UserDto? user2 = userService.GetUser(2);
            Assert.Null(user2);
        }

        [Theory] //TestMethod
        [InlineData(2, 4, 6)]
        [InlineData(2, 4, 8)]
        public void SumTest(int n1, int n2, int sum)
        {
            MockUserRepository mockUserRepository = new();
            UsersService userService = new(mockUserRepository);

            int _sum = userService.Sum(n1, n2);
            Assert.Equal(_sum, sum);
        }
    }
}