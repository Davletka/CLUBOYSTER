namespace CLUBOYSTER.Data
{
    public class Transactions
    {
        public string? Type { get; set; }
        public DateTime? Time { get; set; }

        public  User? User { get; set; }

        public float? Sum { get; set; }
    }
}
