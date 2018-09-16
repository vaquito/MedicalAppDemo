using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalDemo.Entities.Json
{
    /// <summary>
    /// Exdiente la funcionalidad para poder convertir fecha a cualquier formato
    /// </summary>
    public class FormatoFechaCustomConverter : IsoDateTimeConverter
    {
        public FormatoFechaCustomConverter(string format)
        {
            DateTimeFormat = format;
        }
    }
}
