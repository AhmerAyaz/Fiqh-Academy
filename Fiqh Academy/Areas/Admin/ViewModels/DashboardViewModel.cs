using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fiqh_Academy.Models;

namespace Fiqh_Academy.Areas.Admin.ViewModels
{
    public class DashboardViewModel
    {
        public int Registration { get; set; }
        public int Update { get; set; }
        public int Bayanaat { get; set; }
        public int Books { get; set; }
    }
}