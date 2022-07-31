using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiCQRSMediator.Domain.Comands.Requests;
using webapiCQRSMediator.Domain.Comands.Responses;

namespace webapiCQRSMediator.Domain.Handlers
{
    public class CreateCustomerHandler : ICreateCustomerHandler
    {


        public CreateCustomerResponse Handle(CreateCustomerRequest command)
        {
            // Aplicar Fail Fast Validations
            // Cria a entidade
            // Persiste a entidade no banco
            // Envia E-mail de boas-vindas
            // Retorna a resposta
            return new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Rodrigo",
                Email = "teste@teste.com",
                Date = DateTime.Now
            };
        }
    }
}
