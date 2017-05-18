using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace FABExample
{
    public class FabViewModel : INotifyPropertyChanged
    {
        public Command FabCommand { get; }
        public ObservableCollection<string> LstItems { get; set; }

        public FabViewModel()
        {
            this.FabCommand = new Command(ExecuteFabCommand);

            LstItems = new ObservableCollection<string>();
            for (int i = 0; i < 30; i++)
            {
                LstItems.Add($"Test Line {i}");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private async void ExecuteFabCommand(object obj)
        {
            await Application.Current.MainPage.DisplayAlert("Fab Example", "Executando da ViewModel", "OK");
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
