﻿using Edux.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edux.ViewComponents
{
    public class CalendarComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        public CalendarComponent(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(Models.Component component)
        {
            var viewName = component.View ?? "Default";
            var formId = component.ParameterValues.FirstOrDefault(f => f.Parameter.Name == "Form")?.Value;
            ViewBag.Form = _context.Components.FirstOrDefault(c => c.Id == formId);

            return await Task.FromResult(View(viewName, component));
        }
    }
}
