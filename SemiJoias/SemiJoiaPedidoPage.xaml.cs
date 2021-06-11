using SemiJoias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SemiJoias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SemiJoiaPedidoPage : ContentPage
    {
        SemiJoia _semijoia;
        Usuario _usuario;

        public SemiJoiaPedidoPage(SemiJoia semiJoia)
        {
            InitializeComponent();
            this._semijoia = semiJoia;
            this.BindingContext = _semijoia;
        }

        private async void btnPedido_Clicked(object sender, EventArgs e)
        {
            if (_semijoia == null)
                return;

            // definido um if com todos o dados juntos
            if (string.IsNullOrEmpty(strNome.Text) ||
                string.IsNullOrEmpty(strEndereco.Text) ||
                string.IsNullOrEmpty(strTelefone.Text) ||
                string.IsNullOrEmpty(strEmail.Text)
                )
            {
                //caso estejam nulos, retorna este alerta
                await DisplayAlert("Alerta", "Preencha todos os dados", "Voltar");
                return;
            }
            //caso estejam preenchidos ele proseegue para a próxima tela
            else
            {
                _usuario = new Usuario();
                _usuario.Nome = strNome.Text;
                _usuario.Endereço = strEndereco.Text;
                _usuario.Telefone = strTelefone.Text;
                _usuario.Email = strEmail.Text;

                await this.Navigation.PushModalAsync(new SemiJoiaPedidoConfirmacao(_semijoia));
            }
        }
    }
}