using System.ComponentModel.DataAnnotations.Schema;

namespace LedgerApi.Model
{
    public class Expenses
    {
        public int Id { get; set; }
        public Ledger Ledger { get; set; }
        public int Amount { get; set; }
        public int PaidByUserID { get; set; }
        [ForeignKey("PaidByUserID")]
        public User PaidByUser { get; set; }
        public string Description { get; set; }
        
    }
}