using SemiJoias.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SemiJoias
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            LvSemiJoias.ItemsSource = new List<SemiJoia>
            {

                new SemiJoia
                {
                    ImagemUrl="braceletes.png",
                    Nome="BRACELETES EM MICRO ZIRCÔNIA",
                    Descricao="BANHADOS A OURO E RÓDIO",
                    Status="Ativo",
                    Preco=1680.00M,
                    preco_tela="R$ 1.680,00",
                   },

                 new SemiJoia
                {
                    ImagemUrl="cjperola.png",
                    Nome="CONJUNTO PÉROLA",
                    Descricao="PULSEIRA COM RELICÁRIO - BANHADO A OURO",
                    Status="Ativo",
                    Preco=350.00M,
                    preco_tela="R$ 350,00",
                },


                new SemiJoia

                {
                    ImagemUrl="escapulario.png",
                    Nome="ESCAPULÁRIO EM MICRO ZIRCÔNIAS",
                    Descricao="BANHADO A OURO - 70CM",
                    Status="Ativo",
                    Preco=280.00M ,
                    preco_tela="R$ 280,00",

                },

                new SemiJoia 
                {
                    ImagemUrl="fe.png",
                    Nome="GARGANTILHA FÉ EM MICRO ZIRCÔNIA", 
                    Descricao="BANHADO A OURO - 40CM", 
                    Status="Ativo", 
                    Preco=160.00M,
                    preco_tela="R$ 160,00",
                },

                               
                new SemiJoia 
                {
                    ImagemUrl="earhock.png",
                    Nome="BRINCO EAR HOCK EM MICRO ZIRCÔNIA", 
                    Descricao="BANHADO A OURO", 
                    Status="Ativo", 
                    Preco=70.00M,
                    preco_tela="R$ 70,00",
                    },

                new SemiJoia 
                {
                    ImagemUrl="perola.png",
                    Nome="BRINCO PÉROLA COM MICRO ZIRCÔNIA", 
                    Descricao="BANHADO A OURO", 
                    Status="Ativo", 
                    Preco=125.00M,
                    preco_tela="R$ 125,00",
                },

                new SemiJoia 
                {
                    ImagemUrl="cristal.png",
                    Nome="BRINCO CRISTAL", 
                    Descricao="BANHADO A OURO", 
                    Status="Ativo", 
                    Preco=65.00M,
                    preco_tela="R$ 65,00",
                },

                 new SemiJoia
                 {
                    ImagemUrl="tornozeleira.png",
                    Nome="TORNOZELEIRA COM PONTO DE LUZ",
                    Descricao="BANHADO A RODIO",
                    Status="Ativo",
                    Preco=80.00M,
                    preco_tela="R$ 80,00",
                 },

                  new SemiJoia
                {
                    ImagemUrl="mandala.png",
                    Nome="GARGANTILHA MANDALA",
                    Descricao="BANHO RÓDIO NEGRO - 45CM",
                    Status="Ativo",
                    Preco=100.00M,
                    preco_tela="R$ 100,00",
                }

            };
        }

        private async void LvSemiJoias_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //aqui foi criado uma variavel para receber o alert e pegar o valor true ou false dele
            var recebeAlerta = await DisplayAlert("Mensagem", "Produto adicionado à sacola de compras!", "Continuar comprando", "Finalizar Compra");

            //com o valor false no clique(finalizar venda) ele faz a ação e vai para próxima tela
            if (recebeAlerta == false)
            {
                var semijoia = e.SelectedItem as SemiJoia;

                if (semijoia == null)
                    return;
                await this.Navigation.PushAsync(new SemiJoiaDetailsPage(semijoia));
            }
            else
            //com o else ele retorna a página.
            {
                return;
            }
        }
    }
}

    
