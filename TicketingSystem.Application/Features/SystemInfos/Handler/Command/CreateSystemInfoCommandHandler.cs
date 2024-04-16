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
    public class CreateSystemInfoCommandHandler : IRequestHandler<CreateSystemInfoCommand, int>
    {
        private readonly ISystemInfoRepository _systemInfoRepository;
        private readonly IMapper _mapper;

        public CreateSystemInfoCommandHandler(ISystemInfoRepository systemInfoRepository, IMapper mapper)
        {
            _systemInfoRepository = systemInfoRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateSystemInfoCommand request, CancellationToken cancellationToken)
        {
            var systeminfo = _mapper.Map<SystemInfo>(request.SystemInfo);
            await _systemInfoRepository.Add(systeminfo);
            return systeminfo.SystemInfoID;
        }
    }
}
