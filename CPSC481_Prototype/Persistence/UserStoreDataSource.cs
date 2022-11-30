using CPSC481_Prototype.Models;


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


        // For wishlist, onhold and checkedout
        LibraryItem libraryItem1;
        LibraryItem libraryItem2;
        LibraryItem libraryItem3;
        LibraryItem libraryItem4;
        LibraryItem libraryItem5;
        LibraryItem libraryItem6;
        LibraryItem libraryItem7;
        LibraryItem libraryItem8;

        public LibraryItem LibraryItem1 { get => libraryItem1; set => libraryItem1 = LibraryItemStore.Get(1); }
        public LibraryItem LibraryItem2 { get => libraryItem2; set => libraryItem2 = LibraryItemStore.Get(2); }
        public LibraryItem LibraryItem3 { get => libraryItem3; set => libraryItem3 = LibraryItemStore.Get(3); }
        public LibraryItem LibraryItem4 { get => libraryItem4; set => libraryItem4 = LibraryItemStore.Get(4); }
        public LibraryItem LibraryItem5 { get => libraryItem5; set => libraryItem5 = LibraryItemStore.Get(5); }
        public LibraryItem LibraryItem6 { get => libraryItem6; set => libraryItem6 = LibraryItemStore.Get(6); }
        public LibraryItem LibraryItem7 { get => libraryItem7; set => libraryItem7 = LibraryItemStore.Get(7); }
        public LibraryItem LibraryItem8 { get => libraryItem8; set => libraryItem8 = LibraryItemStore.Get(8); }

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
                Wishlist = new List<LibraryItem>(){ LibraryItem1, LibraryItem2 },
                OnHold= new List<LibraryItem>() { LibraryItem3, LibraryItem4 },
                CheckedOut = new List<LibraryItem>() { LibraryItem5, LibraryItem6 }
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
                Wishlist = new List<LibraryItem>() { LibraryItem7, LibraryItem8 },
                OnHold = new List<LibraryItem>() { LibraryItem6, LibraryItem5 },
                CheckedOut = new List<LibraryItem>() { LibraryItem4, LibraryItem3 }
            });
        }
    }
}
