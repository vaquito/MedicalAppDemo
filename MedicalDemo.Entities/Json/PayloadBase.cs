using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalDemo.Entities
{
    public abstract class PayloadBase
    {
        protected PayloadBase()
        {
        }

        protected PayloadBase(string codigo, string mensaje)
        {
            Codigo = codigo ?? throw new ArgumentNullException(nameof(codigo));
            Mensaje = mensaje ?? throw new ArgumentNullException(nameof(mensaje));
        }

        /// <summary>
        /// Codigo asignado a la respuesta
        /// </summary>
        [JsonProperty("codigo")]
        public string Codigo { get; set; }

        /// <summary>
        /// Mensaje de Exito o Error
        /// </summary>
        [JsonProperty("mensaje")]
        public string Mensaje { get; set; }




    }
}
