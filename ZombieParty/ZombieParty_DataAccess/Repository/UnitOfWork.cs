using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZombieParty_DataAccess.Data;
using ZombieParty_DataAccess.Repository.IRepository;

namespace ZombieParty_DataAccess.Repository
{
  public class UnitOfWork : IUnitOfWork
  {
    private readonly ZombiePartyDbContext _db;

    public UnitOfWork(ZombiePartyDbContext db)
    {
      _db = db;
      // Initialiser chaque repo.passant de DbContext en parametre
      //NomClasse = new NomClasseRepository(_db);
       Zombie = new ZombieRepository(_db);
       Category = new CategoryRepository(_db);
       ForceLevel = new ForceLevelRepository(_db);
       Hunter = new HunterRepository(_db);
       HuntingLog = new HuntingLogRepository(_db);
       Weapon = new WeaponRepository(_db);
       ZombieHuntingLog = new ZombieHuntingLogRepository(_db);
       ZombieType = new ZombieTypeRepository(_db);
    }

    // Creer une variable de type Interface du Repo. pour chaque repo.
    // INomClasseRepository NomClasse { get; private set; }
    public IZombieRepository Zombie { get; private set; }
    public ICategoryRepository Category { get; private set; }
    public IForceLevelRepository ForceLevel { get; private set; }
    public IHunterRepository Hunter { get; private set; }
    public IHuntingLogRepository HuntingLog { get; private set; }
    public IWeaponRepository Weapon { get; private set; }
    public IZombieHuntingLogRepository ZombieHuntingLog { get; private set; }
    public IZombieTypeRepository ZombieType { get; private set; }

    public void Dispose()
    {
      _db.Dispose();
    }

    public void Save()
    {
      _db.SaveChanges();
    }
  }
}