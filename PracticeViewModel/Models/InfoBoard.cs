using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeViewModel.Models
{
    public class InfoBoard
    {
        public List<Pizza> Pizzas { get; set; }
        public List<Customer> customers { get; set; }
    }
}