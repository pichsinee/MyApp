using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
		public Page2 ()
		{
			InitializeComponent ();

            nextButton.Clicked += NextButton_Clicked;

            backButton.Clicked += BackButton_Clicked;
		}

        private async void BackButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void NextButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page3());
        }
    }
}