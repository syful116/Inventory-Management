using InventoryManagement.Core.Customer.Command;
using InventoryManagement.Core.Customer.Query;
using InventoryManagement.Services.Model;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Backend.Controllers;


[Route("api/[controller]")]
[ApiController]
public class CustomereController : ControllerBase


{

    private readonly IMediator _mediator;

    public CustomereController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<VmCustomer>> GetById()
    {
        var data = await _mediator.Send(new GetAllCustomer());
        return Ok(data);
    }



    [HttpGet("id")]
    public async Task<ActionResult<VmCustomer>> GetAll(int id)
    {
        var data = await _mediator.Send(new GetCustomerById(id));
        return Ok(data);
    }
    [HttpPost]
    public async Task<ActionResult<VmCustomer>> Add([FromBody] VmCustomer vmProduct)
    {
        var data = await _mediator.Send(new CreateCustomer(vmProduct));
        return Ok(data);

    }

    [HttpPut("id")]
    public async Task<ActionResult<VmCustomer>> Update(int id, [FromBody] VmCustomer vmProduct)
    {
        

        var data = await _mediator.Send(new UpdateCustomer(id, vmProduct));
        return Ok(data);
    }

    [HttpDelete("id")]
    public async Task<ActionResult<VmCustomer>> Delete(int id)
    {
       

        var data = await _mediator.Send(new DeleteCustomer(id));
        return Ok(data);
    }

}