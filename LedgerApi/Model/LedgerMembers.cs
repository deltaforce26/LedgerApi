namespace LedgerApi.Model
{
    public class LedgerMembers
    {
        public int Id { get; set; }
        public Ledger Ledger { get; set; }
        public User User { get; set; }
    }
}
