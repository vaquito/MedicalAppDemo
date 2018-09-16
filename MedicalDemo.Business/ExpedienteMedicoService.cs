using MedicalDemo.Business.Interfaces;
using MedicalDemo.Entities;
using MedicalDemo.Entities.DataBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalDemo.Business
{
    public class ExpedienteMedicoService : IExpedienteMedicoService
    {
        public ExpedienteMedicoService(IRepository<ExpedienteMedico> context)
        {
            Context = context;
        }


        public ExpedienteMedico GetExpedienteByID(int id)
        {
            return Context.GetById(id, "Alergias");
        }

        public IRepository<ExpedienteMedico> Context { get; }
    }
}
