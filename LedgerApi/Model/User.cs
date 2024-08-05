using System.Text.Json.Serialization;

namespace LedgerApi.Model
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        [JsonIgnore]
        public ICollection<Ledger> Ledgers { get; set; }
        [JsonIgnore]
        public ICollection<Expenses> Expenses { get; set; }
    }
}
