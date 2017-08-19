using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SearchApi
{
	public partial class SearchPage : ContentPage
	{
		private	ApiHelper helper;

	

		async void search_clicked(object sender, System.EventArgs e)
		{
			var result = await helper.getJsonData(_searchtext.Text.ToString());

			_lstView.BindingContext = result.webPages.value;

		}


		public SearchPage()
		{
			InitializeComponent();

			helper = new ApiHelper();
		}
	}
}
