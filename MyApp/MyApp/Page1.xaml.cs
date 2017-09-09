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
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();

            nextButton.Clicked += NextButton_Clicked;
		}

        private async void NextButton_Clicked(object sender, EventArgs e)
        {
            await nextButton.RotateTo(360, 1000);
            await nextButton.RotateTo(0, 1);
            await Navigation.PushModalAsync(new Page2());   //คำสั่งในการเชื่อมโยงไปหน้าอื่นๆ
        }
    }
}