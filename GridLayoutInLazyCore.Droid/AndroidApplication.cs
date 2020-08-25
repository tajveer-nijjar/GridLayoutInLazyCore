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
using GridLayoutInLazyCore.Application;
using GridLayoutInLazyCore.Application.Views;
using GridLayoutInLazyCore.Droid.Views;
using LazyCore.Foundation.View;

namespace GridLayoutInLazyCore.Droid
{
    public class AndroidApplication : ApplicationCore
    {
        internal static AndroidApplication Instance { get; } = new AndroidApplication();

        private AndroidApplication()
        {

        }

        protected override void RegisterViewImplementations(IViewService viewService)
        {
            viewService.RegisterImplementation<IHomeView, HomeView>();
            // TODO: Register view implementations
        }

        protected override void RegisterPlatformServices()
        {
            // TODO: Register platform services, if any
        }

    }
}