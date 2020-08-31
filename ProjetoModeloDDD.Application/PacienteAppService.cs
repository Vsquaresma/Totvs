

using System.Collections.Generic;
using Totvs.Application.Interface;
using Totvs.Domain.Entities;
using Totvs.Domain.Interfaces.Services;

namespace Totvs.Application
{
    public class PacienteAppService : AppServiceBase<Paciente>, IPacienteAppService
    {
        private readonly IPacienteService _pacienteService;

        public PacienteAppService(IPacienteService pacienteService)
            : base(pacienteService)
        {
            _pacienteService = pacienteService;
        }
    }
}
