using System.Text.Json;

namespace CPSC481_Prototype.Models
{
    public class User
    {
        public int Id { get; init; }

        public string ImageSource { get; init; }

        public string Title { get; init; }

        public string Author { get; init; }

        public string Length { get; init; }

        public string Format { get; init; }

        public string Publisher { get; init; }

        public string PublicationDate { get; init; }

        public string Summary { get; init; } 

        public List<string> Genres { get; init; }

        public int CopiesAvailable { get; init; }

        public double DeweyDecimal { get; init; }

        public List<LibraryItem> SimilarItems { get; init; }

        public string GetJson()
        {
            var json = JsonSerializer.Serialize(this);
            return json;
        }
    }
}
