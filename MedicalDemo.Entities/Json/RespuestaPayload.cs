using Newtonsoft.Json;
using System;

namespace MedicalDemo.Entities
{
    /// <summary>
    /// Respuesta generica para peticiones al API
    /// T debe ser un tipo serializable
    /// </summary>
    /// <typeparam name="T">Tipo serializable de cualquier respuesta posible del app</typeparam>
    public class RespuestaPayload<T> : PayloadBase
    {

        
        /// <summary>
        /// Crea un Payload con información T para el cliente
        /// </summary>
        /// <param name="codigo">Codigo de Error</param>
        /// <param name="mensaje">Mensaje de Exito o Error</param>
        /// <param name="payload">Objeto de Informacion seriaizable</param>
        public RespuestaPayload(string codigo, string mensaje, T payload):base(codigo, mensaje)
        {
            Payload = payload;
        }

        /// <summary>
        /// Requerido para ser seralizado
        /// </summary>
        public RespuestaPayload():base()
        {

        }


     

        /// <summary>
        /// Objeto que contiene la información solicitada
        /// </summary>
        [JsonProperty("payload")]
        public T Payload { get;  set; }

    }
}
