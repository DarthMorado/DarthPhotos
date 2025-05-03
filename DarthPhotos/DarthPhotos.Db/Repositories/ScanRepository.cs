using DarthPhotos.Db.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarthPhotos.Db.Repositories
{
    public interface IScanRepository : IBaseRepository<ScannedEntity>
    {
        public Task<ScannedEntity?> GetByHashAsync(string hash, CancellationToken cancellationToken);
    }

    public class ScanRepository : BaseRepository<ScannedEntity>, IScanRepository
    {
        public ScanRepository(Database context)
            :base(context)
        {
            
        }

        public async Task<ScannedEntity?> GetByHashAsync(string hash, CancellationToken cancellationToken)
        {
            var result = await base._dbSet.Where(x => x.Hash == hash).ToListAsync(cancellationToken);
            return result.FirstOrDefault();
        }
    }
}
