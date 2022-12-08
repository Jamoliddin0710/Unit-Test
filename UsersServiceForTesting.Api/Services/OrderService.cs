using UsersServiceForTesting.Api.Data;

namespace UsersServiceForTesting.Api.Services;

public class OrderService
{
    private readonly AppDbContext _appDbContext;

    public OrderService(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public void CreateOrder(int userId, string orderDetails, int product)
    {
        var order = new object();
        var user = _appDbContext.Users.First(u => u.Id == userId);
    }
}