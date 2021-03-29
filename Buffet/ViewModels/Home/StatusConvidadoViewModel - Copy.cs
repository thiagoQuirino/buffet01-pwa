using System.Collections.Generic;
using Buffet.ViewModels.shared;

namespace Buffet.ViewModels.Home
{
    public class StatusConvidadoViewModel
    {
        public class TabelaDeStatusPartialViewModel
        {
            public List<Status> ListaDeStatus { get; set; }

            public TabelaDeStatusPartialViewModel()
            {
                ListaDeStatus = new List<Status>();
            }
        }
       
    }
}