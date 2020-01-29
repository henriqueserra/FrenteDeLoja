using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeLoja_V001
    {
    public class Notas
        {
        public string NCFe { get; set; }
        public string Arquivo { get; set; }
        public string NumeroSerieSat { get; set; }
        public string Data { get; set; }
        public string DataEmissao { get; set; }
        public string HoraEmissao { get; set; }
        public string CNPJ { get; set; }
        public string Estabelecimento { get; set; }
        public string CPF_Destino { get; set; }
        public decimal ValorBruto { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal ValorFinal { get; set; }
        public decimal Tributos { get; set; }
        public string MeiodePagamento { get; set; }
        public decimal ValorMeiodePagamento { get; set; }
        public decimal ValorTroco { get; set; }
        }
    }