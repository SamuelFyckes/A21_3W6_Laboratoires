using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZombieParty_Models;

namespace ZombieParty_DataAccess.Repository.IRepository
{
  public interface IForceLevelRepository : IRepository<ForceLevel>
  {
    void Update(ForceLevel forceLevel);
  }
}
