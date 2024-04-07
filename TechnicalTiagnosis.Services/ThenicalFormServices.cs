using TechnicalTiagnosis.Core.Contracts.Repositories;
using TechnicalTiagnosis.Core.Contracts.Service;

namespace TechnicalTiagnosis.Services;

public class ThenicalFormServices : IThenicalFormServices
{
    private readonly IThenicalFormRepository _henicalFormRepository;

    public ThenicalFormServices(IThenicalFormRepository henicalFormRepository)
    {
        _henicalFormRepository = henicalFormRepository;
    }

    public int Capacity(DateOnly date) => _henicalFormRepository.Capacity(date);
}
