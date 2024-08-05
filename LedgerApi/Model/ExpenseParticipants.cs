using System.ComponentModel.DataAnnotations.Schema;

namespace LedgerApi.Model
{
    public class ExpenseParticipants
    {
        public int Id { get; set; }
        public int ExpenseID { get; set; }
        [ForeignKey("ExpenseID")]
        public Expenses Expenses { get; set; }
        public string ParticipantUserID { get; set; }
        public int Share {  get; set; }
    }
}
