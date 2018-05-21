using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Teste___CTIS.Models
{
    public class Simulacao
    {

        public List<Parcela> Parcelas;
        public int TotalParcelas;
        public decimal ValorTotal;
        public decimal ValorAtualizado;
        public decimal ValorCorrecao;
        public string Mensagem;

        public Simulacao(decimal v, int t)
        {
            this.TotalParcelas = t;
            this.ValorTotal = v;
            this.Parcelas = new List<Parcela>();
            this.Mensagem = string.Empty;
            this.ValorAtualizado = 0;
            CriarParcelas();
        }

        private void CriarParcelas()
        {

            if(this.TotalParcelas < 2 || this.TotalParcelas > 60)
            {
                this.Mensagem = "O número mínimo e máximo de parcelas é 2 e 60, respectivamente.";
                return;
            }


            for(int i = 0; i < this.TotalParcelas; i++)
            {
                Parcela p = new Parcela();

                p.Numero = (i + 1);

                p.Valor = Math.Round(p.Numero == 1 ? this.ValorTotal / this.TotalParcelas : Parcelas[i - 1].Valor * (decimal)1.01, 2);

                if(this.ValorTotal > (decimal)2000 && p.Valor < (decimal)200)
                {
                    this.Mensagem = "O valor da parcela para seu crédito não pode ser inferior a 200,00.";
                    return;
                }
                else if(this.ValorTotal <= (decimal)2000 && p.Valor < (decimal)50)
                {
                    this.Mensagem = "O valor da parcela para seu crédito não pode ser inferior a 50,00.";
                    return;
                }

                p.ValorAtualizado = Math.Round(p.Numero == 1 ? this.ValorTotal : Parcelas[i - 1].ValorRemanescente * (decimal)1.01, 2);

                p.Vencimento = p.Vencimento.AddMonths(i + 1);

                p.ValorCorrecao = Math.Round(p.Numero == 1 ? (decimal)0.0 : p.Valor- Parcelas[0].Valor, 2);

                p.ValorRemanescente = Math.Round(p.ValorAtualizado - p.Valor, 2);

                Parcelas.Add(p);
            }

            this.ValorAtualizado = this.ValorTotal + (Parcelas.Sum(x => x.ValorCorrecao));
            this.ValorCorrecao = this.ValorAtualizado - this.ValorTotal;
        }
    }
}