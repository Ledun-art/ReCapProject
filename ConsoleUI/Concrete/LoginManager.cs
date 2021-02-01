using Business.Concrete;
using Entities.Concrete;

namespace ConsoleUI.Concrete
{
    public class LoginManager
    {
        public void UserLogin()
        {
            LoginValidationManager loginValidationManager = new LoginValidationManager();
            loginValidationManager.Validate(new Login());
        }
    }
}