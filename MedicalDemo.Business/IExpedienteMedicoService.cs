using MedicalDemo.Business.Interfaces;
using MedicalDemo.Entities.DataBase;

namespace MedicalDemo.Business
{
    public interface IExpedienteMedicoService
    {
        IRepository<ExpedienteMedico> Context { get; }

        ExpedienteMedico GetExpedienteByID(int id);
    }
}