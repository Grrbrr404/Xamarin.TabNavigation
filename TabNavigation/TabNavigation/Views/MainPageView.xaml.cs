using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TabNavigation.Views {
	public partial class MainPageView : TabbedPage {
		public MainPageView() {
			InitializeComponent();

			Children.Add(new MenuePageView() { Title = "Menu"});
			Children.Add(new SettingsPageView() { Title = "Setitngs"});

		}
	}
}
