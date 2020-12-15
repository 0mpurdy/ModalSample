using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ModalSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlternativeModalPage : ContentPage
    {
        public AlternativeModalPage()
        {
            InitializeComponent();
        }

        private async void PushModal_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync(false);
            await Navigation.PushModalAsync(new ModalPage(), false);
        }

        private async void PopModalButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
