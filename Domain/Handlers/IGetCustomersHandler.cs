using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiCQRSMediator.Domain.Queries.Requests;
using webapiCQRSMediator.Domain.Queries.Responses;

namespace webapiCQRSMediator.Domain.Handlers
{
    public interface IGetCustomersHandler
    {
        List<GetCustomersResponse> Handle(GetCustomersRequest command);
    }
}
