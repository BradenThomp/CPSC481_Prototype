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

        public Boolean removeFromWishlist (LibraryItem item, User user)
        {
            Console.WriteLine("got to the function");
            int index = 0;
            foreach (var wish in user.Wishlist.ToList())
            {
                if (wish.Id == item.Id)
                {
                    user.Wishlist.RemoveAt(index);
                    return true;
                }
                index = index + 1;
            }
            return false;

        }

        public Boolean removeFromHold(LibraryItem item, User user)
        {
            int index = 0;
            foreach (var hold in user.OnHold.ToList())
            {
                if (hold.Id == item.Id)
                {
                    user.OnHold.RemoveAt(index);
                    return true;
                }
                index = index + 1;
            }
            return false;

        }




    }
}
