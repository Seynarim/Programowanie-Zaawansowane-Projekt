
﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Programowanie_Zaawansowane_Projekt.Models;
using Programowanie_Zaawansowane_Projekt.Repositories;

namespace Programowanie_Zaawansowane_Projekt.Controllers

{
    public class TaskController : Controller
    {

        private readonly ITaskRepository _taskRepository;
        public TaskController(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }
        // GET: Task
        public ActionResult Index()
        {
            return View(_taskRepository.GetAllActive());
        }

        // GET: Task/Details/5
        public ActionResult Details(int id)
        {
            return View(_taskRepository.Get(id));
        }

        // GET: Task/Create
        public ActionResult Create()
        {
            return View(new TaskModel());
        }

        // POST: Task/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TaskModel taskModel)
        {
            _taskRepository.Add(taskModel);


            return RedirectToAction(nameof(Index));
        }

        // GET: Task/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_taskRepository.Get(id));
        }

        // POST: Task/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TaskModel taskModel)
        {
                _taskRepository.Update(id, taskModel);
                return RedirectToAction(nameof(Index));

        }

        // GET: Task/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_taskRepository.Get(id));
        }

        // POST: Task/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, TaskModel taskModel)
        {
            _taskRepository.Delete(id); 



                return RedirectToAction(nameof(Index));
        }

        //GET:Task/IsCompleted
        public ActionResult Done(int id)
        {
            TaskModel task = _taskRepository.Get(id);
            task.IsCompleted = true;
            _taskRepository.Update(id, task);
            return RedirectToAction(nameof(Index));
            
        }

    }
}