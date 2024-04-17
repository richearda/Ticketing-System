using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Application.Contracts.Persistence;
using TicketingSystem.Application.Features.Companies.Request.Command;

namespace TicketingSystem.Application.Features.Companies.Handler.Command
{
    public class DeleteCompanyCommandHandler : IRequestHandler<DeleteCompanyCommand, Unit>
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;

        public DeleteCompanyCommandHandler(ICompanyRepository companyRepository, IMapper mapper)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteCompanyCommand request, CancellationToken cancellationToken)
        {
            var company = await _companyRepository.Get(request.Id);
            if (company != null)
            {
                await _companyRepository.Delete(company);
            }
            return Unit.Value;
        }
    }
}
