using System;
using webapiCQRSMediator.Domain.Queries.Requests;
using webapiCQRSMediator.Domain.Queries.Responses;

namespace webapiCQRSMediator.Domain.Handlers
{
    public class FindCustomerByIdHandler : IFindCustomerByIdHandler
    {
        public FindCustomerByIdResponse Handle(FindCustomerByIdRequest command)
        {
            // TODO: Lógica de leitura se houver

            // Retorna o resultado
            return new FindCustomerByIdResponse
            {
                Id = Guid.NewGuid(),
                Name = "Rodrigo Resposta",
                Email = "teste@teste.com"                
            };
        }              
    }
}
