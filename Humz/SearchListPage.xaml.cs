using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Humz
{
	public partial class SearchListPage : ContentPage
	{
		SongModel newSong = new SongModel();

		public SearchListPage()
		{
			InitializeComponent();

			newSong.SongName = "Down with the Sickness";
			newSong.Singer = "Distrub";

			labelSong.Text = labelSong.Text + newSong.SongName;
			labelSinger.Text = labelSinger.Text + newSong.Singer;
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			//var songList = new SongModel[4];

			//for (int i = 0; i < 4; i++)
			//{
			//	SongModel newSong = new SongModel();
			//	newSong.SongName = "songNameMock" + i.ToString();
			//	newSong.Singer = "Cold Play";

			//	songList.SetValue(newSong, i);
			//}

			SongModel cacheSong = new SongModel();
			cacheSong.SongName = labelSong.Text;
			cacheSong.Singer = labelSinger.Text;

			await Navigation.PushAsync(new DetileSongPage(newSong), true);
		}
	}
}

