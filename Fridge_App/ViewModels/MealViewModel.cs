using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Fridge_App.ViewModels
{
    public class MealViewModel : BaseViewModel
    {
        public MealViewModel()
        {
            Title = "Meal";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}