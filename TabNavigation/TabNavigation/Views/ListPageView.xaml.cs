using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TabNavigation.Views {
	public partial class ListPageView: ContentPage {
		public ListPageView() {
			InitializeComponent();

			txtclNavigateDetail.Command = new Command(() => {
				var page = new NavigationPage(new ListDetailPageView());
				Navigation.PushAsync(page);
			});

		}
	}
}
