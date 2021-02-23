using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using RoundTheCode.Di.Models;
using RoundTheCode.Di.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoundTheCode.Di.Controllers
{
    [Route("di")]
    public class DIController : Controller
    {
        protected readonly ISingletonService _singletonService;
        protected readonly IScopedService _scopedService;
        protected readonly ITransientService _transientService;

        public DIController(ISingletonService singletonService, IScopedService scopedService, ITransientService transientService)
        {
            _singletonService = singletonService;
            _scopedService = scopedService;
            _transientService = transientService;
        }

        public IActionResult Index()
        {
            var model = new DIModel();
            model.SingletonTime = _singletonService.Time;
            model.ScopedTime = _scopedService.Time;
            model.TransientTime = _transientService.Time;

            return View(model);
        }
    }
}
