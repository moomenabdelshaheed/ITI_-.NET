﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormswirhwebapi
{
    internal class Course
    {
        public int id { get; set; }
        
        public string? crs_name { get; set; }
        

        public string? crs_desc { get; set; }

        public int? duration { get; set; }
    }
}
