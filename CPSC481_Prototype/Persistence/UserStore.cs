using CPSC481_Prototype.Models;

namespace CPSC481_Prototype.Persistence
{
    public class UserStore
    {
        private static Dictionary<int, User> _store;

        public UserStore()
        {
            UserStoreDataSource src = new UserStoreDataSource();
            _store = src.GetData();
        }

        public static User Get(int id)
        {
            return _store[id];
        }

        
    }
}
