using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Application.Contracts.Persistence;
using TicketingSystem.Application.Features.SystemInfos.Request.Command;
using TicketingSystem.Domain;

namespace TicketingSystem.Application.Features.SystemInfos.Handler.Command
{
    public class UpdateSystemInfoCommandHandler : IRequestHandler<UpdateSystemInfoCommand, int>
    {
        private readonly ISystemInfoRepository _systemInfoRepository;
        private readonly IMapper _mapper;

        public UpdateSystemInfoCommandHandler(ISystemInfoRepository systemInfoRepository, IMapper mapper)
        {
            _systemInfoRepository = systemInfoRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(UpdateSystemInfoCommand request, CancellationToken cancellationToken)
        {
            var systeminfo = await _systemInfoRepository.Exists(request.SystemInfo.SystemInfoID);
            if(systeminfo)
            {
                var sysinfo = _mapper.Map<SystemInfo>(request.SystemInfo);
                await _systemInfoRepository.Update(sysinfo);
            }
            return request.SystemInfo.SystemInfoID;
        }
    }
}
