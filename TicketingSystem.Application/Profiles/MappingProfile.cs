using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Application.DTOs;
using TicketingSystem.Domain;

namespace TicketingSystem.Application.Profiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Attachment, AttachmentDto>().ReverseMap();
            CreateMap<Company, CompanyDto>().ReverseMap();
            CreateMap<CostCenter, CostCenterDto>().ReverseMap();
            CreateMap<Role, RoleDto>().ReverseMap();
            CreateMap<SystemInfo, SystemInfoDto>().ReverseMap();
            CreateMap<Ticket, TicketDto>().ReverseMap();
        }
        
    }
}
