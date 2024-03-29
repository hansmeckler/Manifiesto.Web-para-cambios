﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Manifiesto.Web.Areas.Maritimo.Models
{
    public class cuscar_container_infoVM
    {
        public long cuscar_container_id { get; set; }

        public long cuscar_viaje_id { get; set; }

        public string no_contenedor { get; set; }

        public string mbl { get; set; }

        public string seal { get; set; }

        public Nullable<int> id_container_type { get; set; }

        public Nullable<int> no_piezas { get; set; }

        public Nullable<int> id_tipo_paquete { get; set; }

        public string tipo_paquete { get; set; }

        public string volumen { get; set; }

        public Nullable<int> comodity_id { get; set; }

        public Nullable<bool> warehouse { get; set; }

        public string comodity { get; set; }

        public Nullable<int> no_bls { get; set; }

        public Nullable<int> bl_id { get; set; }

        public Nullable<int> contenedor_id { get; set; }

        public Nullable<int> viaje_id { get; set; }

        public string container_type { get; set; }

        public string cuscar { get; set; }

        public string cuscardt { get; set; }

        public string manifest { get; set; }

        public string original { get; set; }

        public Nullable<int> mtype { get; set; }

        public Nullable<int> mfunction { get; set; }

        public string operation { get; set; }

        public string funcsend { get; set; }

        public Nullable<int> test { get; set; }

        public string peso { get; set; }

        public Nullable<int> id_status { get; set; }

        public Nullable<int> bl_id_ref { get; set; }

        public string respuesta_sat { get; set; }

        public string mt { get; set; }

        public string total_bls { get; set; }

        public string total_peso { get; set; }

        public string total_volumen { get; set; }

        public string total_piezas { get; set; }

        public string no_contenedores { get; set; }

        public string flete { get; set; }

        public string no_bl { get; set; }
    }
}