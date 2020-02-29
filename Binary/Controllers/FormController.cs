using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Binary.Helper;
using Binary.Models;
using Microsoft.AspNetCore.Mvc;

namespace Binary.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Resultado(Nums model)
        {
            BinaryHelper bh = new BinaryHelper();
            foreach(int n in model.Numeros)
            {
                model.Binarios.Add(bh.NumaBinario(n));
            }
            return View(model);
        }


    }
}