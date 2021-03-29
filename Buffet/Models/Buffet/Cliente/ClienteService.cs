using System;
using System.Collections.Generic;

namespace Buffet.Models.Buffet.Cliente
{
    public class ClienteService
    {
        public List<ClienteEntity> ObterClientes()
        {
            var listaDeClientes = new List<ClienteEntity>();

            listaDeClientes.Add(new ClienteEntity
            {
                Id = 1,
                Nome = "Thiago",
                DataDeNascimento = new DateTime(1986, 12, 1),
                Idade = 36
            });

            listaDeClientes.Add(new ClienteEntity
            {
                Id = 2,
                Nome = "José",
                DataDeNascimento = new DateTime(1977, 09,  25),
                Idade = 50
            });

            return listaDeClientes;
        }
    }
    
}