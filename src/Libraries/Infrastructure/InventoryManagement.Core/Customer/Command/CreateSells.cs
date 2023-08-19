using AutoMapper;
using InventoryManagement.Repositories.Interface;
using InventoryManagement.Services.Model;
using MediatR;

namespace InventoryManagement.Core.Customer.Command;

public  record CreateSells(VmSells VmSells) : IRequest<VmSells>;
public class CrateSellsHandler : IRequestHandler<CreateSells, VmSells>
{
    private readonly ISellsRepository _sellsRepository;
    private readonly IMapper _mapper;
    public CrateSellsHandler(ISellsRepository SellsRepository,
IMapper mapper)
    {
        _sellsRepository = SellsRepository;
        _mapper = mapper;
    }
    public async Task<VmSells> Handle(CreateSells request, CancellationToken cancellationToken)
    {
        var data = _mapper.Map<Model.Sells>(request.VmSells);
        return await _sellsRepository.Add(data);
    }
}

