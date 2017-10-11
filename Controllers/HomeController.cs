using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

namespace Places.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet("/tasks/new")]
        public ActionResult TaskForm()

        {
            return View();
        }

        [HttpPost("/tasks")]
        public ActionResult AddTask()
        {
            Task newTask = new Task(Request.Form["new-task"]);
            List<Task> allTasks = Task.GetAll();
            return View("Tasks", allTasks);
        }

        [HttpGet("/tasks/{id}")]
        public ActionResult TaskDetail(int id)
        {
            Task task = Task.Find(id);
            return View(task);
        }

        [HttpPost("/task/list/clear")]
         public ActionResult TaskListClear()
         {
             Task.ClearAll();
             return View();
         }

  }
}
