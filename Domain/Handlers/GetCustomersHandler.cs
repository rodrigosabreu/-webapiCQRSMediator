using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiCQRSMediator.Domain.Queries.Requests;
using webapiCQRSMediator.Domain.Queries.Responses;

namespace webapiCQRSMediator.Domain.Handlers
{
    public class GetCustomersHandler: IGetCustomersHandler
    {
        public List<GetCustomersResponse> Handle(GetCustomersRequest command)
        {
            // TODO: Lógica de leitura se houver

            // Retorna o resultado
            return new List<GetCustomersResponse>
            {

                new GetCustomersResponse { 
                    Id = Guid.NewGuid(),
                    Name = "Rodrigo Resposta",
                    Email = "teste@teste.com"
                },
                new GetCustomersResponse {
                    Id = Guid.NewGuid(),
                    Name = "Rafaela Resposta",
                    Email = "teste@teste.com"
                },

            };
        }
    }
}
