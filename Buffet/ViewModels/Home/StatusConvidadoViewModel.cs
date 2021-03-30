using System.Collections.Generic;
using Buffet.ViewModels.shared;

namespace Buffet.ViewModels.Home
{
    public class StatusConvidadoViewModel
    {
       
        
            public List<Status> ListaDeStatus { get; set; }

            public StatusConvidadoViewModel()
            {
                ListaDeStatus = new List<Status>();
            }
        
       
    }
}