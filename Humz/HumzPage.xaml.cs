using Xamarin.Forms;

namespace Humz
{
	public partial class HumzPage : ContentPage
	{
		public HumzPage()
		{
			InitializeComponent();
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new SearchListPage());
		}
	}
}

