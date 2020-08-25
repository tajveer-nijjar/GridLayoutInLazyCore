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
using LazyCore.Droid;

namespace GridLayoutInLazyCore.Droid
{
    [Application]
    public class Application : LazyCoreAndroidApplication
    {
        public Application(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
        {

        }

        public override LazyCore.Foundation.Application GetApplication() => AndroidApplication.Instance;

    }
}