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
    public partial class SemiJoiaPedidoConfirmacao : ContentPage
    {
        public SemiJoiaPedidoConfirmacao(SemiJoia semijoia)
        {
            InitializeComponent();
            this.BindingContext = semijoia;
        }
    }
}