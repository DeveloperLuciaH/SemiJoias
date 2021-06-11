using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SemiJoias.Models
{
    public class SemiJoia: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; }
        public string preco_tela { get; set; }

        private const decimal TAXA_ENTREGA = 15.00M;
        private const decimal EMBALAGEM = 5.00M;

        public string TextoTaxa
        {
            get { return String.Format("Taxa de Entrega - R$ {0}", TAXA_ENTREGA); }

        }

        public string TextoEmbalagem
        {
            get { return String.Format("Embalagem - R$ {0}", EMBALAGEM); }
        }

        public string ValorTotal
        {
            get { return String.Format("Valor Total: R$ {0}", Preco + (TemTaxa ? TAXA_ENTREGA : 0) + (TemEmbalagem ? EMBALAGEM : 0)); }
        }

        private bool temTaxa;
        public bool TemTaxa
        {
            get { return temTaxa; }
            set
            {
                temTaxa = value;
                RaisePropertyChanged(nameof(ValorTotal));
            }
        }

        private bool temEmbalagem;
        public bool TemEmbalagem
        {
            get { return temEmbalagem; }
            set
            {
                temEmbalagem = value;
                RaisePropertyChanged(nameof(ValorTotal));
            }
        }

    



    }
}
