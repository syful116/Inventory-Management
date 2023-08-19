using InventoryManagement.Repositories.Interface;
using InventoryManagement.Services.Model;
using MediatR;

namespace InventoryManagement.Core.Customer.Command;

public record DeleteSells(int Id) :IRequest <VmSells>;
public class DeleteSellsHandler :IRequestHandler<DeleteSells, VmSells>
{
    private readonly ISellsRepository _SellsRepository;

    public DeleteSellsHandler(ISellsRepository SellsRepository)
    {
        _SellsRepository = SellsRepository;
    }


    public async Task<VmSells> Handle(DeleteSells request, CancellationToken cancellationToken)
    {
        return await _SellsRepository.Delete(request.Id);
    }
}