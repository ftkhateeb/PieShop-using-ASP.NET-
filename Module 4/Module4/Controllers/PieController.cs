using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Module4.Models;
using Module4.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Module4.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;//readonly = assignment to the field is only through constructor of the class or through field declaration
        private readonly ICategoryRepository _categoryRepository;

        public PieController (IPieRepository pieRepository, ICategoryRepository categoryRepository)// these are going to be injected in here because we previously registered them in the start up
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

      /*  public ViewResult List()//Viewresult is built in , we call it list cus it's gonna show a list of all types
        {
            return View(_pieRepository.AllPies); // view is a built in method from ASP.NET core
        } //this is the method that handles the incoming requests
        //action methods are public */

        public ViewResult List()
        {
            //ViewBag.CurrentCategory = "Cheese cakes";

            //return View(_pieRepository.AllPies);
            PiesListViewModel piesListViewModel = new PiesListViewModel();
            piesListViewModel.Pies = _pieRepository.AllPies;

            piesListViewModel.CurrentCategory = "Cheese cakes";
            return View(piesListViewModel);
        }

        public  IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);

            if (pie== null)
            {
                return NotFound();
             
            }

            return View(pie);
        }

    }
}
