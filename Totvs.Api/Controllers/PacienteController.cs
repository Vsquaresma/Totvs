using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Totvs.Api.ViewModels;
using Totvs.Application.Interface;
using Totvs.Domain.Entities;

namespace Totvs.Api.Controllers
{
    public class PacienteController : ApiController
    {
        private readonly IPacienteAppService _pacienteApp;

        public PacienteController(IPacienteAppService pacienteApp)
        {
            _pacienteApp = pacienteApp;
        }

        // GET: api/Paciente
        public IEnumerable<PacienteViewModel> Get()
        {
            return PacienteViewModel.Map(_pacienteApp.GetAll());
        }

        // GET: api/Paciente/5
        public PacienteViewModel Get(int id)
        {
            var paciente = _pacienteApp.GetById(id);
            var pacienteViewModel = PacienteViewModel.Map(paciente);
            return pacienteViewModel;
        }

        // POST: api/Paciente
        public void Post([FromBody] PacienteViewModel paciente)
        {
            if (ModelState.IsValid)
            {
                Paciente pacienteDomain = PacienteViewModel.Map(paciente);
                _pacienteApp.Add(pacienteDomain);
            }
        }

        // PUT: api/Paciente/5
        public void Put(PacienteViewModel paciente)
        {
            if (ModelState.IsValid)
            {
                var pacienteDomain = PacienteViewModel.Map(paciente);
                _pacienteApp.Update(pacienteDomain);
            }
        }

        // DELETE: api/Paciente/5
        public void Delete(int id)
        {
            var paciente = _pacienteApp.GetById(id);
            _pacienteApp.Remove(paciente);
        }
    }
}
