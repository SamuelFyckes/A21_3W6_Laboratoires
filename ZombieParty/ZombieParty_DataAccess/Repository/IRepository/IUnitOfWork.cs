using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieParty_DataAccess.Repository.IRepository
{
  public interface IUnitOfWork : IDisposable
  {
    IZombieRepository Zombie { get; }
    ICategoryRepository Category { get; }
    IForceLevelRepository ForceLevel { get; }
    IHunterRepository Hunter { get; }
    IHuntingLogRepository HuntingLog { get; }
    IWeaponRepository Weapon { get; }
    IZombieHuntingLogRepository ZombieHuntingLog { get; }
    IZombieTypeRepository ZombieType { get; }

    void Save();
  }
}
