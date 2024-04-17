using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Domain;
using TicketingSystem.Application.Contracts.Persistence;
using TicketingSystem.Application.DTOs;
using TicketingSystem.Application.Features.CostCenter.Request.Command;

namespace TicketingSystem.Application.Features.CostCenter.Handler.Command
{
    public class CreateCostCenterCommandHandler : IRequestHandler<CreateCostCenterCommand, CostCenterDto>
    {
        private readonly ICostCenterRepository _costCenterRepository;
        private readonly IMapper _mapper;

        public CreateCostCenterCommandHandler(ICostCenterRepository costCenterRepository, IMapper mapper)
        {
            _costCenterRepository = costCenterRepository;
            _mapper = mapper;
        }
        public async Task<CostCenterDto> Handle(CreateCostCenterCommand request, CancellationToken cancellationToken)
        {
            var costCenter = _mapper.Map<CostCenter>(request.CostCenter);
            await _costCenterRepository.Add(costCenter);
            return costCenter;
        }
    }
}
