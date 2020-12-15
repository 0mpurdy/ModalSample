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

        private void PushModal_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
            Navigation.PushModalAsync(new ModalPage());
        }

        private void PopModalButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
