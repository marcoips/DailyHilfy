using System.ComponentModel.DataAnnotations;

namespace DailyHilfy.Validation;

public class NotFutureDateAttribute : ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        if (value is not DateOnly date)
        {
            return false;
        }

        return date <= DateOnly.FromDateTime(DateTime.Today);
    }
}
