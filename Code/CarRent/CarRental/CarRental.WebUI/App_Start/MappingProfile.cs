using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using CarRental.Core.Dtos;
using CarRental.Core.Models;

namespace CarRental.WebUI.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();

        }
    }
}