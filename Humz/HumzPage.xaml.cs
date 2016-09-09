using Xamarin.Forms;
using System.Diagnostics;

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

		private void MockupData()
		{
			var songList = new SongModel[4];
			
			for (int i = 0; 1 < 4; i++)
			{
				SongModel newSong = new SongModel();
				newSong.SongName = "songNameMock" + i.ToString();
				newSong.Singer = "Cold Play";

				songList.SetValue(newSong, i);
			}
		}
	}
}

