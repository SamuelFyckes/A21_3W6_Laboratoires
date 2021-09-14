using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZombieParty_DataAccess.Data;
using ZombieParty_DataAccess.Repository.IRepository;
using ZombieParty_Models;

namespace ZombieParty_DataAccess.Repository
{
  class ForceLevelRepository : Repository<ForceLevel>, IForceLevelRepository
  {
    private readonly ZombiePartyDbContext _db;

    public ForceLevelRepository(ZombiePartyDbContext db) : base(db)
    {
      _db = db;
    }

    public void Update(ForceLevel forceLevel)
    {
      _db.Update(forceLevel);

    }
  }
}
