using webapiCQRSMediator.Domain.Comands.Requests;
using webapiCQRSMediator.Domain.Comands.Responses;

namespace webapiCQRSMediator.Domain.Handlers
{
    public interface ICreateCustomerHandler
    {
        CreateCustomerResponse Handle(CreateCustomerRequest command);
    }
}
