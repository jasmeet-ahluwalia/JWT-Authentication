using Microsoft.AspNetCore.Mvc;
using JWT_Authentication.Models;

namespace JWT_Authentication.Interfaces
{
    public interface IUser
    {
        public Task<ActionResult<Users>> Authenticate(LoginUser userObj);
        public Task<bool> RegisterUser(Users userobj);

        public Task<bool> CheckUsernameExists(string username);

        public Task<bool> CheckEmailExists(string email);

        public Task<List <UserData>> GetUsers();

    }
}
