using webapiCQRSMediator.Domain.Queries.Requests;
using webapiCQRSMediator.Domain.Queries.Responses;

namespace webapiCQRSMediator.Domain.Handlers
{
    public interface IFindCustomerByIdHandler
    {
        FindCustomerByIdResponse Handle(FindCustomerByIdRequest command);        
    }
}
