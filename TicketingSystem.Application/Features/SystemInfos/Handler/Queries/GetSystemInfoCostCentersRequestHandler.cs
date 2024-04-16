using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Application.Contracts.Persistence;
using TicketingSystem.Application.DTOs;
using TicketingSystem.Application.Features.SystemInfos.Request.Queries;

namespace TicketingSystem.Application.Features.SystemInfos.Handler.Queries
{
    public class GetSystemInfoCostCentersRequestHandler : IRequestHandler<GetSystemInfoCostCentersRequest, List<SystemInfoDto>>
    {
        private readonly ISystemInfoRepository _systeminfoRepository;
        private readonly IMapper _mapper;

        public GetSystemInfoCostCentersRequestHandler(ISystemInfoRepository systeminfoRepository, IMapper mapper)
        {
            _systeminfoRepository = systeminfoRepository;
            _mapper = mapper;
        }
        public async Task<List<SystemInfoDto>> Handle(GetSystemInfoCostCentersRequest request, CancellationToken cancellationToken)
        {
            var systeminfos = await _systeminfoRepository.GetSystemInfoCostCenters(request.Id);
            return _mapper.Map<List<SystemInfoDto>>(systeminfos);
        }
    }
}
