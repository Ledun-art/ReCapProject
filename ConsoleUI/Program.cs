using ConsoleUI.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            LoginManager loginManager = new LoginManager();
            loginManager.UserLogin();

            //Main Menu
            MenuManager menuManager = new MenuManager();
            menuManager.Menu();
        }
    }
}