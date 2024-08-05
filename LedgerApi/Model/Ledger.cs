using System.Text.Json.Serialization;

namespace LedgerApi.Model
{
    public class Ledger
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateOnly DateCreated { get; set; }
        [JsonIgnore]
        public ICollection<User> Users { get; set; }
        [JsonIgnore]
        public ICollection<Expenses> Transactions { get; set; }
    }
}
