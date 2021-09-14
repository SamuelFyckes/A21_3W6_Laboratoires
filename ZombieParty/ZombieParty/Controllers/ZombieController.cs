using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZombieParty_Models;
using ZombieParty_DataAccess.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ZombieParty.Controllers
{
  public class ZombieController : Controller
  {
    private readonly ZombiePartyDbContext _db;

    public ZombieController(ZombiePartyDbContext db)
    {
      _db = db;
    }

    public IActionResult Index()
    {
     
      return View();
    }
  }
}
