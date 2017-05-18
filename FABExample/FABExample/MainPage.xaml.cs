using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FABExample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //Fab.Clicked = async (sender, args) =>
            //{
            //    await this.DisplayAlert("Fab Example", "Executando click!", "OK");
            //};

            this.BindingContext = new FabViewModel();
        }

        public Command FabExecuteCommand
        {
            get
            {
                return new Command(async () => await OnFabExecuted());
            }
        }

        private async Task OnFabExecuted()
        {
            await DisplayAlert("Fab", "Hide and show the Fab?", "OK");
        }
    }
}
