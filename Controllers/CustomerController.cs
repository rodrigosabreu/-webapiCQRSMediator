using Microsoft.AspNetCore.Mvc;
using webapiCQRSMediator.Domain.Comands.Requests;
using webapiCQRSMediator.Domain.Handlers;
using webapiCQRSMediator.Domain.Queries.Requests;

namespace webapiCQRSMediator.Controllers
{
    [ApiController]
    [Route("customers")]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public IActionResult Create (
                   [FromServices] ICreateCustomerHandler handler,
                   [FromBody] CreateCustomerRequest command
        )
        {
            var response = handler.Handle(command);
            return Ok(response);
        }

        [HttpGet]
        [Route("")]
        public IActionResult Get(
                  [FromServices] IFindCustomerByIdHandler handler,
                  [FromBody] FindCustomerByIdRequest querie
       )
        {
            var response = handler.Handle(querie);
            return Ok(response);
        }

        [HttpGet]
        [Route("all")]
        public IActionResult GetAll(
                 [FromServices] IGetCustomersHandler handler,
                 [FromBody] GetCustomersRequest querie
      )
        {
            var response = handler.Handle(querie);
            return Ok(response);
        }
    }
}
