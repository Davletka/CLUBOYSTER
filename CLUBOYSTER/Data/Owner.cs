namespace CLUBOYSTER.Data
{
    public class Owner : User
    {
        public float? TotalEarning { get; set; } = 0;

        public float? TotalCustomers { get; set; } = 0;

        public float? AverageMonth { get; set; } = 0;

    }
}
