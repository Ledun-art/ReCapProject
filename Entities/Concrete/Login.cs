using Entities.Abstract;

namespace Entities.Concrete
{
    public class Login : IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}