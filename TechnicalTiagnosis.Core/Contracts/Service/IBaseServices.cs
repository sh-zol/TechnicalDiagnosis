namespace TechnicalTiagnosis.Core.Contracts.Service;
public interface IBaseServices
{
    bool IsEven(DateOnly date);
    bool IsValidForSubmit(DateOnly date);
}