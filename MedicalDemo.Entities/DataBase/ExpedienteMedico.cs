using MedicalDemo.Entities.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MedicalDemo.Entities.DataBase
{
    /// <summary>
    /// Expediente medico de un paciente
    /// </summary>
    public class ExpedienteMedico : EntidadBase
    {
        public ExpedienteMedico()
        {
            Alergias = new List<Alergia>();

        }

        /// <summary>
        /// Crea un expediente medico
        /// </summary>
        /// <param name="numeroExpediente">Numero de expediente interno</param>
        /// <param name="fechaUltimaConsulta">Utima consuta medica</param>
        /// <param name="tipoDeSangre">tipo de sangre de paciente</param>
        /// <param name="alergias">Listado de alergias diagnosticadas </param>
        public ExpedienteMedico(string numeroExpediente, DateTime? fechaUltimaConsulta, string tipoDeSangre, IEnumerable<Alergia> alergias)
        {
            NumeroExpediente = numeroExpediente;
            FechaUltimaConsulta = fechaUltimaConsulta ?? throw new ArgumentNullException(nameof(fechaUltimaConsulta));
            TipoDeSangre = tipoDeSangre ?? throw new ArgumentNullException(nameof(tipoDeSangre));
            Alergias = alergias ?? throw new ArgumentNullException(nameof(alergias));
        }


        /// <summary>
        /// Crea un expediente medico
        /// </summary>
        /// <param name="numeroExpediente">Numero de expediente interno</param>
        /// <param name="fechaUltimaConsulta">Utima consuta medica</param>
        /// <param name="tipoDeSangre">tipo de sangre de paciente</param>
        public ExpedienteMedico(string numeroExpediente, DateTime? fechaUltimaConsulta, string tipoDeSangre)
        {
            NumeroExpediente = numeroExpediente;
            FechaUltimaConsulta = fechaUltimaConsulta ?? throw new ArgumentNullException(nameof(fechaUltimaConsulta));
            TipoDeSangre = tipoDeSangre ?? throw new ArgumentNullException(nameof(tipoDeSangre));
            Alergias = new List<Alergia>();
        }

        /// <summary>
        /// Numero o nombre del expediente, para uso del personal, no esta ligado con el ID del registro
        /// </summary>
        [JsonProperty("no_expediente",Order = 1)]
        public string NumeroExpediente { get; set; }

        /// <summary>
        /// Fecha de la ultima consulta del paciente. 
        /// </summary>
        [JsonProperty("fecha_ultima_consulta", Order = 2)]
        [JsonConverter(typeof(FormatoFechaCustomConverter), "dd/MM/yy")]
        public DateTime? FechaUltimaConsulta { get; set; }

        /// <summary>
        /// tipo de Sangre del paciente
        /// </summary>
        [JsonProperty("tipo_sangre", Order = 3)]
        public string TipoDeSangre { get; set; }

        /// <summary>
        /// Listado de Alergias diagnosticadas
        /// </summary>
        [JsonProperty("alergias", Order = 4)]
        public IEnumerable<Alergia> Alergias { get; set; }

    }
}
