using CPSC481_Prototype.Persistence;
using CPSC481_Prototype.Models;

namespace CPSC481_Prototype.Services
{
    public class LoginService
    {
        private readonly UserStore _userStore;
        public LoginService()
        {
            _userStore = new UserStore();
        }

        public bool IsLoggedIn => CurrentUser != null;
        public User CurrentUser { get; set; }

        public bool Login(string id, string password)
        {
            var user = _userStore.Get(id);
            Console.WriteLine(user);
            if (user == null)
            {
                return false;
            }
            if(user.Password != password)
            {
                return false;
            }


            CurrentUser = user;
            return true;
        }

        public void Logout()
        {
            CurrentUser = null;
        }
    }
}
