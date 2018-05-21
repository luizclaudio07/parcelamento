using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Teste___CTIS.Models
{
    public class Parcela
    {
        public decimal Numero { get; set; }
        public DateTime Vencimento { get; set; }
        public decimal Valor { get; set; }
        public decimal ValorAtualizado { get; set; }
        public decimal ValorRemanescente { get; set; }
        public decimal ValorCorrecao { get; set; }

        public Parcela()
        {
            this.Vencimento = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 15);
            //this.Vencimento.AddMonths(1);
        }

    }
}