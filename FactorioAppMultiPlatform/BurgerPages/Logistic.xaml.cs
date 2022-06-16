using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FactorioAppMultiPlatform
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public ICommand TapCommand => new Command(OpenWindow);

        //Я на эти гиперссылки потратил полтора часа своей жизни для того чтобы оно работало
        //Пример выше

        //Чтобы работало надо создать public ICommand и лямбдой передать в него любой void метод, который ничего не принимает, с помощью new Command(Метод)
        //В xaml`е лучше просто скопируй как у меня и не мучайся, менять надо только название ICommand

        //Все страницы надо делать через ScrollView, чтобы листалось
        //Страничики добавляй в эту же папочку, чтобы остальной проект не засорять; при указании на них надо BurgerPages.Страница писать

        public Page1()
        {
            InitializeComponent();
            BindingContext = this;
        }

        public void OpenWindow()
        {
            Navigation.PushAsync(new Page2());
        }

        protected override void OnAppearing()
        {
        }

        //Методы для таблицы
        //Если я все еще не сделал это, то тут просто меняй Page на нужный
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

        void logTap6(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }
    }
}