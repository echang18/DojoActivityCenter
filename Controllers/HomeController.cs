using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoActivityCenter.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace DojoActivityCenter.Controllers
{
    public class HomeController : Controller
    {
        private MyContext context;
        private PasswordHasher<User> RegisterHasher = new PasswordHasher<User>();
        private PasswordHasher<LoginUser> LoginHasher = new PasswordHasher<LoginUser>();

        public HomeController(MyContext db)
        {
            context = db;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            if(context.Users.Any(u => u.Email == user.Email))
            {
                ModelState.AddModelError("Email", "Email already in use");
            }
            if(ModelState.IsValid)
            {
                var hasher = new PasswordHasher<User>();
                user.Password = hasher.HashPassword(user, user.Password);
                context.Users.Add(user);
                context.SaveChanges();
                HttpContext.Session.SetInt32("UserId", user.UserId);
                return Redirect("/home");
            }
            return View("Index");
        }

        [HttpPost("login")]
        public IActionResult Login(LoginUser userData)
        {
            User userInDb = context.Users.FirstOrDefault(u => u.Email == userData.LoginEmail);
            if(userInDb == null)
            {
                ModelState.AddModelError("LoginEmail", "Email not found");
            } 
            else
            {
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(userData, userInDb.Password, userData.LoginPassword);
                if(result == 0)
                {
                    ModelState.AddModelError("LoginPassword", "Incorrect Password");
                }
            }
            if(!ModelState.IsValid)
            {
                return View("Index");
            }
            HttpContext.Session.SetInt32("UserId", userInDb.UserId);
            return Redirect("/home");
        }


        [HttpGet("home")]
        public IActionResult Home()
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if(UserId == null)
            {
                return Redirect("/");
        }
            List<Plan> Plans = context.Plans
            .Include(p => p.Planner)
            .Include(p => p.Attendees)
            .OrderBy(p => p.PlanStart).ToList();
            for(int i = 0; i < Plans.Count; i++)
            {
                if(Plans[i].PlanStart < DateTime.Now)
                {
                    Plans.Remove(Plans[i]);
                }
            }
            ViewBag.Plans = Plans;
            ViewBag.UserId = UserId;
            return View("Home");            
        }

        [HttpGet("plan/new")]
        public IActionResult NewPlan()
        {
            return View("NewPlan");
        }

        [HttpPost("plan")]
        public IActionResult CreatePlan(Plan p)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if(UserId == null)
            {
                return Redirect("/");
            }
            if(ModelState.IsValid)
            {
                p.PlannerId = (int) UserId;
                    context.Plans.Add(p);
                    context.SaveChanges(); 
                    return Redirect("/home");
                }
                else{
                    return View("NewPlan", p);
            }
        }

        [HttpGet("view/{PlanId}")]
        public IActionResult ShowPlan(int PlanId)
        {
            Plan p = context.Plans
                .Include(po => po.Planner)
                .Include(po => po.Attendees)
                .ThenInclude(po => po.Joiner)
                .FirstOrDefault(po => po.PlanId == PlanId);
            ViewBag.Joins = p.Attendees;
            return View(p);
        }

        [HttpGet("delete/{PlanId}")]
        public IActionResult Delete(int PlanId)
        {
            Plan p = context.Plans.FirstOrDefault(po => po.PlanId == PlanId);
            context.Plans.Remove(p);
            context.SaveChanges();
            return Redirect("/home");
        }

        [HttpGet("join/{PlanId}")]
        public IActionResult Join(int PlanId)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if (UserId == null)
            {
                return Redirect("/");
            }
            Join j = new Join()
            {
                UserId = (int)UserId,
                PlanId = PlanId
            };
            context.Joins.Add(j);
            context.SaveChanges();
            return Redirect("/home");
        }

        [HttpGet("leave/{PlanId}")]
        public IActionResult Leave(int PlanId)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if (UserId == null)
            {
                return Redirect("/");
            }
            Join join =context.Joins
                .Where(j => j.PlanId == PlanId)
                .FirstOrDefault(j => j.UserId == (int) UserId);
            context.Joins.Remove(join);
            context.SaveChanges();
            return Redirect("/home");
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("UserId");
            return Redirect("/");
        }
    }
}