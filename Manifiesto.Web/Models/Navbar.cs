﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Manifiesto.Web.Models
{
    public class Navbar
    {
        public int Id { get; set; }
        public string nameOption { get; set; }
        public string controller { get; set; }
        public string action { get; set; }
        public string area { get; set; }
        public string imageClass { get; set; }
        public string activeli { get; set; }
        public bool estatus { get; set; }
        public int parentId { get; set; }
        public bool isParent { get; set; }
        public bool hasChild { get; set; }
        public int tipo_opcion { get; set; }
    }
}