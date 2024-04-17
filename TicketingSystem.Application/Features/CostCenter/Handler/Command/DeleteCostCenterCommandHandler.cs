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
    public class DeleteCostCenterCommandHandler : IRequestHandler<DeleteCostCenterCommand, Unit>
    {
        private readonly ICostCenterRepository _costCenterRepository;
        private readonly IMapper _mapper;

        public DeleteCostCenterCommandHandler(ICostCenterRepository costCenterRepository, IMapper mapper)
        {
            _costCenterRepository = costCenterRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteCostCenterCommand request, CancellationToken cancellationToken)
        {
            var costCenter =  await _costCenterRepository.Get(request.Id);
            if (costCenter != null)
            {
                await _costCenterRepository.Delete(costCenter);
            }
            return Unit.Value;
        }
    }
}
