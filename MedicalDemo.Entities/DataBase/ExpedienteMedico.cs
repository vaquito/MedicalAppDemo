using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MedicalDemo.Entities.DataBase
{
    public class ExpedienteMedico : EntidadBase
    {
        public ExpedienteMedico()
        {
        }

        public ExpedienteMedico(int numeroExpediente, string fechaUltimaConsulta, string tipoDeSangre, IEnumerable<Alergia> alergias)
        {
            NumeroExpediente = numeroExpediente;
            FechaUltimaConsulta = fechaUltimaConsulta ?? throw new ArgumentNullException(nameof(fechaUltimaConsulta));
            TipoDeSangre = tipoDeSangre ?? throw new ArgumentNullException(nameof(tipoDeSangre));
            Alergias = alergias ?? throw new ArgumentNullException(nameof(alergias));
        }

        [JsonProperty("no_expediente")]
        public int NumeroExpediente { get; set; }

        [JsonProperty("fecha_ultima_consulta")]
        public string FechaUltimaConsulta { get; set; }

        [JsonProperty("tipo_sangre")]
        public string TipoDeSangre { get; set; }

        [JsonProperty("alergias")]
        public IEnumerable<Alergia> Alergias { get; set; }

    }
}
