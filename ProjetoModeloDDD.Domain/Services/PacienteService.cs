
using Totvs.Domain.Entities;
using Totvs.Domain.Interfaces.Repositories;
using Totvs.Domain.Interfaces.Services;
using Validacao;

namespace Totvs.Domain.Services
{
    public class PacienteService : ServiceBase<Paciente>, IPacienteService
    {
        private readonly IPacienteRepository _pacienteRepository;

        public PacienteService(IPacienteRepository pacienteRepository)
            : base(pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }

        public override void Add(Paciente obj)
        {
            if (ValidarCpf.IsCpf(obj.CPF))
                base.Add(obj);
            else throw new System.Exception("CPF Inválido");
        }

        public override void Update(Paciente obj)
        {
            if (ValidarCpf.IsCpf(obj.CPF))
                base.Update(obj);
            else throw new System.Exception("CPF Inválido");
        }
    }
}
