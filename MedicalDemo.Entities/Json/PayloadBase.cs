using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalDemo.Entities
{
    /// <summary>
    /// Respuesta base de cualquier JSON de nuestra api
    /// </summary>
    public abstract class PayloadBase
    {
        protected PayloadBase()
        {
        }

        /// <summary>
        /// crea un payload base con un codigo y un mensaje
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="mensaje"></param>
        protected PayloadBase(string codigo, string mensaje)
        {
            Codigo = codigo ?? throw new ArgumentNullException(nameof(codigo));
            Mensaje = mensaje ?? throw new ArgumentNullException(nameof(mensaje));
        }

        /// <summary>
        /// Codigo asignado a la respuesta
        /// </summary>
        [JsonProperty("codigo", Order = 1)]
        public string Codigo { get; set; }

        /// <summary>
        /// Mensaje de Exito o Error
        /// </summary>
        [JsonProperty("mensaje", Order = 2)]
        public string Mensaje { get; set; }




    }
}
