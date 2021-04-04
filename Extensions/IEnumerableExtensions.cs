using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bike.Extensions
{
    public static class IEnumerableExtensions
    {
        public static List<SelectListItem> ToSelectListItem<T>(this List<T> Items)
        {


            SelectListItem Sli = new SelectListItem
            {
                Text = "--Select--",
                Value = "0"
            };

            List<SelectListItem> List = new List<SelectListItem>();

            List.Add(Sli);

            foreach (var item in Items)
            {
                Sli = new SelectListItem
                {
                    Text = item.GetPropertyValue("Name"),
                    //Text = item.GetType().GetProperty("Name").GetValue(item,null).ToString(),
                    //Value = item.GetType().GetProperty("Id").GetValue(item, null).ToString()
                    Value= item.GetPropertyValue("Id")
                };

                List.Add(Sli);
            }

            return List;
        }
    }
}
