using GridLayoutInLazyCore.Application.ViewControllers;
using GridLayoutInLazyCore.Application.Views;
using GridLayoutInLazyCore.BusinessLogic.VideoManager;
using LazyCore.Foundation;
using LazyCore.Foundation.View;
using ProductX.BusinessLogic.EnvironmentManager;
using ProductX.BusinessLogic.WebApi;
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
            IoC.RegisterSingleton<IVideoManager, VideoManager>();
            IoC.RegisterSingleton<IWebApiClient, WebApiClient>();
            IoC.RegisterSingleton<IEnvironmentManager, EnvironmentManager>();
            // Cross platform services...
        }

        public override Type InitialView => typeof(IHomeView);
    }
}
