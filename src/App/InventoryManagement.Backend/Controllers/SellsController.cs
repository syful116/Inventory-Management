using InventoryManagement.Core.Customer.Command;
using InventoryManagement.Core.Customer.Query;
using InventoryManagement.Services.Model;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SellsController : ControllerBase


{

    private readonly IMediator _mediator;

    public SellsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<VmCustomer>> GetById()
    {
        var data = await _mediator.Send(new GetAllSells());
        return Ok(data);
    }



    [HttpGet("id")]
    public async Task<ActionResult<VmSells>> GetAll(int id)
    {
        var data = await _mediator.Send(new GetSellsById(id));
        return Ok(data);
    }
    [HttpPost]
    public async Task<ActionResult<VmSells>> Add([FromBody] VmSells vmSells)
    {
        var data = await _mediator.Send(new CreateSells(vmSells));
        return Ok(data);

    }

    [HttpPut("id")]
    public async Task<ActionResult<VmSells>> Update(int id, [FromBody] VmSells vmSells)
    {


        var data = await _mediator.Send(new UpdateSells(id, vmSells));
        return Ok(data);
    }

    [HttpDelete("id")]
    public async Task<ActionResult<VmSells>> Delete(int id)
    {


        var data = await _mediator.Send(new DeleteSells(id));
        return Ok(data);
    }

}
