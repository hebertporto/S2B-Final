using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using S2B.Models;

namespace S2B.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index(string id)
        {
            //fazer uma condição que verifica se o usuario já esta logado
            //assim faz o redirecionamento para a pagina principal
            ViewBag.mensagen = id;
            return View();
        }
        // POST: Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(string Login_User, string Login_Senha)
        {
            if (ModelState.IsValid)
            {
                if (Fucionario.Verificar(Login_User, Login_Senha))
                {
                    //Depois de implementado olha aqui
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.mensagen = "Login ou senha Invalidos";
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        //get: Recuperação de dados
        public ActionResult RecuperacaoDeDados()
        {
            return View();
        }

        ////registra usuario
        //public ActionResult Registrar()
        //{
        //    return View();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Registrar(Fucionario user)
        //{
        //    //essa parte aqui 
        //    return View();
        //}
    }
}