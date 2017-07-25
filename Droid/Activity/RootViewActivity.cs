﻿
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

namespace NavDrawer.Droid
{
    [Activity(MainLauncher = true)]
    public class RootViewActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

			// Create your application here
            SetContentView(Resource.Layout.RootView);
            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbarPlanViewer);
			SetSupportActionBar(toolbar);
        }
    }
}
