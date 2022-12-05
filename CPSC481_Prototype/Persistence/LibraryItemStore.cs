using CPSC481_Prototype.Models;

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
                if (i.Value.GetJson().Contains(searchTerm, System.StringComparison.CurrentCultureIgnoreCase))
                {
                    results.Add(i.Value);
                }
            }
            return results;
        }

        public IEnumerable<LibraryItem> GetSimilarItems(LibraryItem srcItem)
        {
            List<SimilarItem> similarItems = new List<SimilarItem>();
            foreach(var item in _store.Values)
            {
                SimilarItem current = new SimilarItem
                {
                    Item = item,
                    SimilarityScore = 0,
                };

                foreach (var genre in item.Genres)
                {
                    if(srcItem.Genres.Contains(genre) && srcItem.Id != item.Id)
                    {
                        current.SimilarityScore++;
                    }
                }
                if(current.SimilarityScore > 0)
                {
                    similarItems.Add(current);
                }
            }
            return similarItems.OrderByDescending(i => i.SimilarityScore).Take(10).Select(i => i.Item);
        }

        internal class SimilarItem
        {
            public LibraryItem Item { get; set; }

            public int SimilarityScore { get; set; } = 0;
        }
    }
}
