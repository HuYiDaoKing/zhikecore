using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZhiKeCore.Web.Areas.Admins.Helpers
{
    public class DataTableParams
    {
        public DataTableParams(ControllerBase controller)
        {
            Controller = controller;
            DisplayStart = int.Parse(controller.HttpContext.Request.Form["iDisplayStart"]);
            DisplayLength = int.Parse(controller.HttpContext.Request.Form["iDisplayLength"]);
            SearchKey = controller.HttpContext.Request.Form["sSearch"];
            Echo = controller.HttpContext.Request.Form["sEcho"];
        }

        public ControllerBase Controller { get; set; }

        public int DisplayStart { get; set; }

        public int DisplayLength { get; set; }

        public int TotalCount { get; set; }

        public string SearchKey { get; set; }

        public string Echo { get; set; }
    }
}
