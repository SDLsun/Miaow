﻿using System.Web.Mvc;

namespace Miaow.Presentation.Union.Controllers
{
    [HandleError]
    public class HeadVouchDataController :
        Miaow.Infrastructure.Crosscutting.NetFramework.Controllers.MiaowBaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HeadVouchDataController"/> class.
        /// </summary>
        /// <param name="work">The work.</param>
        public HeadVouchDataController(Miaow.Infrastructure.Crosscutting.NetFramework.IWorkContext work)
            : base(work)
        { }

        /// <summary>
        /// Gets the vouch data.
        /// </summary>
        /// <param name="city">The city.</param>
        /// <returns></returns>
        [HttpGet]
        [OutputCache(Duration = 3600)]
        public PartialViewResult GetVouchData(string city)
        {
            ViewBag.city = city;
            return PartialView("HeadVouchDataPartial");
        }
    }
}
