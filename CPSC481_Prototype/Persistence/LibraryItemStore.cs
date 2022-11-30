using CPSC481_Prototype.Models;

namespace CPSC481_Prototype.Persistence
{
    public class LibraryItemStore
    {
        private static Dictionary<int, LibraryItem> _store;

        public LibraryItemStore()
        {
            LibraryItemStoreDataSource src = new LibraryItemStoreDataSource();
            _store = src.GetData();
        }

        public static LibraryItem Get(int id)
        {
             return _store[id]; 
        }

        public List<LibraryItem> Search(string searchTerm)
        {
            return _store.Values.ToList();
        }

        public List<LibraryItem> GetSimilarItems(LibraryItem srcItem)
        {
            List<LibraryItem> result = new List<LibraryItem>();
            foreach(var item in _store.Values)
            {
                foreach(var genre in item.Genres)
                {
                    if(srcItem.Genres.Contains(genre) && srcItem.Id != item.Id)
                    {
                        result.Add(item);
                        break;
                    }
                }
                if(result.Count >= 10)
                {
                    break;
                }
            }
            return result;
        }
    }
}
