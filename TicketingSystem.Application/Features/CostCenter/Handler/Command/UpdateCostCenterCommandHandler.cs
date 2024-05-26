using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Application.Contracts.Persistence;
using TicketingSystem.Application.Features.CostCenter.Request.Command;

namespace TicketingSystem.Application.Features.CostCenter.Handler.Command
{
    public class UpdateCostCenterCommandHandler : IRequestHandler<UpdateCostCenterCommand, Unit>
    {
        private readonly ICostCenterRepository _costCenterRepository;
        private readonly IMapper _mapper;

        public UpdateCostCenterCommandHandler(ICostCenterRepository costCenterRepository, IMapper mapper)
        {
            _costCenterRepository = costCenterRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateCostCenterCommand request, CancellationToken cancellationToken)
        {
            var costCenter = _mapper.Map<TicketingSystem.Domain.CostCenter>(request.CostCenter);
            await _costCenterRepository.Update(costCenter);
            return Unit.Value;
        }
    }
}
