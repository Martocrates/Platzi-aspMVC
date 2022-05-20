using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core_MVC.Models;

namespace platzi_asp_net_core_MVC.Controllers
{
    public class EscuelaController : Controller
    {

        #region Variables
        private EscuelaContext mescContexto;

        #endregion

        #region Constructores
        public EscuelaController(EscuelaContext pContext)
        {
            this.mescContexto = pContext;
        }

        #endregion

        #region Métodos públicos
        public IActionResult Index()
        {
            var escuela = mescContexto.Escuelas.FirstOrDefault();
            return View(escuela);

           
        }

        #endregion

    }
}
