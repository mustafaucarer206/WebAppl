﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPP.Models.Sınıflar
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }
        public string Kullanci { get; set; }
        public string Sifre { get; set; }

    }
}