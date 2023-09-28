using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FProjectCampingBackend.Models.Services
{
    public class DropdownListService
    {
        public SelectList GetRoomNameDropdownList()
        {
			var items = new List<SelectListItem>
            {
			new SelectListItem { Value = "", Text = "請選擇" },
			new SelectListItem { Value = "1", Text = "豪華雙人房" },
			new SelectListItem { Value = "2", Text = "豪華家庭房" },
			new SelectListItem { Value = "3", Text = "南風苑" },
		};
			return new SelectList(items, "Value", "Text");
		}   


    }
}