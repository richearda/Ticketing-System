using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Application.Contracts.Persistence;
using TicketingSystem.Application.DTOs;
using TicketingSystem.Application.Features.CostCenter.Request.Queries;

namespace TicketingSystem.Application.Features.CostCenter.Handler.Queries
{
    public class GetCostCenterSystemInfosRequestHandler : IRequestHandler<GetCostCenterSystemInfosRequest, List<CostCenterDto>>
    {
        private readonly ICostCenterRepository _costCenterRepository;
        private readonly IMapper _mapper;

        public GetCostCenterSystemInfosRequestHandler(ICostCenterRepository costCenterRepository, IMapper mapper)
        {
            _costCenterRepository = costCenterRepository;
            _mapper = mapper;
        }
        public async Task<List<CostCenterDto>> Handle(GetCostCenterSystemInfosRequest request, CancellationToken cancellationToken)
        {
            var systemInfos = await _costCenterRepository.GetCostCenterSystemInfos(request.Id);
            return _mapper.Map<List<CostCenterDto>>(systemInfos);
        }
    }
}
