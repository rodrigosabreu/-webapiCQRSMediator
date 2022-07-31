using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapiCQRSMediator.Domain.Queries.Responses
{
    public class GetCustomersResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
