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
  class WeaponRepository : Repository<Weapon>, IWeaponRepository
  {
    private readonly ZombiePartyDbContext _db;

    public WeaponRepository(ZombiePartyDbContext db) : base(db)
    {
      _db = db;
    }

    public void Update(Weapon weapon)
    {
      _db.Update(weapon);

    }
  }
}
