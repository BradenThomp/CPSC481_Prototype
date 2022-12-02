using CPSC481_Prototype.Models;


namespace CPSC481_Prototype.Persistence
{
    public class UserStoreDataSource
    {
        private Dictionary<int, User> _store = new Dictionary<int, User>();

        public UserStoreDataSource()
        {
            LibraryItemStore libraryItems = new LibraryItemStore();
            libraryItem1 = libraryItems.Get(1);
            libraryItem2 = libraryItems.Get(2);
            libraryItem3 = libraryItems.Get(3);
            libraryItem4 = libraryItems.Get(4);
            libraryItem5 = libraryItems.Get(5);
            libraryItem6 = libraryItems.Get(6);
            libraryItem7 = libraryItems.Get(7);
            libraryItem8 = libraryItems.Get(8);
            Populate();
            
        }

        public Dictionary<int, User> GetData() => _store;


        // For wishlist, onhold and checkedout
        LibraryItem libraryItem1;
        LibraryItem libraryItem2;
        LibraryItem libraryItem3;
        LibraryItem libraryItem4;
        LibraryItem libraryItem5;
        LibraryItem libraryItem6;
        LibraryItem libraryItem7;
        LibraryItem libraryItem8;

       

        private void Populate()
        {
            _store.Add(1, new User
            {
                Id = 1,
                ImageSource = "Images/ProfilePic.jpg",
                Name = "Harry Potter",
                LibraryId = "123456",
                Password = "123456",
                Email = "harry@hogwarts.com",
                PhoneNum = "123-123-1234",
                Address = "4 Privet Drive, Little Whinging, Surrey",
                Wishlist = new List<LibraryItem>(){ libraryItem1, libraryItem2 },
                OnHold= new List<LibraryItem>() { libraryItem3, libraryItem4 },
                CheckedOut = new List<LibraryItem>() { libraryItem5, libraryItem6 }
            });;

            _store.Add(2, new User
            {
                Id = 2,
                ImageSource = "Images/ProfilePic2.jpg",
                Name = "Hermione Granger",
                LibraryId = "223456",
                Password = "223456",
                Email = "harmione@hogwarts.com",
                PhoneNum = "223-123-1234",
                Address = "abc st NE, ABC",
                Wishlist = new List<LibraryItem>() { libraryItem7, libraryItem8 },
                OnHold = new List<LibraryItem>() { libraryItem6, libraryItem5 },
                CheckedOut = new List<LibraryItem>() { libraryItem4, libraryItem3 }
            });
        }
    }
}
