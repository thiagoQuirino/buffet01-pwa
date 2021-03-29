using System.Collections.Generic;

namespace Buffet.ViewModels.Home
{
    public class ClientesViewModels
    {
        public List<Cliente> Clientes { get; set; }

        public ClientesViewModels()
        {
            Clientes = new List<Cliente>();
        }
    }

    public class Cliente
    {
        public string Nome { get; set; }
        public string DataDeNascimento { get; set; }
        
        public int Idade { get; set; }
    }
}