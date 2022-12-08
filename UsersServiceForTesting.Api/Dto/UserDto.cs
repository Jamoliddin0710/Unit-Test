using System.ComponentModel.DataAnnotations;

namespace UsersServiceForTesting.Api.Dto
{
    public class UserDto
    {
        [Required]
        public string? Name { get; set; }
    }
}
