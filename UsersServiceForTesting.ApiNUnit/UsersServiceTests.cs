using UsersServiceForTesting.Api.Services;

namespace UsersServiceForTesting.ApiNUnit
{
    public class UsersServiceTests
    {
        private MockUserRepository mockUserRepository;
        private UsersService userService;

        [SetUp]
        public void Sestsup()
        {
            mockUserRepository = new MockUserRepository();
        }

        [SetUp]
        public void Setsup()
        {
            userService = new UsersService(mockUserRepository);
        }

        [Test]
        public void GetUserTest()
        {
            var user = userService.GetUser(1);
            Assert.NotNull(user);

            var user2 = userService.GetUser(2);
            Assert.Null(user2);
        }


        [Theory] //TestMethod
        [TestCase(2, 4, 6)]
        [TestCase(2, 4, 8)]
        public void SumTest(int n1, int n2, int sum)
        {
            var mockUserRepository = new MockUserRepository();
            var userService = new UsersService(mockUserRepository);

            var _sum = userService.Sum(n1, n2);

            Assert.AreEqual(_sum, sum);
        }
    }
}