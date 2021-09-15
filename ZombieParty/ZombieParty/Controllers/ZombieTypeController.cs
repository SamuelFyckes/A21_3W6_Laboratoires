using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZombieParty_DataAccess.Repository.IRepository;
using ZombieParty_Models;

namespace ZombieParty.Controllers
{
  public class ZombieTypeController : Controller
  {
    private readonly IUnitOfWork _unitOfWork;

    public ZombieTypeController(IUnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }
    public IActionResult Index()
    {
      IEnumerable<ZombieType> ZombieTypeList = _unitOfWork.ZombieType.GetAll();

      return View(ZombieTypeList);
    }

    //GET CREATE
    public IActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Create(ZombieType zombieType)
    {
      if (ModelState.IsValid)
      {
        _unitOfWork.ZombieType.Add(zombieType);
      }

      return this.View(zombieType);
    }


  }
}
