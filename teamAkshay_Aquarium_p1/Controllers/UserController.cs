using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using data.repo;
using data.entities;
using teamAkshay_Aquarium_p1.Models;

namespace teamAkshay_Aquarium_p1.Controllers
{
    public class UserController : Controller
    {
        UserRepo repo;
        public UserController()
        {
            repo = new UserRepo(new User_Model());
        }

        // GET: User_
        public ActionResult Index()
        {
            var user = repo.GetUser();
            var data = new List<teamAkshay_Aquarium_p1.Models.User>();
            foreach (var c in user)
            {
                data.Add(Mapper.Map(c));
            }
            return View(data);

        }

        public ActionResult GetCatById(int id)
        {
            var user = repo.GetUserById(id);
            return View(Mapper.Map(user));
        }
    }
}