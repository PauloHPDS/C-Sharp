using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Exemplo_Explorando.models
{
    public class vendaTipoNulo
    {
        public int Id{get;set;}
        [JsonProperty("Nome_Produto")]
        public string Produto{get;set;}
        public decimal Preco{get;set;}
        public DateTime DataVenda{get;set;}
        public decimal? Desconto{get;set;}

    }
}