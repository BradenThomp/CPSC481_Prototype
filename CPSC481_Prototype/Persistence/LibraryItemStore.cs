using System.Linq;
using System.Text.Json;
using CPSC481_Prototype.Models;
using static CPSC481_Prototype.Pages.FetchData;

namespace CPSC481_Prototype.Persistence
{
    public class LibraryItemStore
    {
        private Dictionary<int, LibraryItem> _store;

        public LibraryItemStore()
        {
            LibraryItemStoreDataSource src = new LibraryItemStoreDataSource();
            _store = src.GetData();
        }

        public LibraryItem Get(int id)
        {
            return _store[id];
        }

        public List<LibraryItem> Search (string searchTerm)
        {
            List<LibraryItem> results = new List<LibraryItem>();
            foreach (var i in _store)
            {
                if (i.Value.GetJson().Contains(searchTerm))
                {
                    results.Add(i.Value);
                }
            }
            return results;
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
