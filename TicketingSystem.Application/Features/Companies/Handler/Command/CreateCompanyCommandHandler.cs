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
    public class CreateCompanyCommandHandler : IRequestHandler<CreateCompanyCommand, Company>
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;

        public CreateCompanyCommandHandler(ICompanyRepository companyRepository, IMapper mapper)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
        }
        public async Task<Company> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
        {
            var company = _mapper.Map<Company>(request.Company);
            await _companyRepository.Add(company);
            return company;
        }
    }
}
