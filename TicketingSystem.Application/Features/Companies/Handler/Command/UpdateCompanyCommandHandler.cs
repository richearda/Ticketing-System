using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Application.Contracts.Persistence;
using TicketingSystem.Application.Features.Companies.Request.Command;
using TicketingSystem.Domain;

namespace TicketingSystem.Application.Features.Companies.Handler.Command
{
    public class UpdateCompanyCommandHandler : IRequestHandler<UpdateCompanyCommand, Unit>
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;

        public UpdateCompanyCommandHandler(ICompanyRepository companyRepository, IMapper mapper)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateCompanyCommand request, CancellationToken cancellationToken)
        {
            var company = _mapper.Map<Company>(request.Company);
            await _companyRepository.Update(company);
            return Unit.Value;
        }
    }
}
