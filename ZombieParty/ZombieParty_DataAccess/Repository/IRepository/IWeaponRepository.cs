using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZombieParty_Models;

namespace ZombieParty_DataAccess.Repository.IRepository
{
  public interface IWeaponRepository : IRepository<Weapon>
  {
    void Update(Weapon weapon);
  }
}
