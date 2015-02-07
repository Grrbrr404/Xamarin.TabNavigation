using Xamarin.Forms;

namespace TabNavigation.Views {
	public partial class MenuePageView : ContentPage {
		public MenuePageView() {
			InitializeComponent();
			txtclNavigate.Command = new Command(() => {
				var page = new ListPageView();
				Navigation.PushAsync(new NavigationPage(page));
			});
		}
	}
}
