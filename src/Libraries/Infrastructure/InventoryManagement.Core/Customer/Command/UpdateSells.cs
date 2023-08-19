using AutoMapper;
using InventoryManagement.Repositories.Interface;
using InventoryManagement.Services.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Core.Customer.Command;
public record UpdateSells(int Id, VmSells VmSells) : IRequest<VmSells>;
public class UpdateSellsHandler : IRequestHandler<UpdateSells, VmSells>

{

    private readonly ISellsRepository _SellsRepository;
    private readonly IMapper _mapper;
    public UpdateSellsHandler(ISellsRepository SellsRepository, IMapper mapper)
    {
        _SellsRepository = SellsRepository;
        _mapper = mapper;
    }
    public async Task<VmSells> Handle(UpdateSells request, CancellationToken cancellationToken)
    {
        var data = _mapper.Map<Model.Sells>(request.VmSells);
        return await _SellsRepository.Update(request.Id, data);
    }
}
