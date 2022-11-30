using System.Collections.Generic;
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

        public static User GetAcct(string acctId)
        {
            foreach (var item in _store.Values)
            {
                if (acctId == item.LibraryId)
                {
                    return item;
                }  
            }
            return _store[1];
        }

        public List<LibraryItem> GetWishlist(User user)
        {
            return user.Wishlist;
            
        }

        public List<LibraryItem> GetOnHold(User user)
        {
            return user.OnHold;

        }

        public List<LibraryItem> GetCheckedOut(User user)
        {
            return user.CheckedOut;

        }




    }
}
