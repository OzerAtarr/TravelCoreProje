﻿using Microsoft.AspNetCore.Mvc;

namespace TravelCoreProje.ViewComponents.Default
{
    public class _SliderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
