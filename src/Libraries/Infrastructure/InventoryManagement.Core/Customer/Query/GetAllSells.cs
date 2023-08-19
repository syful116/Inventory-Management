using AutoMapper;
using InventoryManagement.Repositories.Interface;
using InventoryManagement.Services.Model;
using MediatR;

namespace InventoryManagement.Core.Customer.Query;
public record GetAllSells : IRequest<IEnumerable<VmSells>>;
public class GetAllSellsHandler : IRequestHandler<GetAllSells, IEnumerable<VmSells>>

{

    private readonly ISellsRepository _sellsRepository;


    public GetAllSellsHandler(ISellsRepository SellsRepository, IMapper mapper)
    {
        _sellsRepository = SellsRepository;
    }
    public async Task<IEnumerable<VmSells>> Handle(GetAllSells request, CancellationToken cancellationToken)
    {
        var result = await _sellsRepository.GetAll();
        return result;
    }

}