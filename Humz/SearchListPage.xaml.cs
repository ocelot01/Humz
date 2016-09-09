using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Humz
{
	public partial class SearchListPage : ContentPage
	{


		public SearchListPage()
		{
			InitializeComponent();
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			MockupData();

			await Navigation.PopAsync();

		}

		private void MockupData()
		{
			var songList = new SongModel[4];

			for (int i = 0; i < 4; i++)
			{
				SongModel newSong = new SongModel();
				newSong.SongName = "songNameMock" + i.ToString();
				newSong.Singer = "Cold Play";

				songList.SetValue(newSong, i);
			}

		}
	}
}

