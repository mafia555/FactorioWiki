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
    public partial class Pollution : ContentPage
    {
        public ICommand TapCommand => new Command(OpenWindow);

        public Pollution()
        {
            InitializeComponent();
            BindingContext = this;
        }

        public void OpenWindow()
        {
            Navigation.PushAsync(new Page2());
        }

        void logTap1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }

        void logTap2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }

        void logTap3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }
        void logTap4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }
        void logTap5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }
    }
}