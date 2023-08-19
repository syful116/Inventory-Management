using AutoMapper;
using InventoryManagement.Model;
using InventoryManagement.Services.Model;

namespace InvManagement.Model.Mapper;

public class CommonMapper : Profile
{
    public CommonMapper()
    {
        CreateMap<VmCustomer, Customer>().ReverseMap();
        CreateMap<VmSells, Sells>().ReverseMap();
    }
}
