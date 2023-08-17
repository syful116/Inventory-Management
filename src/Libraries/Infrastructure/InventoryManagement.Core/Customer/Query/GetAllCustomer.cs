using AutoMapper;
using InventoryManagement.Repositories.Interface;
using InventoryManagement.Services.Model;
using MediatR;

namespace InventoryManagement.Core.Customer.Query;

public record GetAllCustomer : IRequest<IEnumerable<VmCustomer>>;
public class GetAllCustomerHandler : IRequestHandler<GetAllCustomer, IEnumerable<VmCustomer>>

{

    private readonly ICustomerRepository _customerRepository;


    public GetAllCustomerHandler(ICustomerRepository customerRepository, IMapper mapper)
    {
        _customerRepository = customerRepository;
    }
    public async Task<IEnumerable<VmCustomer>> Handle(GetAllCustomer request, CancellationToken cancellationToken)
    {
        var result = await _customerRepository.GetAll();
        return result;
    }

}