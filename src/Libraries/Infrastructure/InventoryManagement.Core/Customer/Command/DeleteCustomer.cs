using InventoryManagement.Repositories.Interface;
using InventoryManagement.Services.Model;
using MediatR;

namespace InventoryManagement.Core.Customer.Command;


public record DeleteCustomer(int Id) : IRequest<VmCustomer>;

public class DeleteCustomerHandler : IRequestHandler<DeleteCustomer, VmCustomer>
{
    private readonly ICustomerRepository _customerRepository;

    public DeleteCustomerHandler(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }


    public async Task<VmCustomer> Handle(DeleteCustomer request, CancellationToken cancellationToken)
    {
        return await _customerRepository.Delete(request.Id);
    }
}