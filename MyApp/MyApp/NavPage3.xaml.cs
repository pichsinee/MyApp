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
	public partial class NavPage3 : ContentPage
	{
		public NavPage3 ()
		{
			InitializeComponent ();

            backButton.Clicked += BackButton_Clicked;
            backHomeButton.Clicked += BackHomeButton_Clicked;
		}

        private void BackHomeButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }

        private void BackButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}