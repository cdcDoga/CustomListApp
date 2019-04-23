using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CustomListApp.ViewModals;

namespace CustomListApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailPage : ContentPage
	{
		public DetailPage(ListElementViewModal item)
		{
			InitializeComponent ();

            BindingContext = item;
        }

        async void Dismiss(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}