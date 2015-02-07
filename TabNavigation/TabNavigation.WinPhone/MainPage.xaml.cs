using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;


namespace TabNavigation.WinPhone {
	public partial class MainPage : FormsApplicationPage {
		public MainPage() {
			InitializeComponent();

			Forms.Init();
			LoadApplication(new TabNavigation.App());
		}
	}
}
