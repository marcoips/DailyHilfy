using System.ComponentModel.DataAnnotations;
using DailyHilfy.Validation;

namespace DailyHilfy.DTOs;

public class CreateDailyEntryDto
{
    [NotFutureDate]
    public DateOnly Date { get; set; }

    [Range(0, 1440)]
    public int WorkMinutes { get; set; }

    [StringLength(500)]
    public string? WorkDescription { get; set; }

    [Range(0, 1440)]
    public int ExerciseMinutes { get; set; }

    [StringLength(500)]
    public string? ExerciseDescription { get; set; }

    [Range(typeof(decimal), "0", "999999999")]
    public decimal? FinanceAmount { get; set; }

    [RegularExpression(
        "^(Income|Expense)$",
        ErrorMessage = "FinanceType must be Income or Expense.")]
    public string? FinanceType { get; set; }

    [StringLength(500)]
    public string? FinanceDescription { get; set; }

    [StringLength(2000)]
    public string? Notes { get; set; }
}
