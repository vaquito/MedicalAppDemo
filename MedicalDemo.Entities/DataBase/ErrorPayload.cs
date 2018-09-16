using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalDemo.Entities.DataBase
{
    public class ErrorPayload : PayloadBase
    {
        public ErrorPayload(string codigo, string mensaje) : base(codigo, mensaje)
        {
        }
    }
}
