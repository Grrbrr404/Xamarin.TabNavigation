using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TabNavigation.Views;
using Xamarin.Forms;

namespace TabNavigation {
	public class App : Application {
		public App() {
			MainPage = new NavigationPage(new MainPageView());
		}
	}
}
