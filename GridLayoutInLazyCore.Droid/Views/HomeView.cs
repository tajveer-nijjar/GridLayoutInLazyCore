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

namespace GridLayoutInLazyCore.Droid.Views
{
    [Activity(MainLauncher = true)]
    public class HomeView : View<IHomeView>, IHomeView
    {
        protected override void SetupView()
        {

        }

        protected override int LayoutResourceId => Resource.Layout.home_view;

    }
}