using AutoMapper;
using System.Collections.Generic;
using System.Web.Http;
using Totvs.Api.ViewModels;
using Totvs.Application.Interface;
using Totvs.Domain.Entities;

namespace Totvs.Api.Controllers
{
    public class EnderecoController : ApiController
    {
        // GET: Enderecos
        private readonly IEnderecoAppService _enderecoApp;
        private readonly IPacienteAppService _pacienteApp;

        public EnderecoController(IEnderecoAppService enderecoApp, IPacienteAppService pacienteApp)
        {
            _enderecoApp = enderecoApp;
            _pacienteApp = pacienteApp;
        }

        // GET: api/Endereco
        public IEnumerable<EnderecoViewModel> Get()
        {
            return Mapper.Map<IEnumerable<Endereco>, IEnumerable<EnderecoViewModel>>(_enderecoApp.GetAll());
        }

        // GET: api/Endereco/5
        public EnderecoViewModel Get(int id)
        {
            var endereco = _enderecoApp.GetById(id);
            var enderecoViewModel = Mapper.Map<Endereco, EnderecoViewModel>(endereco);
            return enderecoViewModel;
        }

        // POST: api/Endereco
        public void Post([FromBody] EnderecoViewModel endereco)
        {
            if (ModelState.IsValid)
            {
                var enderecoDomain = Mapper.Map<EnderecoViewModel, Endereco>(endereco);
                _enderecoApp.Add(enderecoDomain);
            }
        }

        // PUT: api/Endereco/5
        public void Put(int id, [FromBody] EnderecoViewModel endereco)
        {
            if (ModelState.IsValid)
            {
                var enderecoDomain = Mapper.Map<EnderecoViewModel, Endereco>(endereco);
                _enderecoApp.Update(enderecoDomain);
            }
        }

        // DELETE: api/Endereco/5
        public void Delete(int id)
        {
            var endereco = _enderecoApp.GetById(id);
            _enderecoApp.Remove(endereco);
        }
    }
}