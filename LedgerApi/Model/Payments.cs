using System.ComponentModel.DataAnnotations.Schema;

namespace LedgerApi.Model
{
    public class Payments
    {
        public int Id { get; set; }
        public int PayerID { get; set; }
        [ForeignKey("PayerID")]
        public User Payer { get; set; }
        public int PayeeID { get; set; }
        [ForeignKey("PayeeID")]
        public User Payee { get; set; }
        public int Amount { get; set; }
    }
}
