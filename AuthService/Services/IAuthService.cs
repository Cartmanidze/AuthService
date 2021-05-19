using System.Threading.Tasks;
using AuthService.Models;
using Microsoft.AspNetCore.Mvc;

namespace AuthService.Services
{
    public interface  IAuthService
    {
        Task<ObjectResult> SignUp(SignUpModel signUpModel);
        Task<ObjectResult> Login(LoginModel loginModel);
    }
}
