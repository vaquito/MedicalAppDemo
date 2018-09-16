using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicalDemo.Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedicalDemo.FrontEnd.Controllers
{
    [Produces("application/json")]
    //Nota: se solicito no usar el prefijo "api" en la url
    [Route("v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class AccountsController : Controller
    {

        public Business.IExpedienteMedicoService Repo { get; }

        public AccountsController(Business.IExpedienteMedicoService repo)
        {
            Repo = repo;
        }

        // GET: api/Accounts/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var result = Repo.GetExpedienteByID(id);

            if (result is null)
                return NotFound(Business.PayloadGenerator<object>.GetErrorPayload());

            return Ok(Business.PayloadGenerator<Entities.DataBase.ExpedienteMedico>.GetOkPayload(result));
        }



    }
}