using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Application.Contracts.Persistence;
using TicketingSystem.Application.Features.SystemInfos.Request.Command;

namespace TicketingSystem.Application.Features.SystemInfos.Handler.Command
{
    public class DeleteSystemInfoCommandHandler : IRequestHandler<DeleteSystemInfoCommand, int>
    {
        private readonly ISystemInfoRepository _systemInfoRepository;
        private readonly IMapper _mapper;

        public DeleteSystemInfoCommandHandler(ISystemInfoRepository systemInfoRepository, IMapper mapper)
        {
            _systemInfoRepository = systemInfoRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(DeleteSystemInfoCommand request, CancellationToken cancellationToken)
        {
           var systeminfo = await _systemInfoRepository.Get(request.Id);
            if (systeminfo != null)
            {
                await _systemInfoRepository.Delete(systeminfo);
            }
            return systeminfo.SystemInfoID;
        }
    }
}
