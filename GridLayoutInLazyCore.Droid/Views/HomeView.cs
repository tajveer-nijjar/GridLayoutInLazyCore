using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Util;
using Android.Views;
using Android.Widget;
using GridLayoutInLazyCore.Application.Views;
using GridLayoutInLazyCore.Droid.Adapters;
using LazyCore.Droid.Views;

namespace GridLayoutInLazyCore.Droid.Views
{
    [Activity(MainLauncher = true)]
    public class HomeView : View<IHomeView>, IHomeView
    {
        private List<int> _data;
        public event EventHandler<RecyclerAdapterClickEventArgs> ItemClick;

        public HomeView()
        {
            _data = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.home_view);



            // Get our button from the layout resource,
            // and attach an event to it
            RecyclerView recyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);

            var spanCount = IsTablet(this) ? 2 : 1;
            var gridLayoutManager = new GridLayoutManager(this, spanCount: spanCount);
            recyclerView.SetLayoutManager(gridLayoutManager);

            recyclerView.HasFixedSize = true;
            var adapter = new RecyclerAdapter(_data);
            recyclerView.SetAdapter(adapter);
            adapter.ItemClick += (e, args) =>
            {
                Toast.MakeText(this, args.Position.ToString(), ToastLength.Short).Show();
            };

            var surfaceOrientation = WindowManager.DefaultDisplay.Rotation;

            if (surfaceOrientation == SurfaceOrientation.Rotation90 || surfaceOrientation == SurfaceOrientation.Rotation270)
            {
                if (IsTablet(this))
                {
                    spanCount = 3;
                }
                else
                {
                    spanCount = 2;
                }

                gridLayoutManager.SpanCount = spanCount;
                adapter.NotifyDataSetChanged();
            }
        }

        private bool IsTablet(Context context)
        {
            Display display = ((Activity)context).WindowManager.DefaultDisplay;
            DisplayMetrics displayMetrics = new DisplayMetrics();
            display.GetMetrics(displayMetrics);

            var wInches = displayMetrics.WidthPixels / (double)displayMetrics.DensityDpi;
            var hInches = displayMetrics.HeightPixels / (double)displayMetrics.DensityDpi;

            double screenDiagonal = Math.Sqrt(Math.Pow(wInches, 2) + Math.Pow(hInches, 2));
            return (screenDiagonal >= 6.0);
        }

        protected override void SetupView()
        {

        }

        protected override int LayoutResourceId => Resource.Layout.home_view;
    }
}