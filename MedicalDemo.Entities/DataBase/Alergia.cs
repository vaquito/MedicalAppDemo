using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalDemo.Entities.DataBase
{
    /// <summary>
    /// Define una Alergia 
    /// </summary>
    public class Alergia : EntidadBase
    {
        /// <summary>
        /// Nombre de la alergia
        /// </summary>
        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        /// <summary>
        /// Fecha de alta de la alergia
        /// </summary>
        [JsonProperty("fecha_alta")]
        public DateTime FechaDeAlta { get; set; }

        /// <summary>
        /// Medicamento recomendado para la alergia
        /// </summary>
        [JsonProperty("medicamento")]
        public string Medicamento { get; set; }

    }
}
