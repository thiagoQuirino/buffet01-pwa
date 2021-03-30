using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Buffet.Models;
using Buffet.Models.Buffet;
using Buffet.Models.Buffet.Cliente;
using Buffet.ViewModels.Home;
using Buffet.ViewModels.shared;

namespace Buffet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {



            // 1º Forma de enviar dados para a view
            ViewBag.InformacaoQualquer = "Informação Qualquer";

            // 2º Forma de enviar dados para a view
            ViewData["informacao"] = "Outra informação";
            // 3º Forma de enviar dados para a view
            var viewmodel = new IndexViewModel();
            viewmodel.InformacaoQualquer = "Informação pela View Model";
            viewmodel.Titulo = "Título qualquer";
            viewmodel.UsuarioLogado = new Usuario()
            {
                Nome = "Thiago",
                Idade = 36
            };
           
            
            return View(viewmodel);
        }

        
        public IActionResult PainelUsuario()
        {
            return View();
        }
        public IActionResult StatusConvidado()
        {
            //Acessando um service para obter a lista de
            // Status dos Eventos
            var listaStatusConvidado = new List<StatusConvidado>();
            listaStatusConvidado.Add(new StatusConvidado()
            {
                Id = 1,
                Descricao = "A confirmar"
            });
            listaStatusConvidado.Add(new StatusConvidado()
            {
                Id = 2,
                Descricao = "Confirmado"
            });
            listaStatusConvidado.Add(new StatusConvidado()
            {
                Id = 3,
                Descricao = "Desistente"
            });
            
            // Crio a view model
            var viewmodel = new StatusConvidadoViewModel();
            
            // Alimento a view model com os dados dos status
            foreach (StatusConvidado statusConvidado in listaStatusConvidado) {
                viewmodel.ListaDeStatus.Add(item: new Status()
                {
                    Id = statusConvidado.Id,
                    Descricao = statusConvidado.Descricao
                 
                });
            }
            
            return View(viewmodel);
        }
        public IActionResult StatusEvento()
        {
            // Acessando um service para obter a lista de
            // Status dos Eventos
            var listaStatusEventos = new List<StatusEvento>();
            listaStatusEventos.Add(new StatusEvento()
            {
                Id = 1,
                Descricao = "Reservado"
            });
            listaStatusEventos.Add(new StatusEvento()
            {
                Id = 2,
                Descricao = "Confirmado"
            });
            listaStatusEventos.Add(new StatusEvento()
            {
                Id = 3,
                Descricao = "Realizado"
            });
            
            // Crio a view model
            var viewmodel = new StatusEventoViewModel();
            
            // Alimento a view model com os dados dos status
            foreach (StatusEvento statusEvento in listaStatusEventos) {
             viewmodel.ListaDeStatus.Add(item: new Status()
             {
                 Id = statusEvento.Id,
                 Descricao = statusEvento.Descricao
                 
             });
            }
            
            return View(viewmodel);
        }
        public IActionResult Ajuda()
        {
            return View();
        }
        public IActionResult Secao1()
        {
            return View();
        }
       
        
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Cadastro()
        {
            return View();
        }
        public IActionResult TermoDeUso()
        {
            return View();
        }
        public IActionResult PoliticaDePrivacidade()
        {
            return View();
        }
        
        public IActionResult Clientes()
        {
            // Trazer lista de entidade clientes do serviço de clientes (model)
            var clienteService = new ClienteService();
            var listaDeClientes = clienteService.ObterClientes();

            // Criar e popular a viewmodel
            var viewModel = new ClientesViewModels();
            foreach (ClienteEntity clienteEntity in listaDeClientes) {
                viewModel.Clientes.Add(new Cliente
                {
                    Nome = clienteEntity.Nome,
                    DataDeNascimento = clienteEntity.DataDeNascimento.ToShortDateString(),
                    Idade = clienteEntity.Idade
                });
            }

            return View(viewModel);
        }
       
       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}