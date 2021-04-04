using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bike.Models.ViewModel
{
    public class ModelViewModel
    {
        public Model Model { get; set; }

        public List<Make> Makes { get; set; }

        public List<SelectListItem> CSelectListItem(List<Make> Items)
        {
            

            SelectListItem Sli = new SelectListItem
            {
                Text = "--Select--",
                Value = "0"
        };

            List<SelectListItem> MakeList = new List<SelectListItem>();

            MakeList.Add(Sli);

            foreach(Make make in Items)
            {
                Sli = new SelectListItem
                {
                    Text = make.Name,
                    Value = make.Id.ToString()
                };

                MakeList.Add(Sli);
            }

            return MakeList;
        }
    }
}
