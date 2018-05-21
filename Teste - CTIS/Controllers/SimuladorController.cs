using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Teste___CTIS.Models;

namespace Teste___CTIS.Controllers
{
    public class SimuladorController : ApiController
    {

        public Simulacao Post(decimal ValorTotal, int QtdParcela)
        {
            Simulacao simulado = new Simulacao(ValorTotal, QtdParcela);
            return simulado;
        }

        public Simulacao Get(decimal valor, int total)
        {
            Simulacao simulado = new Simulacao(valor, total);
            return simulado;
        }
    }
}
