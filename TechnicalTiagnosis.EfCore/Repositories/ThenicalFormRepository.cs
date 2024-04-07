using TechnicalTiagnosis.Core.Contracts.Repositories;

namespace TechnicalTiagnosis.EfCore.Repositories;
public class ThenicalFormRepository : IThenicalFormRepository
{
    private readonly AppDbContext _context;

    public ThenicalFormRepository(AppDbContext context)
    {
        _context = context;
    }

    public int Capacity(DateOnly date)
    {
        var count = _context.TechnicalForms
            .Count(x => x.CreateAt == date);

        return count;
    }
}