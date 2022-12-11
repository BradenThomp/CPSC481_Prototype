using System.Collections.Generic;
using CPSC481_Prototype.Models;

namespace CPSC481_Prototype.Persistence
{
    public class UserStore
    {
        private Dictionary<string, User> _store;

        public UserStore()
        {
            UserStoreDataSource src = new UserStoreDataSource();
            _store = src.GetData();
        }

        public User Get(string id)
        {
            Console.WriteLine(_store);
            if (_store.ContainsKey(id))
            {
                return _store[id];
            }
            return null;
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
            item.CopiesAvailable++;
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

        public void addToWishlist (LibraryItem item, User user)
        {
            user.Wishlist.Add(item);
        }

        public void addToHold (LibraryItem item, User user)
        {
            item.CopiesAvailable--;
            user.OnHold.Add(item);
        }

        public bool isOnHold (LibraryItem item, User user)
        {
            foreach (var hold in user.OnHold.ToList())
            {
                if (hold.Id == item.Id)
                {
                    return true;
                }
            }
            return false;

        }

        public bool isInWishlist (LibraryItem item, User user)
        {
            foreach (var wish in user.Wishlist.ToList())
            {
                if (wish.Id == item.Id)
                {
                    return true;
                }
            }
            return false;

        }




    }
}
