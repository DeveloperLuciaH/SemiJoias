using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace SemiJoias.Models
{
    public class Frete
    {
        public int FreteId { get; set; }
        public string Nome { get; set; }
        public string Preco { get; set; }

        public decimal Taxa_Entrega { get; } = 15.00M;
        public decimal Embalagem { get; } = 5.00M;
    }
}
