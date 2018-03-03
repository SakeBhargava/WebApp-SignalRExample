using System.Collections.Generic;
using System.Web.Mvc;

namespace WebApp_SignalR.Controllers
{
    public class ToDoListController : Controller
    {
        // GET: ToDoList
        public ActionResult Index()
        {
            var todoItems = new List<string>();
            todoItems.Add("Go through the SignalR tutorial");
            todoItems.Add("Implement SignalR App");
            todoItems.Add("Add apps to GitHub");

            return View(todoItems);
        }
    }
}