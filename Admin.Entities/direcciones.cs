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
    
    public partial class direcciones
    {
        public long id_direccion { get; set; }
        public Nullable<long> id_nivel_geografico { get; set; }
        public string direccion_completa { get; set; }
        public Nullable<long> id_cliente { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipcode { get; set; }
        public string name { get; set; }
        public string phone_number { get; set; }
        public string group { get; set; }
        public string url { get; set; }
        public string image { get; set; }
        public Nullable<float> lat { get; set; }
        public Nullable<float> lng { get; set; }
        public string email { get; set; }
        public int id_tipo_direccion { get; set; }
        public Nullable<bool> boletines { get; set; }
        public Nullable<bool> activo { get; set; }
    
        public virtual clientes clientes { get; set; }
    }
}
