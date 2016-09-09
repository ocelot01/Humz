using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Humz
{
	public partial class DetileSongPage : ContentPage
	{
		public DetileSongPage(SongModel song)
		{
			InitializeComponent();

			labelSongName.Text = "ชื่อเพลง: " + song.SongName;
			labelSingeg.Text = "นักร้อง: " + song.Singer;
		}

	}
}

