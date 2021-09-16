using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZombieParty_Models;
using ZombieParty_DataAccess.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ZombieParty_DataAccess.Repository.IRepository;

namespace ZombieParty.Controllers
{
  public class ZombieController : Controller
  {
    private readonly IUnitOfWork _unitOfWork;

    public ZombieController(IUnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    public IActionResult Index()
    {
      IEnumerable<Zombie> ZombieList = _unitOfWork.Zombie.GetAll();

      return View(ZombieList);
    }
  }
}
