using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ModalSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModalPage : ContentPage
    {
        public ModalPage()
        {
            InitializeComponent();
        }

        private async void PushAlternativeModal_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync(false);
            await Navigation.PushModalAsync(new AlternativeModalPage(), false);
        }

        private async void PopModalButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
