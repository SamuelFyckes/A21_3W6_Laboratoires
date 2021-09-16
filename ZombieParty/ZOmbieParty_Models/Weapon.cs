using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZombieParty_Models
{
  public class Weapon
  {
    public int Id { get; set; }
    [StringLength(20)]
    public string TypeName { get; set; }
    [StringLength(50)]
    public string Description { get; set; }

  }
}
