using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using MedicalDemo.Entities.Json;

namespace MedicalDemo.Entities.DataBase
{
    /// <summary>
    /// Define una Alergia 
    /// </summary>
    public class Alergia : EntidadBase
    {
        public Alergia()
        {
        }


        /// <summary>
        /// Crea una alergia
        /// </summary>
        /// <param name="nombre">Nombre de la alergia</param>
        /// <param name="fechaDeAlta"> Fecha de alta de la alergia</param>
        /// <param name="medicamento">Medicamento recomendado para la alergia</param>
        public Alergia(string nombre, DateTime fechaDeAlta, string medicamento)
        {
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            FechaDeAlta = fechaDeAlta;
            Medicamento = medicamento ?? throw new ArgumentNullException(nameof(medicamento));
        }

        /// <summary>
        /// Nombre de la alergia
        /// </summary>
        [JsonProperty("nombre", Order = 1)]
        public string Nombre { get; set; }

        /// <summary>
        /// Fecha de alta de la alergia
        /// </summary>
        [JsonProperty("fecha_alta", Order = 2)]
        [JsonConverter(typeof(FormatoFechaCustomConverter), "dd/MM/yy")]
        public DateTime FechaDeAlta { get; set; }

        /// <summary>
        /// Medicamento recomendado para la alergia
        /// </summary>
        [JsonProperty("medicamento", Order = 3)]
        public string Medicamento { get; set; }

    }
}
