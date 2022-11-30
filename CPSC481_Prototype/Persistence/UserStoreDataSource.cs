﻿using CPSC481_Prototype.Models;



namespace CPSC481_Prototype.Persistence
{
    public class UserStoreDataSource
    {
        private Dictionary<int, User> _store = new Dictionary<int, User>();

        public UserStoreDataSource()
        {
            Populate();
        }

        public Dictionary<int, User> GetData() => _store;

        
       

        private void Populate()
        {
            
            
            _store.Add(1, new User
            {
                Id = 1,
                ImageSource = "Images/ProfilePic.jpg",
                Name = "Harry Potter",
                LibraryId = "123456",
                Email = "harry@hogwarts.com",
                PhoneNum = "123-123-1234",
                Address = "4 Privet Drive, Little Whinging, Surrey",
                Wishlist = new List<LibraryItem>(){ LibraryItemStore.Get(1), LibraryItemStore.Get(4) },
                OnHold= new List<LibraryItem>() { LibraryItemStore.Get(3), LibraryItemStore.Get(2) },
                CheckedOut = new List<LibraryItem>() { LibraryItemStore.Get(5), LibraryItemStore.Get(6) }
            });;

            _store.Add(2, new User
            {
                Id = 2,
                ImageSource = "Images/ProfilePic2.jpg",
                Name = "Hermione Granger",
                LibraryId = "223456",
                Email = "harmione@hogwarts.com",
                PhoneNum = "223-123-1234",
                Address = "abc st NE, ABC",
                Wishlist = new List<LibraryItem>() { LibraryItemStore.Get(10), LibraryItemStore.Get(9) },
                OnHold = new List<LibraryItem>() { LibraryItemStore.Get(8), LibraryItemStore.Get(7) },
                CheckedOut = new List<LibraryItem>() { LibraryItemStore.Get(6), LibraryItemStore.Get(5) }
            });
        }
    }
}