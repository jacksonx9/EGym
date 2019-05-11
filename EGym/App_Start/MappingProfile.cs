using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using EGym.Dtos;
using EGym.Models;

namespace EGym.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Dto
            Mapper.CreateMap<Equipment, EquipmentDto>(); 
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<RentalType, RentalTypeDto>();

            // Dto to Domain
            Mapper.CreateMap<EquipmentDto, Equipment>().ForMember(m => m.Id, opt => opt.Ignore());
            Mapper.CreateMap<CustomerDto, Customer>().ForMember(m => m.Id, opt => opt.Ignore());
            Mapper.CreateMap<RentalTypeDto, RentalType>();

            // Within Domain
            Mapper.CreateMap<Equipment, Equipment>();
            Mapper.CreateMap<Customer, Customer>();
        }
    }
}