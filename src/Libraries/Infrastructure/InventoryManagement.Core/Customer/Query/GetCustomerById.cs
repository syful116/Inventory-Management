using InventoryManagement.Repositories.Interface;
using InventoryManagement.Services.Model;
using MediatR;

namespace InventoryManagement.Core.Customer.Query;
public record GetCustomerById(int id) : IRequest<VmCustomer>;

public class GetCustomerByIdHandler : IRequestHandler<GetCustomerById, VmCustomer>
{


    private readonly ICustomerRepository _customerRepository;
    public GetCustomerByIdHandler(ICustomerRepository customerRepository) => _customerRepository = customerRepository;
    public async Task<VmCustomer> Handle(GetCustomerById request, CancellationToken cancellationToken)
    {
        return await _customerRepository.GetById(request.id);
    }
}
