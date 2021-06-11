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
    public partial class SemiJoiaDetailsPage : ContentPage
    {
        SemiJoia _semiJoia;

        public SemiJoiaDetailsPage(SemiJoia semijoia)
        {
            InitializeComponent();
            _semiJoia = semijoia;
            this.BindingContext = _semiJoia;
        }

        private async void btnProximo_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new SemiJoiaPedidoPage(_semiJoia));
        }
    }
}