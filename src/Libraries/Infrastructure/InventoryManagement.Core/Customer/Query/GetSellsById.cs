using InventoryManagement.Repositories.Interface;
using InventoryManagement.Services.Model;
using MediatR;

namespace InventoryManagement.Core.Customer.Query;

public record GetSellsById(int id) : IRequest<VmSells>;

public class GetSellsByIdHandler : IRequestHandler<GetSellsById, VmSells>
{


    private readonly ISellsRepository _SellsRepository;
    public GetSellsByIdHandler(ISellsRepository sellsRepository)
    {
        _SellsRepository = sellsRepository;
    }
    public async Task<VmSells> Handle(GetSellsById request, CancellationToken cancellationToken)
    {
        return await _SellsRepository.GetById(request.id);
    }
}