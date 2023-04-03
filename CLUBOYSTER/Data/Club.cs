namespace CLUBOYSTER.Data
{
    public class Club
    {
        public static float? TotalEarning { get; set; }

        public static float? TotalGrowth { get; set; }

        public static float? TotalCustomers { get; set; }

        public static float? AverageMonth { get; set; } = TotalEarning ;
    }
}
