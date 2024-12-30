using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
public class CorrespondenceDbContext : DbContext
{
    public CorrespondenceDbContext(DbContextOptions<CorrespondenceDbContext> options) : base(options) { }
    
    private DbSet<ICorrespondence> correspondences { get; set; }
    
    public async Task<DbSet<ICorrespondence>> GetCorrespondences() => correspondences;

    public async Task AddCorrespondence(ICorrespondence correspondence)
    {
        if (correspondences == null)
        {
            throw new Exception("Correspondence is null");
        }
        
        await correspondences.AddAsync(correspondence);
    }

    public async Task RemoveCorrespondence(ICorrespondence correspondence)
    {
        if (correspondences == null)
        {
            throw new Exception("Correspondence is null");
        }
        
        correspondences.Remove(correspondence);
    }

    public async Task UpdateCorrespondence(ICorrespondence correspondenceToUpdate, ICorrespondence correspondence)
    {
        if (correspondence == null)
        {
            throw new Exception("Correspondence is null");
        }

        ICorrespondence _correspondenceToUpdate =
            await correspondences.FirstOrDefaultAsync(_corespondence => _corespondence == correspondenceToUpdate);

        if (_correspondenceToUpdate == null)
        {
            throw new Exception("Correspondence not found");
        }

        _correspondenceToUpdate = correspondence;
    }
}