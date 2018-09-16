using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalDemo.Business
{
    public class PayloadGenerator<T>
    {

        public static Entities.RespuestaPayload<T> GetOkPayload(T Payload) {

            return new Entities.RespuestaPayload<T>("200", "Petición completada", Payload);

        }


        public static Entities.ErrorPayload GetErrorPayload()
        {
            return new Entities.ErrorPayload("400", "No existe");

        }

    }
}
