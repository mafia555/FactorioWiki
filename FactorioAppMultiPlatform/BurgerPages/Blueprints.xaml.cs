using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FactorioAppMultiPlatform.BurgerPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Blueprints : ContentPage
    {
        public ICommand TapCommand_Tile => new Command(OpenWindow);

        public void OpenWindow()
        {
            Navigation.PushAsync(new Page2());
        }

        public Blueprints()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}