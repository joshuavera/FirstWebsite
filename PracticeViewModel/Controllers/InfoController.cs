using PracticeViewModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticeViewModel.Controllers
{
    public class InfoController : Controller
    {
        // GET: Info
        public ActionResult Index()
        {
            List<Pizza> pizzas = new List<Pizza>
            {
                new Pizza {type = "hawaiian", slices = 5, cost = 12.99 },
                new Pizza {type = "pepperoni", slices = 2, cost = 5.99 },
                new Pizza {type = "cheese", slices = 4, cost = 10.99 },
                new Pizza {type = "bacon", slices = 8, cost = 19.99 },

            };
            List<Customer> customers = new List<Customer>
            {
                new Customer {ID = 101, name = "joshua", request = 9},
                new Customer {ID = 102, name = "dave", request = 7},
                new Customer {ID = 103, name = "ikeem", request = 5},
                new Customer {ID = 104, name = "makenzy", request = 3},

            };
            var Infoboard = new InfoBoard
            {
                Pizzas = pizzas,
                customers = customers

            };


            return View(Infoboard);
        }
    }
}