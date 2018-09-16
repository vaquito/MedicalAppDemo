using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalDemo.Entities.DataBase
{
    public class Alergia : EntidadBase
    {

        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        [JsonProperty("fecha_alta")]
        public DateTime FechaDeAlta { get; set; }

        [JsonProperty("medicamento")]
        public string Medicamento { get; set; }

    }
}
