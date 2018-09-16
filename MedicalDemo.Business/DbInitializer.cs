using MedicalDemo.Entities.DataBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalDemo.Business
{
    public class DbInitializer
    {
        public static void init(string conexionString)
        {

            using (var context = new MedicalDemo.DataAccess.ApplicationDbContext(conexionString))
            {

                // // Crea la base si no existe la crea y regresa "True"
                if (context.Database.EnsureCreated())
                {


                    var exp1Alergias = new List<Alergia>();
                    exp1Alergias.Add(new Alergia("Polen",DateTime.Now,"Poletidina"));
                    exp1Alergias.Add(new Alergia("Fresas", DateTime.Now, "Fresidina"));
                    exp1Alergias.Add(new Alergia("Nueces", DateTime.Now, "Nuezeidina"));
                    var exp1 = new ExpedienteMedico("1", DateTime.Now, "O+");
                    exp1.Alergias = exp1Alergias;

                    var exp2Alergias = new List<Alergia>();
                    exp2Alergias.Add(new Alergia("Nueces", DateTime.Now, "Nuezeidina"));
                    var exp2 = new ExpedienteMedico("2", DateTime.Now, "AB+");
                    exp2.Alergias = exp2Alergias;

                    var exp3Alergias = new List<Alergia>();
                    exp3Alergias.Add(new Alergia("Polen", DateTime.Now, "Poletidina"));
                    var exp3 = new ExpedienteMedico("3", DateTime.Now, "A+");
                    exp3.Alergias = exp3Alergias;


                    context.ExpedientesMedicos.Add(exp1);
                    context.ExpedientesMedicos.Add(exp2);
                    context.ExpedientesMedicos.Add(exp3);




                    //     //Agregar catalogos del APP

                    context.SaveChanges();

                }

            }

        }

    }
}
