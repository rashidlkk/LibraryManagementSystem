﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_Management_System_Web.Areas.Admin.Models
{
    public abstract class AdminBaseModel
    {
        public MenuModel MenuModel { get; set; }

        public AdminBaseModel()
        {
            MenuModel = new MenuModel();
        }
    }
}
