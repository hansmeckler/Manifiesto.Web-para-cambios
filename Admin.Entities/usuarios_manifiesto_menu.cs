//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Admin.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class usuarios_manifiesto_menu
    {
        public int id_menu { get; set; }
        public string opcion { get; set; }
        public string controller { get; set; }
        public string action { get; set; }
        public string area { get; set; }
        public Nullable<bool> estatus { get; set; }
    }
}