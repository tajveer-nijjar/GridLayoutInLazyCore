using GridLayoutInLazyCore.Application.ViewControllers;
using GridLayoutInLazyCore.Application.Views;
using LazyCore.Foundation.View;
using System;

namespace GridLayoutInLazyCore.Application
{
    public abstract class ApplicationCore : LazyCore.Foundation.Application
    {
        protected override void RegisterViewControllers(IViewService viewService)
        {
            viewService.RegisterController<IHomeView, HomeController>();
            // View controllers...
        }

        protected override void RegisterCrossPlatformServices()
        {
            // Cross platform services...
        }

        public override Type InitialView => typeof(IHomeView);
    }
}
