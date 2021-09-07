using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZombieParty.Models
{
  public class HuntingLog
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }

    // Propriété de navigation vers zombieHuntingLog
    //OBLIGATOIRE Pour la relation 1 à plusieurs avec zombieHuntingLog
    public ICollection<ZombieHuntingLog> zombieHuntingLogs { get; set; }

   
  }
}
