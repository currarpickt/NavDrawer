
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V7.App;
using Toolbar = Android.Support.V7.Widget.Toolbar;
using Android.Support.Design.Widget;
using Android.Support.V4.Widget;

namespace NavDrawer.Droid
{
    [Activity(MainLauncher = true)]
    public class RootViewActivity : AppCompatActivity
    {
		NavigationView navigationView;
		DrawerLayout drawerLayout;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

			// Create your application here
            SetContentView(Resource.Layout.RootView);
            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbarPlanViewer);
			SetSupportActionBar(toolbar);

			navigationView = FindViewById<NavigationView>(Resource.Id.navigationViewMenu);
            navigationView.NavigationItemSelected += OnNavigationItemSelected;

			drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawerLayout);
        }

		void OnNavigationItemSelected(object sender, NavigationView.NavigationItemSelectedEventArgs e)
		{
			var menuItem = e.MenuItem;

			menuItem.SetChecked(!menuItem.IsChecked);
			drawerLayout.CloseDrawers();

			switch (menuItem.ItemId)
			{
				case Resource.Id.drawerItemSearch:
					Toast.MakeText(Application.Context, Resource.String.search, ToastLength.Short).Show();
					break;
				case Resource.Id.drawerItemSettings:
					Toast.MakeText(Application.Context, Resource.String.setting, ToastLength.Short).Show();
					break;
				case Resource.Id.drawerItemSync:
					Toast.MakeText(Application.Context, Resource.String.sync, ToastLength.Short).Show();
					break;
				case Resource.Id.drawerItemLogout:
					Toast.MakeText(Application.Context, Resource.String.logout, ToastLength.Short).Show();
					break;
			}
		}
    }
}
