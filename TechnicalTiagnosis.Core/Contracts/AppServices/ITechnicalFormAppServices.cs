using TechnicalTiagnosis.Core.Entities;

namespace TechnicalTiagnosis.Core.Contracts.AppServices;
public interface ITechnicalFormAppServices
{
    List<string> Create(TechnicalForm model);
}