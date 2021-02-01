using System;
using Entities.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class LoginValidationManager : ILoggin
    {
        public void Validate(Login login)
        {
            Back:
            Console.WriteLine("Enter your name");
            login.FirstName = Console.ReadLine();
            Console.WriteLine("Enter your surname");
            login.LastName = Console.ReadLine();
            if (login.FirstName == "Tarik" && login.LastName == "Pinar")
            {
                Console.WriteLine("Login successful");
            }
            else
            {
                goto Back;
            }
        }
    }
}