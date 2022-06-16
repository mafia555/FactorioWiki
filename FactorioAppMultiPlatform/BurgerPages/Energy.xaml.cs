using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FactorioAppMultiPlatform.BurgerPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Energy : ContentPage
    {
        public Energy()
        {
            InitializeComponent();
            BindingContext = this;
        }
        public ICommand TapCommand => new Command(OpenWindow);
        public void OpenWindow()
        {
            Navigation.PushAsync(new Page2());
        }
    }
}