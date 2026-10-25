namespace DailyHilfy.Models
{
    public class DailyEntry
    {
        public int Id { get; set; }

        public DateOnly Date { get; set; }

        public int WorkMinutes { get; set; }

        public string? WorkDescription { get; set; }

        public int ExerciseMinutes { get; set; }

        public string? ExerciseDescription { get; set; }

        public decimal? FinanceAmount { get; set; }

        public string? FinanceType { get; set; }

        public string? FinanceDescription { get; set; }

        public string? Notes { get; set; }
    }
}

