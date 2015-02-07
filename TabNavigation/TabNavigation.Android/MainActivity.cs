﻿using Android.App;
using Android.Content.PM;
using Android.OS;

using Xamarin.Forms.Platform.Android;

namespace TabNavigation.Droid {
	[Activity(Label = "TabNavigation", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : FormsApplicationActivity {
		protected override void OnCreate(Bundle bundle) {
			base.OnCreate(bundle);
			Xamarin.Forms.Forms.Init(this, bundle);
			LoadApplication(new App());
		}
	}
}

