using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Application.Contracts.Persistence;
using TicketingSystem.Application.Features.Companies.Request.Request;
using TicketingSystem.Domain;

namespace TicketingSystem.Application.Features.Companies.Handler.Request
{
    public class GetCompanyWithCostCenterRequestHandler : IRequestHandler<GetCompanyWithCostCenterRequest, List<Company>>
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;

        public GetCompanyWithCostCenterRequestHandler(ICompanyRepository companyRepository, IMapper mapper)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
        }
        public async Task<List<Company>> Handle(GetCompanyWithCostCenterRequest request, CancellationToken cancellationToken)
        {
            var companies = await _companyRepository.GetCompanyWithCostCenters(request.Id);
            return companies;
        }
    }
}
