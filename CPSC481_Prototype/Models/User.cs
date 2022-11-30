using System.Text.Json;

namespace CPSC481_Prototype.Models
{
    public class User
    {
        public int Id { get; init; }

        public string ImageSource { get; init; }

        public string Name { get; init; }

        public string LibraryId { get; init; }

        public string Email { get; init; }

        public string PhoneNum { get; init; }

        public string Address { get; init; }

        public List<LibraryItem> Wishlist { get; init; }

        public List<LibraryItem> OnHold { get; init; }

        public List<LibraryItem> CheckedOut { get; init; }

        public string GetJson()
        {
            var json = JsonSerializer.Serialize(this);
            return json;
        }
    }
}
