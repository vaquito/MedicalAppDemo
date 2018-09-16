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
        }

        /// <summary>
        /// Crea un expediente medico
        /// </summary>
        /// <param name="numeroExpediente">Numero de expediente interno</param>
        /// <param name="fechaUltimaConsulta">Utima consuta medica</param>
        /// <param name="tipoDeSangre">tipo de sangre de paciente</param>
        /// <param name="alergias">Listado de alergias diagnosticadas <code>null</code> cuando no tiene alergias </param>
        public ExpedienteMedico(string numeroExpediente, string fechaUltimaConsulta, string tipoDeSangre, IEnumerable<Alergia> alergias)
        {
            NumeroExpediente = numeroExpediente;
            FechaUltimaConsulta = fechaUltimaConsulta ?? throw new ArgumentNullException(nameof(fechaUltimaConsulta));
            TipoDeSangre = tipoDeSangre ?? throw new ArgumentNullException(nameof(tipoDeSangre));
            Alergias = alergias ?? throw new ArgumentNullException(nameof(alergias));
        }
        /// <summary>
        /// Numero o nombre del expediente, para uso del personal, no esta ligado con el ID del registro
        /// </summary>
        [JsonProperty("no_expediente")]
        public string NumeroExpediente { get; set; }

        /// <summary>
        /// Fecha de la ultima consulta del paciente. 
        /// </summary>
        [JsonProperty("fecha_ultima_consulta")]
        public string FechaUltimaConsulta { get; set; }

        /// <summary>
        /// tipo de Sangre del paciente
        /// </summary>
        [JsonProperty("tipo_sangre")]
        public string TipoDeSangre { get; set; }

        /// <summary>
        /// Listado de Alergias diagnosticadas
        /// </summary>
        [JsonProperty("alergias")]
        public IEnumerable<Alergia> Alergias { get; set; }

    }
}
