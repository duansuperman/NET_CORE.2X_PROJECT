﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponentSample.Models;

namespace ViewComponentSample.ViewComponents
{
    public class PriorityListViewComponent:ViewComponent
    {
        private readonly ToDoContext db;
        public PriorityListViewComponent(ToDoContext context)
        {
            db = context;
        }
        //This is method be referenced from other view() 
        public async Task<IViewComponentResult> InvokeAsync(
        int maxPriority, bool isDone)
        {
            string MyView = "Default";
            // If asking for all completed tasks, render with the "PVC" view.
            if (maxPriority > 3 && isDone == true)
            {
                MyView = "PVC";
            }
     
            //As GetItemAsnyc function return to Async, so there is returned with async attribute
            var items = await GetItemsAsync(maxPriority, isDone);

            return View(MyView, items);
        }
        private Task<List<TodoItem>> GetItemsAsync(int maxPriority, bool isDone)
        {
            return db.ToDo.Where(x => x.IsDone == isDone &&
                                 x.Priority <= maxPriority).ToListAsync();
        }

    }
}
