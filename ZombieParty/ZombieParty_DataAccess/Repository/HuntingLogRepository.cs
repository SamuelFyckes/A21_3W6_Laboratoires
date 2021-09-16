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
  class HuntingLogRepository : Repository<HuntingLog>, IHuntingLogRepository
  {
    private readonly ZombiePartyDbContext _db;

    public HuntingLogRepository(ZombiePartyDbContext db) : base(db)
    {
      _db = db;
    }

    public void Update(HuntingLog huntingLog)
    {
      _db.Update(huntingLog);

    }
  }
}
