using TechnicalTiagnosis.Core.Contracts.Service;

namespace TechnicalTiagnosis.Services;
public class BaseServices : IBaseServices
{
    public bool IsEven(DateOnly date)
    {
        var dayOfWeek = date.DayOfWeek;

        return dayOfWeek switch
        {
            DayOfWeek.Sunday => false,
            DayOfWeek.Monday => true,
            DayOfWeek.Tuesday => false,
            DayOfWeek.Wednesday => true,
            DayOfWeek.Thursday => false,
            DayOfWeek.Friday => false,
            DayOfWeek.Saturday => true,
            _ => false
        };
    }

    public bool IsValidForSubmit(DateOnly date) => date > new DateOnly().AddYears(-5);
}
